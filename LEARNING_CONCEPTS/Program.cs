namespace LEARNING_CONCEPTS
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
			//someClass._lastName = "Tasdighi";

			SomeNewClass someNewClass = new SomeNewClass();

			//someNewClass.Sum();

			Utility utility = new Utility();

			//utility.DrawCircle(10, 20, 30, 5);
			utility.DrawCircle(x: 10, y: 20, radius: 30, width: 5);
			utility.DrawCircle(x: 10, y: 20, width: 5, radius: 30);
			utility.DrawCircle(10, 20, radius: 30, width: 5);
			//utility.DrawCircle(10, 20, radius: 30, 5); // Wrong Usage!
			utility.DrawCircle(10, 20, width: 5, radius: 30);

			Stack oStack = new Stack();

			Queue oQueue = new Queue();

			oQueue.Push(5);
			oQueue.Push(11);
			oQueue.Push(7);

			int intResult;

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			intResult = oQueue.Pop();
			System.Console.WriteLine("> " + intResult);

			System.Console.Write("Press [ENTER] To Exit...");
			System.Console.ReadLine();
		}
	}
}
