using UnityEngine;
using UnityAtoms.BaseAtoms;

public class PlayerVariableSyncer : MonoBehaviour
{
    public Vector3Variable PlayerPosition;
    public FloatVariable PlayerSpin;

    public Top PlayerTop;

    void Update ()
    {
        PlayerPosition.Value = transform.position;
        PlayerSpin.Value = PlayerTop.CurrentSpin;
    }
}
