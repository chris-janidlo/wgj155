using System.Linq;
using System.Collections.Generic;
using UnityAtoms;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTargetRuleLowestSpin.asset", menuName = "AI Rules/Target Lowest Spin")]
public class TargetRuleLowestSpin : TargetRule
{
	public override IEnumerable<WeightedTop> CalculateRule (Top agent, Top previousTarget, IList<Top> others)
	{
		// FIXME: use spin here instead of float
        float minSpin = others.Min(t => (float) t.CurrentSpin);
        return others.Select(t => new WeightedTop(t, t.CurrentSpin == minSpin ? 1 : 0));
	}
}
