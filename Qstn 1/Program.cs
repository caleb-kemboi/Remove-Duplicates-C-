
using System.Linq;
using Xunit;

static int[] ToRemoveDuplicates(int[] arr)
{
    HashSet<int> set = new HashSet<int>(arr);
    int[] result = new int[set.Count];
    set.CopyTo(result);
    return result;

}

  void TestToRemoveDuplicates()
{

    int[] arr1 = new int[] {1, 2 , 3, 4, 5, 6, 1};
    int[] result = ToRemoveDuplicates(arr1);
    Assert.Equal(new int[] {1, 2, 3, 4, 5, 6}, result);
    int[] arr2 = new int[] { 1, 1, 1, 1, 1 };
    int[] result2 = ToRemoveDuplicates(arr2);
    Assert.Equal(new int[] {1}, result2);

    int[] arr3 = new int[] {};
    int[] result3 = ToRemoveDuplicates(arr3);
    Assert.Equal(new int[] { }, result3);  

}