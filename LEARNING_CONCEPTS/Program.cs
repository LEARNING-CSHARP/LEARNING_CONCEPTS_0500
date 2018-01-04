﻿namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			// Old Standard
			SomeClass oSomeClass = new SomeClass();
			SomeClass theSomeClass = new SomeClass();
			SomeClass objSomeClass = new SomeClass();

			// New Standard
			SomeClass someClass = new SomeClass(); // It's Better!

			someClass.FirstName = "Dariush";
			//someClass.lastName = "Tasdighi";

			SomeNewClass someNewClass = new SomeNewClass();

			//someNewClass.Sum();

			Utility utility = new Utility();

			utility.DrawCircle(10, 20, 30, 5);
			utility.DrawCircle(x: 10, y: 20, radius: 30, width: 5);
			utility.DrawCircle(x: 10, y: 20, width: 5, radius: 30);
			utility.DrawCircle(10, 20, radius: 30, width: 5);
			//utility.DrawCircle(10, 20, radius: 30, 5); // Wrong Usage!
			utility.DrawCircle(10, 20, width: 5, radius: 30);

			Stack stack = new Stack();

			Queue queue = new Queue();

			queue.Push(5);
			queue.Push(11);
			queue.Push(7);

			int result;

			result = queue.Pop();
			System.Console.WriteLine("> " + result);

			result = queue.Pop();
			System.Console.WriteLine("> " + result);

			result = queue.Pop();
			System.Console.WriteLine("> " + result);

			result = queue.Pop();
			System.Console.WriteLine("> " + result);

			result = queue.Pop();
			System.Console.WriteLine("> " + result);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
