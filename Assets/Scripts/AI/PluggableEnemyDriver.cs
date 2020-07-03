using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class PluggableEnemyDriver : MonoBehaviour
{
    [Serializable]
    public class WeightedTargetRule : WeightedTuple<TargetRule> {}

    [Serializable]
    public class WeightedsSpinRule : WeightedTuple<SpinRule> {}

    [Serializable]
    public class WeightedVelocityRule : WeightedTuple<VelocityRule> {}

    public Top Top;
    public TopValueList TopsInScene;

    public List<WeightedTargetRule> TargetRules;
    public List<WeightedsSpinRule> SpinRules;
    public List<WeightedVelocityRule> VelocityRules;

    [SerializeField]
    Top previousTarget;

    void Update ()
    {
        var otherTops = TopsInScene.Where(t => t != Top).ToList();
        Top target = calculateTarget(previousTarget, otherTops);
        Spin desiredSpin = calculateDesiredSpin(target, otherTops);
        Vector3 desiredVelocity = calculateDesiredVelocity(target, otherTops);

        Top.SetSpinInput(determineSpinInput(desiredSpin));
        Top.SetDirectionalInput(determineDirectionalInput(desiredVelocity));

        previousTarget = target;
    }

    Top calculateTarget (Top previousTarget, IList<Top> others)
    {
        List<TargetRule.WeightedTop> topWeights = null;

        foreach (var targetRule in TargetRules)
        {
            var weightedRuleCalculation = targetRule.Value.CalculateRule(Top, previousTarget, others)
                .Select(wt => new TargetRule.WeightedTop(wt.Value, wt.Weight * targetRule.Weight))
                .ToList();

            if (topWeights == null)
            {
                topWeights = weightedRuleCalculation;
            }
            else
            {
                topWeights = topWeights.Zip(weightedRuleCalculation, (wt1, wt2) => new TargetRule.WeightedTop(wt1.Value, wt1.Weight + wt2.Weight)).ToList();
            }
        }

        return topWeights.Aggregate((wt1, wt2) => wt1.Weight > wt2.Weight ? wt1 : wt2).Value;
    }

    Spin calculateDesiredSpin (Top target, IList<Top> others)
    {
        float weightedAverageTop = 0, weightedAverageBottom = 0;

        foreach (var spinRule in SpinRules)
        {
            weightedAverageTop += spinRule.Weight * spinRule.Value.CalculateRule(Top, target, others);
            weightedAverageBottom += spinRule.Weight;
        }

        return weightedAverageTop / weightedAverageBottom;
    }

    Vector3 calculateDesiredVelocity (Top target, IList<Top> others)
    {
        return VelocityRules
            .Select(vr => vr.Weight * vr.Value.CalculateRule(Top, target, others))
            .Aggregate((v1, v2) => v1 + v2);
    }

    bool determineSpinInput (Spin desiredSpin)
    {
        return Top.CurrentSpin < desiredSpin;
    }

    Vector3 determineDirectionalInput (Vector3 desiredVelocity)
    {
        return (desiredVelocity - Top.Rigidbody.velocity).normalized;
    }
}
