using System.Collections.Generic;
using UnityEngine;

public abstract class SpinRule : ScriptableObject
{
    public abstract Spin CalculateRule (Top agent, Top target, IList<Top> others);
}
