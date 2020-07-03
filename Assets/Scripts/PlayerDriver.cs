using UnityEngine;

public class PlayerDriver : MonoBehaviour
{
    public Top Top;

    public string XInputAxis, ZInputAxis, SpinButton;

    void Update ()
    {
        Vector3 directionalInput = new Vector3
        (
            Input.GetAxis(XInputAxis),
            0,
            Input.GetAxis(ZInputAxis)
        );

        Top.SetDirectionalInput(directionalInput);
        Top.SetSpinInput(Input.GetButton(SpinButton));
    }
}
