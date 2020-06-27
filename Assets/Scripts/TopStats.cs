using System.Linq;
using UnityEngine;

[CreateAssetMenu(fileName = "NewTopStats.asset", menuName = "Top Stats")]
public class TopStats : ScriptableObject
{
    public float Acceleration, MaxSpeed, KnockbackTime;
}
