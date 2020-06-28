using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `TopPair`. Inherits from `AtomEvent&lt;TopPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/TopPair", fileName = "TopPairEvent")]
    public sealed class TopPairEvent : AtomEvent<TopPair> { }
}
