

namespace Challenge3_3
{
    internal class Program
    {
        // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        // You may assume that each input would have exactly one solution, and you may not use the same element twice.
        static void Main(string[] args)
        {
            int[] nums = { 3, 1, 2, 6, 5, 8, 10, 13 };
            int target = 7;
            string solutionIndices;

            solutionIndices = SumTarget(nums, target);
            PrintArray(nums);
            Console.WriteLine($"Target: { target }");
            Console.WriteLine(solutionIndices);

        }

        // Checks if if two ints add up to target. Made sure to have j match i as to not check already checked sums. Breaks loop when/if found.
        static string SumTarget(int[] nums, int target)
        {
            string indices = "Fail";
            for (int i = 0; i < nums.Length-1; i++) 
            { 
                for (int j = i+1; j < nums.Length-1; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        indices = $"Index: {i} and Index: {j}";
                        break;
                    }
                }
            }

            return indices;
        }

        static void PrintArray(int[] nums)
        {
            Console.Write("|");
            foreach (int i in nums)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
