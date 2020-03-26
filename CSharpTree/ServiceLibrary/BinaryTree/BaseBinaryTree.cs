using System;
using TreeLibrary;

namespace ServiceLibrary.BinaryTree
{
    /// <summary>
    /// базовые свойства и методы для бинарного дерева
    /// </summary>
    /// <typeparam name="T">тип</typeparam>
    public abstract class BaseBinaryTree<T> where T :IComparable
    {        
        protected BinaryTree<T> BinaryTree { get; set; }
        protected void Search(T count) => BinaryTree.Search(count);
        protected void Remove(T count) => BinaryTree.Remove(count);
        protected void PrintValues() => BinaryTree.PrintValues();
        protected abstract BinaryTree<T> MakingTree();
        protected abstract BinaryTree<T> GeneratedTree();
        protected abstract BinaryTree<T> CreatedTree();

        public abstract void Menu();
    }
}
