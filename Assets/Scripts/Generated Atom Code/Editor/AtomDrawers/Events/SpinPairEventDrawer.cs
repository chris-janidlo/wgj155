#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `SpinPair`. Inherits from `AtomDrawer&lt;SpinPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(SpinPairEvent))]
    public class SpinPairEventDrawer : AtomDrawer<SpinPairEvent> { }
}
#endif
