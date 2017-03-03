using System;
using System.Collections;

namespace M269Algorithms
{
	class MainClass
	{
		//palindrome checker
		public static Boolean IsPalindrome(string input)
		{

			if (input.Length == 0 || input.Length == 1)
			{
				return true;
			}
			if (input[0] != input[input.Length - 1])
			{
				return false;
			}

			return IsPalindrome(input.Substring(1, input.Length - 2));

		}

		//binary search iterative
		public static object BinarySearchIterative(int[] inputArray, int key, int min = 0, int max = 0)
		{
			max = inputArray.Length;
			while (min <= max)
			{
				int mid = (min + max) / 2;
				if (key == inputArray[mid])
				{
					return ++mid;

				}
				else if (key < inputArray[mid])
				{
					max = mid - 1;
				}
				else
				{
					min = mid + 1;
				}
			}
			return "Nil";
		}

		//sum of odd
		public static int SumOfOdd(int n)
		{
			if (n == 1) //first odd number
			{
				return 1;
			}
			else
			{
				return 2 * n - 1 + SumOfOdd(n - 1);
			}
		}


		//sum of even
		public static int SumOfEven(int n)
		{
			if (n == 1) //first even number
			{
				return 2;
			}
			else
			{
				return 2 * n + SumOfEven(n - 1);
			}
		}

		//recursive factorial
		public static int Factorial(int n)
		{
			if (n == 1)
			{
				return 1;
			}

			return n * Factorial(n - 1);
		}

		//insertion sort
		public static void InsertionSort(int[] array)
		{
			for (int i = 1; i < array.Length; i++)
			{
				int currentValue = array[i];
				int position = i;

				while (position > 0 && array[position - 1] > currentValue)
				{
					array[position] = array[position - 1];
					position = position - 1;

				}

				array[position] = currentValue;
			}
		}


		//number converter
		public static string ToStringConverter(int number, int theBase)
		{
			string convertString = "0123456789ABCDEF";
			string result = "";
			//base case
			if (number < theBase)
			{
				return result = result + convertString[number];
			}
			else
			{
				return ToStringConverter(number / theBase, theBase) + convertString[number % theBase];
			}
		}


		//recursive number converter using stack
		public static string ToStringStack(int number, int theBase)
		{
			Stack stack = new Stack();
			string convertString = "0123456789ABCDEF";

			while (number > 0)
			{
				int rem = number % theBase;
				stack.Push(rem);
				number = number / theBase;
			}

			string result = "";

			while (stack.Count != 0)
			{
				result = result + convertString[(int)stack.Pop()];
			}

			return result;
		}

		//recursive sum of int array
		public static int SumOf(int[] a, int index = 0)
		{

			if (a[index] == a[a.Length - 1])
			{
				return a[a.Length - 1];
			}
			else
			{

				return a[index] + SumOf(a, index + 1);
			}
		}


		//string reverser
		public static string StringReverser(string input, int length = 0)
		{

			length = input.Length;
			if (length == 0)
			{
				return input;
			}
			else
			{
				return input[length - 1] + StringReverser(input.Substring(0, length - 1));
			}
		}





		public static void Main(string[] args)
		{
			//O(N*N) time
			int[] a = new int[10];
			for (int i = 0; i < a.Length; i++)
			{
				for (int j = 0; j < a.Length; j++)
				{
					Console.Write("(i: " + i + " ");
					Console.Write("j: " + j+ ")");
					Console.WriteLine();

				}
			}

			Console.WriteLine(SumOfEven(4));
			Console.WriteLine(SumOfOdd(4));
			Console.WriteLine(StringReverser("dave"));
			Console.WriteLine(ToStringConverter(500, 16)); 
			Console.WriteLine(ToStringStack(500, 16));        
			Console.WriteLine(Factorial(5));

			int[] input = { 54, 26, 93, 17, 77, 31, 44, 55, 20 };
			BinarySearchIterative(input, 17);
		}
	}
}
