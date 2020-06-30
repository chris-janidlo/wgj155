using System;
using UnityEngine;

[Serializable]
public class Spin : IEquatable<Spin>
{
    public const float MIN = 0, MAX = 100;

    [SerializeField]
    [Range(MIN, MAX)]
    private float value;

    public bool IsAtMinValue => value == MIN;
    public bool IsAtMaxValue => value == MAX;

	public static implicit operator float (Spin s) => s.value;
    public static implicit operator Spin (float f) => new Spin { value = Mathf.Clamp(f, MIN, MAX) };

	public bool Equals (Spin other)
	{
        return value == other.value;
	}
}
