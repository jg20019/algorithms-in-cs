using System; 

namespace data_structures_and_algorithms 
{
    public class BubbleSort {
        public static int[] Sort(int[] numbers) {
            int n = numbers.Length; 
            int[] result = new int[n]; 
            Array.Copy(numbers, result, n); 
            
            for(int i = 0; i < n; i++) {
                Boolean swap = false;

                for (int j = 1; j < n; j++) {
                    if (result[j-1] > result[j]){
                        int temp = result[j]; 
                        result[j] = result[j - 1]; 
                        result[j-1] = temp; 
                        swap = true; 
                    }
                }

                if (!swap) {
                    return result; 
                }
            }
            return result;    
        }
    }
}