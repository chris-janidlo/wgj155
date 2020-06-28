using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference Listener of type `TopPair`. Inherits from `AtomEventReferenceListener&lt;TopPair, TopPairEvent, TopPairEventReference, TopPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Listeners/TopPair Event Reference Listener")]
    public sealed class TopPairEventReferenceListener : AtomEventReferenceListener<
        TopPair,
        TopPairEvent,
        TopPairEventReference,
        TopPairUnityEvent>
    { }
}
