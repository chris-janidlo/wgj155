#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Value List property drawer of type `Top`. Inherits from `AtomDrawer&lt;TopValueList&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TopValueList))]
    public class TopValueListDrawer : AtomDrawer<TopValueList> { }
}
#endif
