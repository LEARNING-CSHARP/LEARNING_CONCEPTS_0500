﻿namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// Method Overloading
	/// </summary>
	public class SomeNewClass
	{
		public int Sum(int x, int y)
		{
			//return (x + y);

			//return x + y;

			int result = x + y;

			return result;
		}

		public int Sum(int x, int y, int z)
		{
			//return (x + y + z);

			//return x + y + z;

			int result = x + y + z;

			return result;
		}
	}
}
