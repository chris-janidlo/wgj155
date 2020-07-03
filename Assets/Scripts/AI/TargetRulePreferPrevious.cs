using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTargetRulePreferPrevious.asset", menuName = "AI Rules/Target Prefer Previous")]
public class TargetRulePreferPrevious : TargetRule
{
	public override IEnumerable<WeightedTop> CalculateRule (Top agent, Top previousTarget, IList<Top> others)
	{
        return others.Select(t => new WeightedTop(t, t == previousTarget ? 1 : 0));
	}
}
