#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Top`. Inherits from `AtomDrawer&lt;TopEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(TopEvent))]
    public class TopEventDrawer : AtomDrawer<TopEvent> { }
}
#endif
