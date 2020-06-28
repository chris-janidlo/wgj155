using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `Top`. Inherits from `AtomEventReferenceListener&lt;Top, TopEvent, TopEventReference, TopUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/Top Event Reference Listener")]
    public sealed class TopEventReferenceListener : AtomEventReferenceListener<
        Top,
        TopEvent,
        TopEventReference,
        TopUnityEvent>
    { }
}
