using System;

namespace Calculator
{
	class Program
	{
		static void Main(string[]args)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("Enter a number: ");
			var num1 = Convert.ToInt32(Console.ReadLine());
			
			Console.Write("Enter another number: ");
			var num2 = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine(num1 + num2);
			
			Console.ReadLine();

		}
	}
}