using DSA.Csharp.Patterns.TwoPointerPattern;

namespace DSA.Csharp.Patterns.Test.TwoPointerPattern;

public class TripletSumToZeroTests
{
    [Fact]
    public void TestCase1()
    {
        // Arrange
        var tripletSumToZero = new TripletSumToZero();
        int[] arr = new int[] { -3, 0, 1, 2, -1, 1, -2 };

        // Act
        var result = tripletSumToZero.SearchTriplets(arr);

        // Assert
        Assert.Equal(4, result.Count);
        Assert.Collection(result,
            item => Assert.Equal(new List<int> { -3, 1, 2 }, item),
            item => Assert.Equal(new List<int> { -2, 0, 2 }, item),
            item => Assert.Equal(new List<int> { -2, 1, 1 }, item),
            item => Assert.Equal(new List<int> { -1, 0, 1 }, item)
        );
    }

    [Fact]
    public void TestCase2()
    {
        // Arrange
        var tripletSumToZero = new TripletSumToZero();
        int[] arr = new int[] { -5, 2, -1, -2, 3 };

        // Act
        var result = tripletSumToZero.SearchTriplets(arr);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Collection(result,
            item => Assert.Equal(new List<int> { -5, 2, 3 }, item),
            item => Assert.Equal(new List<int> { -2, -1, 3 }, item)
        );
    }

    [Fact]
    public void TestCase3()
    {
        // Arrange
        var tripletSumToZero = new TripletSumToZero();
        int[] arr = new int[] { 0, 0, 0 };

        // Act
        var result = tripletSumToZero.SearchTriplets(arr);

        // Assert
        Assert.Single(result);
        Assert.Collection(result,
            item => Assert.Equal(new List<int> { 0, 0, 0 }, item)
        );
    }
}
