using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Spin`. Inherits from `AtomValueList&lt;Spin, SpinEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Spin", fileName = "SpinValueList")]
    public sealed class SpinValueList : AtomValueList<Spin, SpinEvent> { }
}
