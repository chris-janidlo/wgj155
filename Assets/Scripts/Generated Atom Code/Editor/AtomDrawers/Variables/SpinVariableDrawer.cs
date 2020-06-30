#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Variable property drawer of type `Spin`. Inherits from `AtomDrawer&lt;SpinVariable&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpinVariable))]
    public class SpinVariableDrawer : VariableDrawer<SpinVariable> { }
}
#endif
