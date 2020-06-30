using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Variable of type `Spin`. Inherits from `EquatableAtomVariable&lt;Spin, SpinPair, SpinEvent, SpinPairEvent, SpinSpinFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-lush")]
    [CreateAssetMenu(menuName = "Unity Atoms/Variables/Spin", fileName = "SpinVariable")]
    public sealed class SpinVariable : EquatableAtomVariable<Spin, SpinPair, SpinEvent, SpinPairEvent, SpinSpinFunction> { }
}
