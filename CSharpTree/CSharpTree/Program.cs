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
            int operation;
            do
            {
                Console.Write("Enter the number of operation:\r\n" +
                   "1. Integer Binary Tree\r\n" +
                   "0. Exit\r\n"+
                   "\r\n-> ");
                while (!int.TryParse(Console.ReadLine(), out operation))
                    Console.Write($"{operation} is not a integer\r\nenter the number -> ");
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
    }
}
