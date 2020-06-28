using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Top`. Inherits from `EquatableAtomVariable&lt;Top, TopPair, TopEvent, TopPairEvent, TopTopFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Top", fileName = "TopVariable")]
    public sealed class TopVariable : EquatableAtomVariable<Top, TopPair, TopEvent, TopPairEvent, TopTopFunction> { }
}
