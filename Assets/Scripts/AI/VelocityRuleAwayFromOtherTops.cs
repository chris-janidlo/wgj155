using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewVelocityRuleAwayFromOtherTops.asset", menuName = "AI Rules/Velocity Away From Other Tops")]
public class VelocityRuleAwayFromOtherTops : VelocityRule
{
    public float DesiredDistanceFromOtherTops;

    public override Vector3 CalculateRule (Top agent, Top target, IList<Top> others)
    {
        Vector3 agentPosition = agent.transform.position;

        return others
            .Select(t => t.transform.position)
            .Where(p => Vector3.Distance(p, agentPosition) < DesiredDistanceFromOtherTops)
            .Select(p => (p - agentPosition).normalized * DesiredDistanceFromOtherTops)
            .Aggregate((v1, v2) => v1 + v2);
    }
}
