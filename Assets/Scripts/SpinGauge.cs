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

    public Top Top;
    public Image GaugeImage;

    Spin previousSpin = 0;

    void Awake ()
    {
        TransitionForLargeDeltas.AttachMonoBehaviour(this);
    }

    void Update ()
    {
        if (Top.CurrentSpin - previousSpin >= LargeDeltaMin)
        {
            TransitionForLargeDeltas.StartTransitionTo(Top.CurrentSpin);
        }

        float valueToShow = TransitionForLargeDeltas.Transitioning ? TransitionForLargeDeltas.Value : (float) Top.CurrentSpin;

        GaugeImage.fillAmount = (valueToShow - Spin.MIN) / (Spin.MAX - Spin.MIN);

        previousSpin = Top.CurrentSpin;
    }
}
