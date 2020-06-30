using UnityEngine;

namespace UnityAtoms
{
    /// <summary>
    /// Event Instancer of type `SpinPair`. Inherits from `AtomEventInstancer&lt;SpinPair, SpinPairEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-sign-blue")]
    [AddComponentMenu("Unity Atoms/Event Instancers/SpinPair Event Instancer")]
    public class SpinPairEventInstancer : AtomEventInstancer<SpinPair, SpinPairEvent> { }
}
