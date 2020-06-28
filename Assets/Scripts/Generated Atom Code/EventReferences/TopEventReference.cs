using System;

namespace UnityAtoms
{
    /// <summary>
    /// Event Reference of type `Top`. Inherits from `AtomEventReference&lt;Top, TopVariable, TopEvent, TopVariableInstancer, TopEventInstancer&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TopEventReference : AtomEventReference<
        Top,
        TopVariable,
        TopEvent,
        TopVariableInstancer,
        TopEventInstancer>, IGetEvent 
    { }
}
