namespace Algorithms.Solutions.LeetCode.Arrays
{
    public static class BuildArray
    {
        public static int[] TryBuildArray(int[] nums)
        {
            int[] newArray = new int[nums.Length];
            for(int i = 0; i < nums.Length; i++)
            {
                int temp = nums[i];
                newArray[i] = nums[temp];
            }

            return newArray;
        }
    }
}
