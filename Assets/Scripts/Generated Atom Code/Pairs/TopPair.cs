using System;
using UnityEngine;
namespace UnityAtoms
{
    /// <summary>
    /// IPair of type `&lt;Top&gt;`. Inherits from `IPair&lt;Top&gt;`.
    /// </summary>
    [Serializable]
    public struct TopPair : IPair<Top>
    {
        public Top Item1 { get => _item1; set => _item1 = value; }
        public Top Item2 { get => _item2; set => _item2 = value; }

        [SerializeField]
        private Top _item1;
        [SerializeField]
        private Top _item2;

        public void Deconstruct(out Top item1, out Top item2) { item1 = Item1; item2 = Item2; }
    }
}