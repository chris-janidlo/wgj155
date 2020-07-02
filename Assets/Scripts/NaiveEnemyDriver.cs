using UnityEngine;
using UnityAtoms.BaseAtoms;

// always attacks player, aggressively but stupidly
public class NaiveEnemyDriver : MonoBehaviour
{
    public Vector3Variable PlayerPosition;
    public FloatVariable PlayerSpin;
    public Top TopPhysics;

    void Update ()
    {
        TopPhysics.SetDirectionalInput(PlayerPosition.Value - transform.position);
        TopPhysics.SetSpinInput(TopPhysics.CurrentSpin.Value < PlayerSpin.Value);
    }
}
