using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewVelocityRuleTowardTarget.asset", menuName = "AI Rules/Velocity Toward Target")]
public class VelocityRuleTowardTarget : VelocityRule
{
    public override Vector3 CalculateRule (Top agent, Top target, IList<Top> others)
    {
        return target.transform.position - agent.transform.position;
    }
}
