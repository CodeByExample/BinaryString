namespace BinaryString
{
	using System;

	internal static class Program
	{
		private static void Main(string[] args)
		{
			const int number = 4096;

			Console.WriteLine(number.ToBinaryString());

			Console.ReadKey(true);
		}
	}
}