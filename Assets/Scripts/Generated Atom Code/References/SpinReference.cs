using System;
using UnityAtoms.BaseAtoms;

namespace UnityAtoms
{
    /// <summary>
    /// Reference of type `Spin`. Inherits from `EquatableAtomReference&lt;Spin, SpinPair, SpinConstant, SpinVariable, SpinEvent, SpinPairEvent, SpinSpinFunction, SpinVariableInstancer, AtomCollection, AtomList&gt;`.
    /// </summary>
    [Serializable]
    public sealed class SpinReference : EquatableAtomReference<
        Spin,
        SpinPair,
        SpinConstant,
        SpinVariable,
        SpinEvent,
        SpinPairEvent,
        SpinSpinFunction,
        SpinVariableInstancer>, IEquatable<SpinReference>
    {
        public SpinReference() : base() { }
        public SpinReference(Spin value) : base(value) { }
        public bool Equals(SpinReference other) { return base.Equals(other); }
    }
}
