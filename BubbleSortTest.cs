using Xunit; 
using System; 
using data_structures_and_algorithms; 

public class BubbleSortTest 
{
    [Fact]
    public void TestSort(){
        int[] numbers = {5, 1, 3, 2, 4}; 
        int[] sortedNumbers = BubbleSort.Sort(numbers); 
        Assert.True(BubbleSortTest.IsSorted(sortedNumbers)); 
    }

    private static Boolean IsSorted(int[] numbers) {
        // Returns true if numbers are sorted in ascending order.

        int n = numbers.Length; 
        for(int i = 1; i < n; i++) {
            if (numbers[i-1] > numbers[i]) {
                return false;
            }
        }
        return true; 
    }
}
