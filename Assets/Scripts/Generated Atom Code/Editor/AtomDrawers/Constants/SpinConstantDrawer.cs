#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Spin`. Inherits from `AtomDrawer&lt;SpinConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpinConstant))]
    public class SpinConstantDrawer : VariableDrawer<SpinConstant> { }
}
#endif
