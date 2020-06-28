using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `TopPair`. Inherits from `AtomEventInstancer&lt;TopPair, TopPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/TopPair Event Instancer")]
    public class TopPairEventInstancer : AtomEventInstancer<TopPair, TopPairEvent> { }
}
