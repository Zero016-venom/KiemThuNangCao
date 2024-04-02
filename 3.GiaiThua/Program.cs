using System;

public class Program
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Nhập một số nguyên dương: ");
		int number = int.Parse(Console.ReadLine());

		long factorial = CalculateFactorial(number);

		Console.WriteLine("Giai thừa của {0} là: {1}", number, factorial);
	}

	public static long CalculateFactorial(int n)
	{
		if (n == 0)
		{
			return 1;
		}
		else
		{
			long result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}
			return result;
		}
	}
}