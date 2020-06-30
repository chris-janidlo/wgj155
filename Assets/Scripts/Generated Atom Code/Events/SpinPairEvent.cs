using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `SpinPair`. Inherits from `AtomEvent&lt;SpinPair&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/SpinPair", fileName = "SpinPairEvent")]
    public sealed class SpinPairEvent : AtomEvent<SpinPair> { }
}
