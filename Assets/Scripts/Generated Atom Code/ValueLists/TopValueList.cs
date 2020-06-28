using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Value List of type `Top`. Inherits from `AtomValueList&lt;Top, TopEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-piglet")]
    [CreateAssetMenu(menuName = "Unity Atoms/Value Lists/Top", fileName = "TopValueList")]
    public sealed class TopValueList : AtomValueList<Top, TopEvent> { }
}
