using System;
using TreeLibrary;

namespace ServiceLibrary.BinaryTree
{
    public sealed class IntegerBinaryTree
    {
        public BinaryTree<int> BinaryTree = new BinaryTree<int>();
        /// <summary>
        /// создание дерева через ввод в консоли
        /// </summary>
        /// <returns>tree</returns>
        public void MakingTreeOfInt() => BinaryTree = MakingTreeOfInt_();
        private BinaryTree<int> MakingTreeOfInt_()
        {
            Console.Write("enter the number of values -> ");
            int count;
            IntParse(out count);
            int[] array = new int[count];
            Console.WriteLine($"enter {count} numbers");
            for (int i = 0; i < array.Length; i++)
                IntParse(out array[i]);
            BinaryTree.AddRange(array);
            return BinaryTree;
        }
        /// <summary>
        /// генерация дерева с рандомными значениями
        /// </summary>
        /// <returns>tree</returns>
        public void GeneratedTreeOfInt() => BinaryTree = GeneratedTreeOfInt_();
        private BinaryTree<int> GeneratedTreeOfInt_()
        {
            Console.WriteLine("enter the number of values -> ");
            int count;
            IntParse(out count);
            int[] array = new int[count];
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(int.MinValue, int.MaxValue);
            BinaryTree.AddRange(array);
            return BinaryTree;
        }
        /// <summary>
        /// созданое дерево в коде
        /// </summary>
        /// <returns>tree</returns>
        public void CreatedTreeOfInt() => BinaryTree = CreatedTreeOfInt_();
        private BinaryTree<int> CreatedTreeOfInt_()
        {
            int[] array = new int[] {
                10, 8, 1, 5, 4,
                -4, 0, 13, -7, 9,
                24, -10, 15, 2, 3,
                -3, 7, -14, 11, 6
            };
            BinaryTree.AddRange(array);
            return BinaryTree;
        }
        /// <summary>
        /// проверка на ввод числа
        /// </summary>
        /// <param name="item">возврщаемый параметр введеного значения</param>
        public void IntParse(out int item)
        {
            while (!int.TryParse(Console.ReadLine(), out item))
                Console.Write($"{item} is not a integer\r\nenter the number -> ");
        }

        public void Search(int count) => BinaryTree.Search(count);

        public void Remove(int count) => BinaryTree.Remove(count);

        public void PrintValues() => BinaryTree.PrintValues();
        
    }
}
