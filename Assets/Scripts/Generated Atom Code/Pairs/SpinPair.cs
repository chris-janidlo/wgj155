using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Spin&gt;`. Inherits from `IPair&lt;Spin&gt;`.
    /// </summary>
    [Serializable]
    public struct SpinPair : IPair<Spin>
    {
        public Spin Item1 { get => _item1; set => _item1 = value; }
        public Spin Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Spin _item1;
        [SerializeField]
        private Spin _item2;

        public void Deconstruct(out Spin item1, out Spin item2) { item1 = Item1; item2 = Item2; }
    }
}