using System;

namespace data_structures_and_algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5}; 
            Console.WriteLine(BinarySearch.IterativeSearch(numbers, 5));   
        }
    }
}
