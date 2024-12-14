

namespace DSA.Csharp.Patterns.TwoPointerPattern;

public class TripletSumToZero
{
    /// <summary>
    /// Given an array of unsorted numbers, find all unique triplets in it that add up to zero.
    /// <para>
    /// Time complexity: O(N^2) + O(NlogN) => O(N^2)
    /// </para>
    /// <para>
    /// TIme Complexity Explaination: Sorting the array will take O(NlogN). The for loop in SearchTriplets will take O(N) while loop for SearchPair will take O(N) combined O(N^2).
    /// </para>
    /// Space complexity: O(N)
    /// </summary>
    /// <param name="arr">array of unsorted numbers</param>
    /// <returns>list of triplets</returns>
    public List<List<int>> SearchTriplets(int[] arr)
    {
        Array.Sort(arr);
        List<List<int>> triplets = new List<List<int>>();
        for (int i = 0; i < arr.Length - 2; i++)
        {
            if (i > 0 && arr[i] == arr[i - 1]) // skip same element to avoid duplicate triplets
                continue;
            SearchPair(arr, -arr[i], i + 1, triplets);
        }

        return triplets;
    }

    private void SearchPair(int[] arr, int targetSum, int left, List<List<int>> triplets)
    {
        int right = arr.Length - 1;
        while (left < right)
        {
            int currentSum = arr[left] + arr[right];
            if (currentSum == targetSum)
            { // found the triplet
                triplets.Add(new List<int> { -targetSum, arr[left], arr[right] });
                left++;
                right--;
                while (left < right && arr[left] == arr[left - 1])
                    left++; // skip same element to avoid duplicate triplets
                while (left < right && arr[right] == arr[right + 1])
                    right--; // skip same element to avoid duplicate triplets
            }
            else if (targetSum > currentSum)
                left++; // we need a pair with a bigger sum
            else
                right--; // we need a pair with a smaller sum
        }
    }
}
