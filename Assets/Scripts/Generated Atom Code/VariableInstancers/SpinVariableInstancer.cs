using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Spin`. Inherits from `AtomVariableInstancer&lt;SpinVariable, SpinPair, Spin, SpinEvent, SpinPairEvent, SpinSpinFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Spin Variable Instancer")]
    public class SpinVariableInstancer : AtomVariableInstancer<
        SpinVariable,
        SpinPair,
        Spin,
        SpinEvent,
        SpinPairEvent,
        SpinSpinFunction>
    { }
}
