using System; 

namespace data_structures_and_algorithms 
{
    public class LinearSearch {
        public static Boolean contains(int[] numbers, int searchItem) 
        { 
            foreach (int number in numbers){
                if (number == searchItem) return true; 
            }
            return false;
        }
    }
}