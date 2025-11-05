using TwoSum;

static class Program
{
    static void Main()
    {
        Solution programSolution = new Solution();
        int[] testNums = new int[] { 2, 5, 3, 7, 4 };
        int testTarget = 6;

        int[] solution1 = programSolution.TwoSum_1(testNums, testTarget);
        Console.WriteLine($"Solution 1: ({string.Join(", ", solution1)})");

        int[] solution2 = programSolution.TwoSum_2(testNums, testTarget);
        Console.WriteLine($"Solution 2: ({string.Join(", ", solution2)})");
        
    }
}