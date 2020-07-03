using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class TopVisualSpin : MonoBehaviour
{
    public AnimationCurve RotationPerSecondBySpin;
    public Top Top;

    void Update ()
    {
        float deltaDeg = RotationPerSecondBySpin.Evaluate(Top.CurrentSpin) * Time.deltaTime;
        transform.Rotate(Vector3.forward * deltaDeg, Space.Self);
    }
}
