using System;
using TreeLibrary;

namespace ServiceLibrary.BinaryTree
{
    public abstract class BaseBinaryTree<T> where T :IComparable
    {
        public BinaryTree<T> BinaryTree = new BinaryTree<T>();
        public void Search(T count) => BinaryTree.Search(count);
        public void Remove(T count) => BinaryTree.Remove(count);
        public void PrintValues() => BinaryTree.PrintValues();
        protected abstract BinaryTree<T> MakingTree();
        protected abstract BinaryTree<T> GeneratedTree();
        protected abstract BinaryTree<T> CreatedTree();
    }
}
