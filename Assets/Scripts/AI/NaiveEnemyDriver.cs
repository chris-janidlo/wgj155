using UnityEngine;
using UnityAtoms.BaseAtoms;

// always attacks player, aggressively but stupidly
public class NaiveEnemyDriver : MonoBehaviour
{
    public Vector3Variable PlayerPosition;
    public FloatVariable PlayerSpin;
    public Top Top;

    void Update ()
    {
        Top.SetDirectionalInput(PlayerPosition.Value - transform.position);
        Top.SetSpinInput(Top.CurrentSpin < PlayerSpin.Value);
    }
}
