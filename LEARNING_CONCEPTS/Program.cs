namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeClass someClass = new SomeClass(); // It's Better!
			SomeClass oSomeClass = new SomeClass();
			SomeClass theSomeClass = new SomeClass();
			SomeClass objSomeClass = new SomeClass();

			oSomeClass.FirstName = "Dariush";
			//oSomeClass._lastName = "Tasdighi";

			SomeNewClass oSomeNewClass = new SomeNewClass();

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
