using System;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public abstract class TargetRule : ScriptableObject
{
    [Serializable]
    public class WeightedTop : WeightedTuple<Top>
    {
        public WeightedTop (Top value, float weight)
        {
            Value = value;
            Weight = weight;
        }
    }

    public abstract IEnumerable<WeightedTop> CalculateRule (Top agent, Top previousTarget, IList<Top> others);
}
