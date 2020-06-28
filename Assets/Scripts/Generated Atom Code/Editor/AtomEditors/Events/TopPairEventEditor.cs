#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `TopPair`. Inherits from `AtomEventEditor&lt;TopPair, TopPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(TopPairEvent))]
    public sealed class TopPairEventEditor : AtomEventEditor<TopPair, TopPairEvent> { }
}
#endif
