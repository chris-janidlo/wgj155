using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `TopPair`. Inherits from `AtomEventReference&lt;TopPair, TopVariable, TopPairEvent, TopVariableInstancer, TopPairEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TopPairEventReference : AtomEventReference<
        TopPair,
        TopVariable,
        TopPairEvent,
        TopVariableInstancer,
        TopPairEventInstancer>, IGetEvent 
    { }
}
