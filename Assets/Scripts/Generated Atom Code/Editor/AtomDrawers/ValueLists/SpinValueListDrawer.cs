#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Spin`. Inherits from `AtomDrawer&lt;SpinValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpinValueList))]
    public class SpinValueListDrawer : AtomDrawer<SpinValueList> { }
}
#endif
