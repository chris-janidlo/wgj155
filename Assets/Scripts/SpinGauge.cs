using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityAtoms;
using crass;

// TODO: title for this in the UI
public class SpinGauge : MonoBehaviour
{
    public TransitionableFloat TransitionForLargeDeltas;
    public Spin LargeDeltaMin;

    public SpinVariableInstancer CurrentSpin;
    public Image GaugeImage;

    Spin previousSpin = 0;

    void Awake ()
    {
        TransitionForLargeDeltas.AttachMonoBehaviour(this);
    }

    void Update ()
    {
        if (CurrentSpin.Value - previousSpin >= LargeDeltaMin)
        {
            TransitionForLargeDeltas.StartTransitionTo(CurrentSpin.Value);
        }

        float valueToShow = TransitionForLargeDeltas.Transitioning ? TransitionForLargeDeltas.Value : (float) CurrentSpin.Value;

        GaugeImage.fillAmount = (valueToShow - Spin.MIN) / (Spin.MAX - Spin.MIN);

        previousSpin = CurrentSpin.Value;
    }
}
