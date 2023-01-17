/*
 * This class takes an array as input and indices of the two numbers such that they add up to target.
 * Each input would have exactly one solution, and same element is not used twice
 */
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int firstNum; int secondNum;
        int sum;

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
