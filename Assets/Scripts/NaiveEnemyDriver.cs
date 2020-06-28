using UnityEngine;
using UnityAtoms.BaseAtoms;

public class NaiveEnemyDriver : MonoBehaviour
{
    public Vector3Variable PlayerPosition;
    public Top TopPhysics;

    void Update ()
    {
        TopPhysics.SetInput(PlayerPosition.Value - transform.position);
    }
}
