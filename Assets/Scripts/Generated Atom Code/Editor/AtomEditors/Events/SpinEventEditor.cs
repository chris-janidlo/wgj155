#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Spin`. Inherits from `AtomEventEditor&lt;Spin, SpinEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpinEvent))]
    public sealed class SpinEventEditor : AtomEventEditor<Spin, SpinEvent> { }
}
#endif
