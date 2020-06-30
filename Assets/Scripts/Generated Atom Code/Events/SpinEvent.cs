using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event of type `Spin`. Inherits from `AtomEvent&lt;Spin&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-cherry")]
    [CreateAssetMenu(menuName = "Unity Atoms/Events/Spin", fileName = "SpinEvent")]
    public sealed class SpinEvent : AtomEvent<Spin> { }
}
