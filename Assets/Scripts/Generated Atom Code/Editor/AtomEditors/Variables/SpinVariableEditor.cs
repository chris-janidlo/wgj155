using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Spin`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(SpinVariable))]
    public sealed class SpinVariableEditor : AtomVariableEditor<Spin, SpinPair> { }
}
