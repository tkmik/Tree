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
            IntegerBinaryTree tree = new IntegerBinaryTree();
            do
            {

                int count = 0;
                Console.Write("Enter the number of operation:\r\n" +
                   "1. Making tree of integer\r\n" +
                   "2. Generate tree of integer\r\n" +
                   "3. Created tree of integer\r\n" +
                   "4. Node search\r\n" +
                   "5. Node delete\r\n" +
                   "6. Show values\r\n" +
                   "0. Exit\r\n" +
                   "\r\n-> ");
                tree.IntParse(out operation);
                switch (operation)
                {
                    case 1:

                        tree.MakingTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 2:
                        tree.GeneratedTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 3:
                        tree.CreatedTreeOfInt();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.Write("Enter the item of search -> ");
                        tree.IntParse(out count);
                        tree.Search(count);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.Write("Enter the item of delete -> ");
                        tree.IntParse(out count);
                        tree.Remove(count);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Values -> ");
                        tree.PrintValues();
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
