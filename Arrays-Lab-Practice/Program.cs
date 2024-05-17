using System.ComponentModel;

namespace Arrays_Lab_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fibonacci
            //int firstNum = 0;
            //int secondNum = 1;
            //Console.WriteLine(firstNum);
            //Console.WriteLine(secondNum);


            //while (true)
            //{
            //    int thirdNum = secondNum + firstNum;
            //    firstNum = secondNum;
            //    secondNum = thirdNum;

            //    Console.WriteLine(thirdNum);
            //    Console.ReadLine();
            //}

            #endregion

            #region Task2

            //string[] arr = { "Sabir", "Ibrahim", "Asiman" };

            //int i = 0;
            //while (i<arr.Length) 
            //{
            //    Console.WriteLine(arr[i]);
            //    i++;
            //}

            #endregion

            #region Max and min number in array

            //int[] numbers = { 5, 2, 3, 213, 321, 45432, 343, 53 };

            //int idx = 0;
            //int maxNum = numbers[0];
            //int minNum = numbers[0];
            //while (idx < numbers.Length)
            //{
            //    if (numbers[idx] > maxNum)
            //    {
            //        maxNum = numbers[idx];
            //    }
            //    if (numbers[idx] < minNum)
            //    {
            //        minNum = numbers[idx];
            //    }
            //    idx++;
            //}
            //Console.WriteLine($"MinNum:{minNum}");
            //Console.WriteLine($"MaxNum:{maxNum}");

            #endregion

            #region AverageNum

            //int[] numbers = { 1,4,2,6 };

            //int idx = 0;
            //decimal sum = 0;
            //int count = 0;
            //while (idx < numbers.Length)
            //{
            //    sum += numbers[idx];
            //    idx++;
            //    count++;
            //}
            //Console.WriteLine($"AverageNum:{sum/count}");

            #endregion

            #region userInput exists in array or not 
            //int[] nums = { 1,4,2,3 };

            //int userInput = Convert.ToInt32(Console.ReadLine());

            //int idx = 0;
            //bool result = false;
            //while (idx < nums.Length)
            //{
            //    if (nums[idx] == userInput) 
            //    {
            //        result = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Daxil etdiyiniz reqem arrayde yoxdur");
            //    }
            //    idx++;
            //}

            //Console.WriteLine(result);

            #endregion

            #region Array isSorted
            //int[] arr = { 1, 4, 200, 9, 18, 52 };

            //bool isSorted = true;
            //int idx = 0;

            //while (idx < arr.Length)
            //{
            //    if (arr[idx] > arr[idx+1])
            //    {
            //        isSorted = false;
            //        break;
            //    }
            //    idx++;
            //}
            //Console.WriteLine(isSorted);
            #endregion

            #region Swap 2 numbers index in array
            //Solution1------------

            //int firstNum = Convert.ToInt32(Console.ReadLine());
            //int secondNum = Convert.ToInt32(Console.ReadLine());

            //int[] numbers = { 0, 12, 35, 23, 56, 23, 9, 4, 6, 1 };

            //int idx = 0;
            //int firstNumIdx=0;
            //int secondNumIdx=0;

            //while (idx<numbers.Length)
            //{
            //    if (numbers[idx] == firstNum)
            //    {
            //        firstNumIdx = idx;
            //    }
            //    if (numbers[idx] == secondNum)
            //    {
            //        secondNumIdx = idx;
            //    }
            //    idx++;
            //}

            //numbers[firstNumIdx] = secondNum;
            //numbers[secondNumIdx] = firstNum;

            //idx = 0;
            //while (idx < numbers.Length)
            //{
            //    Console.WriteLine(numbers[idx]);
            //    idx++;
            //}

            //Solution 2--------------------------------------------------

            int firstNum = Convert.ToInt32(Console.ReadLine());
            int secondNum = Convert.ToInt32(Console.ReadLine());

            int[] numbers = { 0, 12, 35, 23, 56, 23, 9, 4, 6, 1 };

            int idx = 0;

            while (idx < numbers.Length)
            {
                if (numbers[idx] == firstNum)
                {
                    numbers[idx] = secondNum;
                }
                else if (numbers[idx] == secondNum)
                {
                    numbers[idx] = firstNum;
                }
                idx++;
            }


            idx = 0;
            while (idx < numbers.Length)
            {
                Console.WriteLine(numbers[idx]);
                idx++;
            }
            #endregion
        }
    }
}