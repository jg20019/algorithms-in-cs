using System; 

namespace data_structures_and_algorithms {
    public class BinarySearch {

        public static bool IterativeSearch(int[] numbers, int searchItem) {
            int low = 0; 
            int high = numbers.Length - 1; 
            
            while (low <= high) {
                int mid = (low + high) / 2; 
                if (numbers[mid] < searchItem) {
                    low = mid + 1; 
                } else if (numbers[mid] > searchItem) {
                    high = mid - 1; 
                } else {
                    return true;
                }
            }
            return false;
        }
        public static bool Search(int [] numbers, int searchItem) {
            return Search(numbers, searchItem, 0, numbers.Length - 1); 
        }

        private static bool Search(int[] numbers, int searchItem, int start, int end){
            if (start > end) return false; 

            int mid = (start + end) / 2; 
            if (searchItem < numbers[mid]) {
                return Search(numbers, searchItem, start, mid - 1); 
            } else if (searchItem > numbers[mid]) {
                return Search(numbers, searchItem, mid + 1, end); 
            } else {
                return true; 
            }
        }


    }
}