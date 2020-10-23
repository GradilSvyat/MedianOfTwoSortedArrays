using System;

namespace MedianOfTwoSortedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrays = new []
            {
                new {num1 = new int[] {1,3}, num2 = new int[] {2} },
                new {num1 = new int[] {1,2}, num2 = new int[] {3,4} },
                new {num1 = new int[] {0,0}, num2 = new int[] {0,0} },
                new {num1 = new int[] {}, num2 = new int[] {1} },
                new {num1 = new int[] {2}, num2 = new int[] {} }
            };
            foreach(var a in arrays)
                {
                    Console.WriteLine(FindMedianSortedArrays(a.num1,a.num2));
                }
        }
     
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] result = new int[((nums1.Length + nums2.Length) / 2) + 1];
            int indexNums1 = 0;
            int indexNums2 = 0;
            for (int i = 0; i<result.Length;i++)
            {
                if (indexNums1 < nums1.Length && indexNums2 < nums2.Length)
                {
                    if (nums1[indexNums1] < nums2[indexNums2])
                    {
                        result[i] = nums1[indexNums1++];
                    }
                    else
                    {
                        result[i] = nums2[indexNums2++];
                    }
                }
                else if(indexNums1 < nums1.Length)
                {
                    result[i] = nums1[indexNums1++];
                }
                else
                {
                    result[i] = nums2[indexNums2++];
                }
            }
            if ((nums1.Length + nums2.Length) % 2 == 0)
                return ((double)result[result.Length-1] + result[result.Length - 2])/2;
            else
                return result[result.Length - 1];
        }
    }
}
