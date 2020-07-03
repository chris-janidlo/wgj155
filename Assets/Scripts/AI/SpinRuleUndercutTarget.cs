using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSpinRuleUndercutTarget.asset", menuName = "AI Rules/Spin Undercut Target")]
public class SpinRuleUndercutTarget : SpinRule
{
    public float UndercutAmount;

	public override Spin CalculateRule (Top agent, Top target, IList<Top> others)
	{
        return target.CurrentSpin.Value - UndercutAmount;
	}
}
