#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Constant property drawer of type `Top`. Inherits from `AtomDrawer&lt;TopConstant&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TopConstant))]
    public class TopConstantDrawer : VariableDrawer<TopConstant> { }
}
#endif
