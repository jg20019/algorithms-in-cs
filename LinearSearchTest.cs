using Xunit;
using data_structures_and_algorithms; 

public class LinearSearchTest 
{
    [Fact]
    public void TestLinearSearch()
    {
        int[] numbers = {1, 2, 3, 4, 5};

        Assert.True(LinearSearch.contains(numbers, 3)); 
        Assert.True(LinearSearch.contains(numbers, 1)); 
        Assert.True(LinearSearch.contains(numbers, 5)); 

        Assert.False(LinearSearch.contains(numbers, 6));  
    }
}