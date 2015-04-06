namespace BinaryString
{
	using System.Collections.Generic;

	public static class Extensions
	{
		public static string ToBinaryString(this int source)
		{
			Stack<char> stack = new Stack<char>();

			for (int i = 0; i < 32; i++)
			{
				stack.Push(source % 2 == 1 ? '1' : '0');

				source = source / 2;
			}

			return new string(stack.ToArray());
		}
	}
}