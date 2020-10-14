using System; 

namespace data_structures_and_algorithms {
    public class BinarySearch {
        public static bool search(int [] numbers, int searchItem) {
            return search(numbers, searchItem, 0, numbers.Length - 1); 
        }

        private static bool search(int[] numbers, int searchItem, int start, int end){
            if (start > end) return false; 

            int mid = (start + end) / 2; 
            if (searchItem < numbers[mid]) {
                return search(numbers, searchItem, start, mid - 1); 
            } else if (searchItem > numbers[mid]) {
                return search(numbers, searchItem, mid + 1, end); 
            } else {
                return true; 
            }
        }
    }
}