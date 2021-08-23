using System;

namespace CodeWarsKatasCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new[] { 2, 1, 1};

            int answer = Stray(numbers);

            Console.WriteLine(answer);



        }


        // Find the stray number
        // https://www.codewars.com/kata/57f609022f4d534f05000024/train/csharp
        //public static int Stray(int[] numbers)
        //{
        //    Array.Sort(numbers);
        //    if (numbers[0] != numbers[1])
        //    {
        //        return numbers[0];
        //    }
        //    else
        //    {
        //        return numbers[numbers.Length - 1];
        //    }
        //}


        //  Two Sum
        //  https://www.codewars.com/kata/52c31f8e6605bcc646000082/train/csharp
        //public static int[] TwoSum(int[] numbers, int target)
        //{
        //    int[] answer = new int[2];
        //    for (int i = 0; i < numbers.Length; i++)
        //    {
        //        for (int j = 1; j < numbers.Length; j++)
        //        {
        //            if (numbers[i] + numbers[j] == target)
        //            {
        //                answer[0] = i;
        //                answer[1] = j;
        //                return answer;

        //            }
        //        }
        //    }
        //    return answer;
        //}






        //  Sort Number
        //  https://www.codewars.com/kata/5174a4c0f2769dd8b1000003/train/csharp
        //public static int[] SortNumbers(int[] nums)
        //{
        //    if (nums != null && nums.Length != 0)
        //    {
        //        Array.Sort(nums);
        //    }
        //    else
        //    {
        //        nums = new int[0];
        //    }
        //    return nums;
        //}

        // Testing 1-2-3
        // https://www.codewars.com/kata/54bf85e3d5b56c7a05000cf9/train/csharp
        //public static List<string> Number(List<string> lines)
        //{
        //    for (int i = 0; i < lines.Count; i++)
        //    {
        //        lines[i] = $"{i + 1}: {lines[i]}";
        //    }
        //    return lines;
        //}

        //  The Coupon Code
        //  https://www.codewars.com/kata/539de388a540db7fec000642/train/csharp
        //public static bool CheckCoupon(string enteredCode, string correctCode, string currentDate, string expirationDate)
        //{
        //    if (enteredCode == correctCode && Convert.ToDateTime(currentDate) <= Convert.ToDateTime(expirationDate))
        //        return true;
        //    else
        //        return false;
        //}
    }
}
