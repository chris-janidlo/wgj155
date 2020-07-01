using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms;
using crass;

// TODO: title for this in the UI
// FIXME: shouldn't have to specify initial value for VisualSpin; atoms should just auto raise their initial values
public class SpinGauge : MonoBehaviour
{
    public TransitionableFloat VisualSpin;
    public Image GaugeImage;

    void Awake ()
    {
        VisualSpin.AttachMonoBehaviour(this);
    }

    void Update ()
    {
        GaugeImage.fillAmount = (VisualSpin.Value - Spin.MIN) / (Spin.MAX - Spin.MIN);
    }

    public void OnSpinChange (Spin spin)
    {
        VisualSpin.StartTransitionTo(spin);
    }
}
