using UnityEngine;

public class WeightedTuple<T>
{
    public T Value;
    [Range(0, 1)]
    public float Weight = 1;
}
