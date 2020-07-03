using System.Collections.Generic;
using UnityEngine;

public abstract class VelocityRule : ScriptableObject
{
    public abstract Vector3 CalculateRule (Top agent, Top target, IList<Top> others);
}
