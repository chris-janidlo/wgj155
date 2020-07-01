using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityAtoms;

public class TopVisualSpin : MonoBehaviour
{
    public AnimationCurve RotationPerSecondBySpin;
    public SpinVariableInstancer CurrentSpin;

    void Update ()
    {
        float deltaDeg = RotationPerSecondBySpin.Evaluate(CurrentSpin.Value) * Time.deltaTime;
        transform.Rotate(Vector3.forward * deltaDeg, Space.Self);
    }
}
