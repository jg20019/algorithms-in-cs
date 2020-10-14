using Xunit; 
using data_structures_and_algorithms; 

public class BinarySearchTest
{
    [Fact]
    public void TestSearch()
    {
        int[] numbers = {1, 2, 3, 4, 5}; 

        // checking a number that is in the array
        Assert.True(BinarySearch.Search(numbers, 4)); 

        // checking boundaries
        Assert.True(BinarySearch.Search(numbers, 1)); 
        Assert.True(BinarySearch.Search(numbers, 5));   

        // checking numbers that are not in the array
        Assert.False(BinarySearch.Search(numbers, 6)); 
        Assert.False(BinarySearch.Search(numbers, 0)); 

    }

    [Fact]
    public void TestIterativeSearch(){
        int[] numbers = {1, 2, 3, 4, 5}; 

         // checking a number that is in the array
        Assert.True(BinarySearch.IterativeSearch(numbers, 4)); 

        // checking boundaries
        Assert.True(BinarySearch.IterativeSearch(numbers, 1)); 
        Assert.True(BinarySearch.IterativeSearch(numbers, 5));   

        // checking numbers that are not in the array
        Assert.False(BinarySearch.IterativeSearch(numbers, 6)); 
        Assert.False(BinarySearch.IterativeSearch(numbers, 0)); 
    }
}