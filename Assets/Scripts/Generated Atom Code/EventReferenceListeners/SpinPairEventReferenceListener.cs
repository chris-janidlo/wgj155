using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `SpinPair`. Inherits from `AtomEventReferenceListener&lt;SpinPair, SpinPairEvent, SpinPairEventReference, SpinPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/SpinPair Event Reference Listener")]
    public sealed class SpinPairEventReferenceListener : AtomEventReferenceListener<
        SpinPair,
        SpinPairEvent,
        SpinPairEventReference,
        SpinPairUnityEvent>
    { }
}
