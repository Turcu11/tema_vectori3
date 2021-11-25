using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Te tog sa introduci dimensiunea vetorului: ");
            int dimensiuneVector = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[dimensiuneVector];
            int c = 0;

            Console.WriteLine("Introdu elementele vectorului: ");
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] == nums[j])
                    {
                        c++;
                    }
                }
            }
            Console.Write($"Numarul de perechi perfecte este = {c}");
        }
    }
}
