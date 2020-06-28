using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Top`. Inherits from `EquatableAtomReference&lt;Top, TopPair, TopConstant, TopVariable, TopEvent, TopPairEvent, TopTopFunction, TopVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class TopReference : EquatableAtomReference<
        Top,
        TopPair,
        TopConstant,
        TopVariable,
        TopEvent,
        TopPairEvent,
        TopTopFunction,
        TopVariableInstancer>, IEquatable<TopReference>
    {
        public TopReference() : base() { }
        public TopReference(Top value) : base(value) { }
        public bool Equals(TopReference other) { return base.Equals(other); }
    }
}
