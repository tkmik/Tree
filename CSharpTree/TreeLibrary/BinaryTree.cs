using System;
using System.Collections.Generic;

namespace TreeLibrary
{
    /// <summary>
    /// класс дерева
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <prop name="RootN">корень дерева</prop>
    public sealed class BinaryTree<T> where T : IComparable
    {
        private Node<T> RootN { get; set; }
        /// <summary>
        /// класс узла
        /// </summary>
        /// <typeparam name="N"></typeparam>
        private class Node<N>
        {
            public N Value { get; set; } = default;
            public Node<N> ParentN { get; set; }
            public Node<N> LeftN { get; set; }
            public Node<N> RightN { get; set; }
            public Node(N value = default, Node<N> node = default)
            {
                Value = value;
                ParentN = node;
            }
        }

        /// <summary>
        /// добавление узла
        /// </summary>
        /// <param name="n">передача значения для записи в дерево</param>
        public void Add(T value)
        {
            Node<T> node = new Node<T>(value, RootN);
            if (Add_(node, RootN))
                Console.WriteLine($"{value} -> \"element added\"");
            else
                Console.WriteLine($"{value} ->\"element not added\"");
        }
        /// <summary>
        /// добавление массива узлов
        /// </summary>
        /// <param name="array">массив узлов</param>
        public void AddRange(T[] array)
        {
            foreach (T item in array)
                Add(item);
        }
        /// <summary>
        /// добавление узлов в дерево
        /// </summary>
        /// <param name="node">добавление нового узла</param>
        /// <param name="parent">текущий родитель</param>
        private bool Add_(Node<T> node, Node<T> parent)
        {
            if (RootN == null)
            {
                RootN = node;
                return true;
            }
            else
            {
                node.ParentN = parent;
                switch (node.Value.CompareTo(parent.Value))
                {
                    case -1:
                        if (parent.LeftN == null)
                            parent.LeftN = node;
                        else
                            Add_(node, parent.LeftN);
                        return true;
                    case 0: return false;
                    case 1:
                        if (parent.RightN == null)
                            parent.RightN = node;
                        else
                            Add_(node, parent.RightN);
                        return true; ;
                    default: return false;
                }

            }
        }
        /// <summary>
        /// поиск элемента
        /// </summary>
        /// <param name="Value">номер для поиска</param>
        public void Search(T value)
        {
            if (Search_(RootN, value) != null)
                Console.WriteLine($"{value} -> \"node found\"");
            else
                Console.WriteLine($"{value} -> \"node not found\"");
        }
        /// <summary>
        /// выполняется поиск по дереву
        /// </summary>
        /// <param name="node">текущий узел для поиска</param>
        /// <param name="value">искомое число</param>
        /// <returns></returns>
        private Node<T> Search_(Node<T> node, T value)
        {
            if (node == null)
                return null;
            else
                switch (node.Value.CompareTo(value))
                {
                    case -1: return Search_(node.RightN, value);
                    case 0: return node;
                    case 1: return Search_(node.LeftN, value);
                    default: return null;
                }
        }
        /// <summary>
        /// удаление 
        /// </summary>
        /// <param name="Value">удаляемый элемент</param>
        public void Remove(T value)
        {
            if (Remove_(value))
                Console.WriteLine($"{value} -> \"node deleted\"");
            else
                Console.WriteLine($"{value} -> \"node not deleted\"");
        }
        /// <summary>
        /// удаление элемента
        /// 1. корневой узел
        /// 2. когда у узла нет левого и правого узла
        /// 3. когда у узла нет правого узла
        /// 4. когда у узла нет левого узла
        /// 5. когда оба узла присутствуют
        /// </summary>
        /// <param name="value">удаляемый элемент</param>
        /// <returns></returns>
        private bool Remove_(T value)
        {
            Node<T> node = Search_(RootN, value);
            if (node != null)
            {
                if (node == RootN)
                {
                    if (RootN.RightN != null && RootN.LeftN == null)
                    {
                        RootN.ParentN = null;
                        RootN.RightN.ParentN = null;
                        RootN = RootN.RightN;
                    }
                    else if (RootN.RightN == null && RootN.LeftN != null)
                    {
                        RootN.ParentN = null;
                        RootN.LeftN.ParentN = null;
                        RootN = RootN.LeftN;
                    }
                    else if (RootN.RightN != null && RootN.LeftN != null)
                    {
                        Node<T> left = RootN.LeftN;
                        RootN.ParentN = null;
                        RootN.RightN.ParentN = null;
                        RootN = RootN.RightN;
                        Add_(left, RootN);
                    }
                    else if (RootN.RightN == null && RootN.LeftN == null)
                    {
                        RootN = null;
                    }
                    return true;
                }
                else
                {
                    if (node.LeftN == null && node.RightN == null)
                    {
                        if (node == node.ParentN.LeftN)
                            node.ParentN.LeftN = null;
                        else
                            node.ParentN.RightN = null;
                        return true;
                    }
                    else if (node.LeftN != null && node.RightN == null)
                    {
                        node.LeftN.ParentN = node.ParentN;
                        if (node == node.ParentN.LeftN)
                            node.ParentN.LeftN = node.LeftN;
                        else if (node == node.ParentN.RightN)
                            node.ParentN.RightN = node.LeftN;
                        return true;
                    }
                    else if (node.LeftN == null && node.RightN != null)
                    {
                        node.RightN.ParentN = node.ParentN;
                        if (node == node.ParentN.LeftN)
                            node.ParentN.LeftN = node.RightN;
                        else if (node == node.ParentN.RightN)
                            node.ParentN.RightN = node.RightN;
                        return true;
                    }
                    else if (node.LeftN != null && node.RightN != null)
                    {
                        Node<T> left = node.LeftN;
                        Node<T> right = node.RightN;
                        node.RightN.ParentN = node.ParentN;
                        if (node == node.ParentN.LeftN)
                            node.ParentN.LeftN = node.RightN;
                        else if (node == node.ParentN.RightN)
                            node.ParentN.RightN = node.RightN;
                        Add_(left, right);
                        return true;
                    }
                    return false;
                }
            }
            return false;
        }
        public void PrintValues()
        {
            if (RootN != null)
            {
                Queue<Node<T>> queue = new Queue<Node<T>>();
                queue.Enqueue(RootN);
                while (queue.Count != 0)
                {
                    if (queue.Peek().LeftN != null)
                        queue.Enqueue(queue.Peek().LeftN);
                    if (queue.Peek().RightN != null)
                        queue.Enqueue(queue.Peek().RightN);
                    Console.WriteLine($"\t{queue.Dequeue().Value}");
                }
            }
            else
                Console.WriteLine("tree is empty");
        }
    }
}
