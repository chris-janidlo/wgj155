#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `Top`. Inherits from `AtomEventEditor&lt;Top, TopEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TopEvent))]
    public sealed class TopEventEditor : AtomEventEditor<Top, TopEvent> { }
}
#endif
