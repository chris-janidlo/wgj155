using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Set variable value Action of type `Top`. Inherits from `SetVariableValue&lt;Top, TopPair, TopVariable, TopConstant, TopReference, TopEvent, TopPairEvent, TopVariableInstancer&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-purple")]
    [CreateAssetMenu(menuName = "Unity Atoms/Actions/Set Variable Value/Top", fileName = "SetTopVariableValue")]
    public sealed class SetTopVariableValue : SetVariableValue<
        Top,
        TopPair,
        TopVariable,
        TopConstant,
        TopReference,
        TopEvent,
        TopPairEvent,
        TopTopFunction,
        TopVariableInstancer>
    { }
}
