using System;
using ServiceLibrary.BinaryTree;

namespace CSharpTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            int operation = 0;
            do
            {
                int count = 0;
                Console.Write("Enter the number of operation:\r\n" +
                   "1. Integer Binary Tree\r\n" +
                   "0. Exit\r\n"+
                   "\r\n-> ");
                IntParse(out operation);
                switch (operation)
                {
                    case 1:
                        IntegerBinaryTree tree = new IntegerBinaryTree();
                        tree.Menu();
                        break;
                    case 0:
                        operation = 0;
                        break;
                    default: operation = -1; break;
                }
            } while (operation != 0);
        }

        static void IntParse(out int item)
        {
            while (!int.TryParse(Console.ReadLine(), out item))
                Console.Write($"{item} is not a integer\r\nenter the number -> ");
        }
    }
}
