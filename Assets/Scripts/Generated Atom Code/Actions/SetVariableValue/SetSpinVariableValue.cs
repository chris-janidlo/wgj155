using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Spin`. Inherits from `SetVariableValue&lt;Spin, SpinPair, SpinVariable, SpinConstant, SpinReference, SpinEvent, SpinPairEvent, SpinVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Spin", fileName = "SetSpinVariableValue")]
    public sealed class SetSpinVariableValue : SetVariableValue<
        Spin,
        SpinPair,
        SpinVariable,
        SpinConstant,
        SpinReference,
        SpinEvent,
        SpinPairEvent,
        SpinSpinFunction,
        SpinVariableInstancer>
    { }
}
