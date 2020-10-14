using Xunit; 
using data_structures_and_algorithms; 

public class BinarySearchTest
{
    [Fact]
    public void TestSearch()
    {
        int[] numbers = {1, 2, 3, 4, 5}; 

        // checking a number that is in the array
        Assert.True(BinarySearch.search(numbers, 4)); 

        // checking boundaries
        Assert.True(BinarySearch.search(numbers, 1)); 
        Assert.True(BinarySearch.search(numbers, 5));   

        // checking numbers that are not in the array
        Assert.False(BinarySearch.search(numbers, 6)); 
        Assert.False(BinarySearch.search(numbers, 0)); 

    }

}