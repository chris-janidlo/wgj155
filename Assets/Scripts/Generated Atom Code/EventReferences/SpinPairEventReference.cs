using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `SpinPair`. Inherits from `AtomEventReference&lt;SpinPair, SpinVariable, SpinPairEvent, SpinVariableInstancer, SpinPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpinPairEventReference : AtomEventReference<
        SpinPair,
        SpinVariable,
        SpinPairEvent,
        SpinVariableInstancer,
        SpinPairEventInstancer>, IGetEvent 
    { }
}
