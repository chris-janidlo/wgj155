using UnityEngine;

public class PlayerDriver : MonoBehaviour
{
    public Top TopPhysics;

    public string XInputAxis, ZInputAxis, SpinButton;

    void Update ()
    {
        Vector3 directionalInput = new Vector3
        (
            Input.GetAxis(XInputAxis),
            0,
            Input.GetAxis(ZInputAxis)
        );

        TopPhysics.SetDirectionalInput(directionalInput);
        TopPhysics.SetSpinInput(Input.GetButton(SpinButton));
    }
}
