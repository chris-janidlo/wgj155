using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Top`. Inherits from `AtomEvent&lt;Top&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Top", fileName = "TopEvent")]
    public sealed class TopEvent : AtomEvent<Top> { }
}
