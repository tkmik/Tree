﻿using System;
using TreeLibrary;

namespace ServiceLibrary.BinaryTree
{
    public sealed class IntegerBinaryTree : BaseBinaryTree<int>
    {
        /// <summary>
        /// создание дерева через ввод в консоли
        /// </summary>
        /// <returns>tree</returns>
        private void MakingTreeOfInt() => BinaryTree = MakingTree();

        protected override BinaryTree<int> MakingTree()
        {
            BinaryTree = new BinaryTree<int>();
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
        private void GeneratedTreeOfInt() => BinaryTree = GeneratedTree();

        protected override BinaryTree<int> GeneratedTree()
        {
            BinaryTree = new BinaryTree<int>();
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
        private void CreatedTreeOfInt() => BinaryTree = CreatedTree();

        protected override BinaryTree<int> CreatedTree()
        {
            BinaryTree = new BinaryTree<int>();
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
        private void IntParse(out int item)
        {
            while (!int.TryParse(Console.ReadLine(), out item))
                Console.Write($"{item} is not a integer\r\nenter the number -> ");
        }

        public override void Menu()
        {
            int operation;
            do
            {
                Console.Write("Enter the number of operation:\r\n" +
                   "1. Making tree of integer\r\n" +
                   "2. Generate tree of integer\r\n" +
                   "3. Created tree of integer\r\n" +
                   "4. Node search\r\n" +
                   "5. Node delete\r\n" +
                   "6. Show values\r\n" +
                   "0. Back\r\n" +
                   "\r\n-> ");
                IntParse(out operation);
                int count;
                switch (operation)
                {
                    case 1:

                        MakingTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 2:
                        GeneratedTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 3:
                        CreatedTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter the item of search -> ");
                        IntParse(out count);
                        Search(count);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Enter the item of delete -> ");
                        IntParse(out count);
                        Remove(count);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Values -> ");
                        PrintValues();
                        Console.WriteLine();
                        break;
                    case 0:
                        operation = 0;
                        break;
                    default: operation = -1; break;
                }
            } while (operation != 0);
        }


    }
}
