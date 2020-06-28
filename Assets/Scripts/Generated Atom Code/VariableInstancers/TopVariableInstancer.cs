using UnityEngine;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Variable Instancer of type `Top`. Inherits from `AtomVariableInstancer&lt;TopVariable, TopPair, Top, TopEvent, TopPairEvent, TopTopFunction&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-hotpink")]
    [AddComponentMenu("Unity Atoms/Variable Instancers/Top Variable Instancer")]
    public class TopVariableInstancer : AtomVariableInstancer<
        TopVariable,
        TopPair,
        Top,
        TopEvent,
        TopPairEvent,
        TopTopFunction>
    { }
}
