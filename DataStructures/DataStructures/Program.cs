using DataStructures.BIT;
using System;
using System.Collections.Generic;

namespace DataStructures {
    class Program {
        static void Main(string[] args) {

            List<int> list = new List<int> { 1, 7, 3, 0, 5, 8, 3, 2, 6, 2, 1, 1, 4, 5 };
            BinaryIndexedTree bit = new BinaryIndexedTree(list);

            Console.WriteLine("Array: ");
            Console.WriteLine($"{String.Join(" ,", list)}");
            Console.WriteLine();

            Console.WriteLine($"Prefix sum of first 13 elements: {bit.SumTo(12)}");
            Console.WriteLine($"Prefix sum of first 7 elements: {bit.SumTo(6)}");
            Console.WriteLine($"Range sum from pos 1 to pos 5: {bit.SumRange(1, 5)}");
            Console.WriteLine();

            bit.Update(4, 2);
            Console.WriteLine("Add 2 to element at pos 4");
            for (int i = 0; i < list.Count; i++) {
                list[i] = bit.SumRange(i, i);
            }
            Console.WriteLine();

            Console.WriteLine("Array: ");
            Console.WriteLine($"{String.Join(" ,", list)}");
            Console.WriteLine();

            Console.WriteLine($"Prefix sum of first 13 elements: {bit.SumTo(12)}");
            Console.WriteLine($"Prefix sum of first 7 elements: {bit.SumTo(6)}");
            Console.WriteLine($"Range sum from pos 1 to pos 5: {bit.SumRange(1, 5)}");

            Console.ReadKey();
        }
    }
}
