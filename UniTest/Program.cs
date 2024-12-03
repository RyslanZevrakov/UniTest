using System;
using System.Collections.Generic;

namespace UniTest
{
    public class Solution
    {
        public static void Main(string[] args)
        {
            int[] nums = { 1, 2,3}; 
            var result = new List<List<int>>();

            GeneratePermutations(nums, 0, result);

            
            Console.WriteLine("All permutations:");
            foreach (var permutation in result)
            {
                Console.WriteLine(string.Join(", ", permutation));
            }
        }

       
        public static void GeneratePermutations(int[] nums, int start, List<List<int>> result)
        {
            if (start == nums.Length)
            {
                
                result.Add(new List<int>(nums));
                return;
            }

            for (int i = start; i < nums.Length; i++)
            {
                Swap(nums, start, i); 
                GeneratePermutations(nums, start + 1, result); 
                Swap(nums, start, i); 
            }
        }

        
        public static void Swap(int[] nums, int i, int j)
        {
            int temp = nums[i];
            nums[i] = nums[j];
            nums[j] = temp;
        }
    }
}
