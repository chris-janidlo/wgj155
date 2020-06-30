using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Spin`. Inherits from `AtomEventReferenceListener&lt;Spin, SpinEvent, SpinEventReference, SpinUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Spin Event Reference Listener")]
    public sealed class SpinEventReferenceListener : AtomEventReferenceListener<
        Spin,
        SpinEvent,
        SpinEventReference,
        SpinUnityEvent>
    { }
}
