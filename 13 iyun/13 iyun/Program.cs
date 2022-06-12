using System;

namespace _13_iyun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Allahverdi", "Ali", "Gunel", "Cahangir", "Elekber" };
            //int count = 0;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i].Length > 5)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            int[] nums = { 1, 2, 4343, 3, 4 };
            int[] nums2 = { 1, 3, 5, 8, 9, 12, 2, 4 };
            Console.WriteLine(ArrInArr(nums, nums2));

            //int index = GetIndex(nums, 32);
            //Console.WriteLine(index);

           // int[] nums = { 1, 2, 3, 4, 5, 6 };
            int n = 10;
            AddElemet(ref nums, n);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            string[] names = { "Ali", "Alakbar", "Abbas", "Bahar" };
            Console.WriteLine(FirstIsA(names));
            int[] numbers = { 1, 2, 3, 4, 5 };
            AddELement(ref numbers, 7);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }


        static int[] GetEvenNums(int[] nums)
        {
            int[] evenNums = new int[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    Array.Resize(ref evenNums, evenNums.Length + 1);
                    evenNums[evenNums.Length - 1] = nums[i];
                }
            }
            return evenNums;

        }
        static int GetIndex(int[] nums, int n)
        {
            int minIndex = 0;
            int maxIndex = nums.Length - 1;
            int midIndex = -1;

            while (minIndex <= maxIndex)
            {
                midIndex = (minIndex + maxIndex) / 2;
                 if (nums[midIndex] == n)
                {
                    return midIndex;
                }
               else if (nums[midIndex] > n)
                {
                    maxIndex = midIndex-1;
                }
                else if (nums[midIndex] <n)
                {
                    minIndex = midIndex+1;
                }      
            }
            return -1;

            



        }

        static bool ArrInArr(int[] nums1, int[] nums2)
        {
            bool check = false;
            if (nums1.Length<=nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    for (int j = 0; j < nums2.Length; j++)
                    {
                        if (nums1[i] == nums2[j])
                        {
                           check  = true;
                            break;
                        }
                        else 
                            check = false;
                        
       
                    }
                    if (!check)
                    {
                        return false;
                    }
                    
                }
                return check;
            }
            else
            {
                return false;

            }
        }

        static void AddElemet(ref int[] nums, int n)
        {
            Array.Resize(ref nums, nums.Length + 1);
            nums[nums.Length - 1] = n;
        }

        static bool FirstIsA(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i][0]!='A')
                {
                    return false;

                }
            }
            return true;
        }

        static void AddELement(ref int[] nums, int n)
        {
            Array.Resize(ref nums, nums.Length + 1);
            nums[nums.Length-1]=n;

        }
    }
}
