using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable Inspector of type `Top`. Inherits from `AtomVariableEditor`
    /// </summary>
    [CustomEditor(typeof(TopVariable))]
    public sealed class TopVariableEditor : AtomVariableEditor<Top, TopPair> { }
}
