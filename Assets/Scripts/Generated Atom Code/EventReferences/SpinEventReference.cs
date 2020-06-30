using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Spin`. Inherits from `AtomEventReference&lt;Spin, SpinVariable, SpinEvent, SpinVariableInstancer, SpinEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpinEventReference : AtomEventReference<
        Spin,
        SpinVariable,
        SpinEvent,
        SpinVariableInstancer,
        SpinEventInstancer>, IGetEvent 
    { }
}
