namespace Loops;

public static class LoopExamples
{
    public static int HighestForLoop(List<int> nums)
    {

        int result = nums[0];
        for (int i = 0; i < nums.Count; i++)
        {
            result = (nums[i] > result) ? nums[i] : result;
        }

        return result;
    }

    public static int HighestForEachLoop(List<int> nums)
    {
        int result = nums[0];
        //foreach syntax: foreach(type <name> in <collection>)
        foreach (int n in nums)
        {
            result = (n > result) ? n : result;
        }
        return result;
    }
    public static int HighestWhileLoop(List<int> nums)
    {
        int result = nums[0];
        int index = 1;

        while (index < nums.Count)
        {
            result = (nums[index] > result) ? nums[index] : result;
            index++;
        }

        return result;
    }
    public static int HighestDoWhileLoop(List<int> nums)
    {
        int result = nums[0];
        int index = 1;

        do
        {
            result = (nums[index] > result) ? nums[index] : result;
            index++;
        } while (index < nums.Count);

        return result;
    }
}