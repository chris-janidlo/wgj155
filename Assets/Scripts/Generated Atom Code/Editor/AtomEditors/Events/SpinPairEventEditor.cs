#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityEngine.UIElements;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpinPair`. Inherits from `AtomEventEditor&lt;SpinPair, SpinPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomEditor(typeof(SpinPairEvent))]
    public sealed class SpinPairEventEditor : AtomEventEditor<SpinPair, SpinPairEvent> { }
}
#endif
