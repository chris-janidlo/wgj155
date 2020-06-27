using UnityEngine;

public class PlayerDriver : MonoBehaviour
{
    public TopPhysics TopPhysics;

    public string XInputAxis, ZInputAxis;

    void Update ()
    {
        Vector3 input = new Vector3
        (
            Input.GetAxis(XInputAxis),
            0,
            Input.GetAxis(ZInputAxis)
        );

        TopPhysics.SetInput(input);
    }
}
