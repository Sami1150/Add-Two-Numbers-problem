public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int firstNum; int secondNum = 0;
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            firstNum = nums[i];
            for (int j = 0; j < nums.Length; j++)
            {
                secondNum = nums[j];
                if (i != j)
                {
                    sum = firstNum + secondNum;
                    if (sum == target)
                    {
                        int[] numbers = { i, j };
                        return numbers;
                    }
                }

            }
        }
        return Array.Empty<int>();
    }
}