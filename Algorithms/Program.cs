using System;

namespace Algorithms
{
	class Program
	{
		static void Main(string[] args)
		{
			FizzBuzz();
			Console.WriteLine();

			Fibonacci(100);
			Console.WriteLine();

			ChangeValue(19, 23);
			Console.ReadLine();
		}
		public static void FizzBuzz()
		{
			for (int i = 1; i <= 100; i++)
			{
				if (i % 3 == 0 && i % 5 == 0)
				{
					Console.WriteLine("FizzBuzz");
				}
				else if (i % 3 == 0)
				{
					Console.WriteLine("Fizz");
				}
				else if (i % 5 == 0)
				{
					Console.WriteLine("Buzz");
				}
				else
				{
					Console.WriteLine(i);
				}
			}
		}
		/// <summary>
		/// First n numbers of fibonacci
		/// </summary>
		/// <param name="n"></param>
		public static void Fibonacci(int n)
		{
			long preivous = 0, current = 1, temp;

			for (int i = 0; i < n; i++)
			{
				temp = preivous;
				preivous = current;
				current = preivous + temp;
				Console.WriteLine($"{i} - {current}");

			}
		}
		/// <summary>
		/// Change the value of 3 varibles without a temp variable
		/// </summary>
		/// <param name="a"></param>
		/// <param name="b"></param>
		public static void ChangeValue(int a, int b)
		{
			Console.WriteLine($"Original values a {a} , b {b}");
			a += b;
			b = a - b;
			a -= b;
			Console.WriteLine($"Changed values a {a} , b {b}");
		}
	}

}
