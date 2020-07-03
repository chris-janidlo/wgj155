using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpinRuleMinimum.asset", menuName = "AI Rules/Spin Minimum")]
public class SpinRuleMinimum : SpinRule
{
    public Spin DesiredMinimumSpin;

    public override Spin CalculateRule (Top agent, Top target, IList<Top> others)
    {
        return Mathf.Max(agent.CurrentSpin, DesiredMinimumSpin);
    }
}
