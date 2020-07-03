using System.Linq;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTargetRuleNearbyTops.asset", menuName = "AI Rules/Target Nearby Tops")]
public class TargetRuleNearbyTops : TargetRule
{
	public override IEnumerable<WeightedTop> CalculateRule(Top agent, Top previousTarget, IList<Top> others)
	{
        var otherDistances = others.Select(t => Vector3.Distance(agent.transform.position, t.transform.position));
        float maxDistance = otherDistances.Max();

        return others.Zip(otherDistances, (t, d) => new WeightedTop(t, 1 - (d / maxDistance)));
	}
}
