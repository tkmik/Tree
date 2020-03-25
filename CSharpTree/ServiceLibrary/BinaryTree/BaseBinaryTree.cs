using System;
using TreeLibrary;

namespace ServiceLibrary.BinaryTree
{
    public abstract class BaseBinaryTree<T> where T :IComparable
    {
        protected BinaryTree<T> BinaryTree = new BinaryTree<T>();
        protected void Search(T count) => BinaryTree.Search(count);
        protected void Remove(T count) => BinaryTree.Remove(count);
        protected void PrintValues() => BinaryTree.PrintValues();
        protected abstract BinaryTree<T> MakingTree();
        protected abstract BinaryTree<T> GeneratedTree();
        protected abstract BinaryTree<T> CreatedTree();

        public abstract void Menu();
    }
}
