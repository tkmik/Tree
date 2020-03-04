using System;

namespace CSharpTree
{
    /// <summary>
    /// Класс для создания дерева integer
    /// </summary>
    sealed class IntegerTree
    {
        public Tree<int> Tree = new Tree<int>();
        /// <summary>
        /// создание дерева через ввод в консоли
        /// </summary>
        /// <returns>tree</returns>
        internal void MakingTreeOfInt() => Tree = MakingTreeOfInt_(); 
        private Tree<int> MakingTreeOfInt_()
        {
            Tree = new Tree<int>();
            Console.Write("enter the number of values -> ");
            int count;
            IntParse(out count);
            int[] array = new int[count];
            Console.WriteLine($"enter {count} numbers");
            for (int i = 0; i < array.Length; i++)
                IntParse(out array[i]);
            Tree.AddRange(array);
            return Tree;
        }
        /// <summary>
        /// генерация дерева с рандомными значениями
        /// </summary>
        /// <returns>tree</returns>
        public void GeneratedTreeOfInt() => Tree = GeneratedTreeOfInt_();
        private Tree<int> GeneratedTreeOfInt_()
        {
            Console.WriteLine("enter the number of values -> ");
            int count;
            IntParse(out count);
            Tree = new Tree<int>();
            int[] array = new int[count];
            Random rand = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(int.MinValue, int.MaxValue);
            Tree.AddRange(array);
            return Tree;
        }
        /// <summary>
        /// созданое дерево в коде
        /// </summary>
        /// <returns>tree</returns>
        public void CreatedTreeOfInt() => Tree = CreatedTreeOfInt_();
        private Tree<int> CreatedTreeOfInt_()
        {
            Tree = new Tree<int>();
            int[] array = new int[] {
                10, 8, 1, 5, 4,
                -4, 0, 13, -7, 9,
                24, -10, 15, 2, 3,
                -3, 7, -14, 11, 6
            };
            Tree.AddRange(array);
            return Tree;
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
    }
}
