namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeNewClass xyz = new SomeNewClass();

			// Old Standard
			SomeClass oSomeClass = new SomeClass();
			SomeClass theSomeClass = new SomeClass();
			SomeClass objSomeClass = new SomeClass();

			// New Standard
			SomeClass someClass = new SomeClass(); // It's Better!

			// یادآوری
			//txtFirstName
			//firstNameTextBox

			someClass.FirstName = "Dariush";
			//someClass.lastName = "Tasdighi";

			SomeNewClass someNewClass = new SomeNewClass();

			//someNewClass.Sum();

			Circle circle = new Circle();

			circle.Draw(10, 20, 30, 5);
			circle.Draw(x: 10, y: 20, radius: 30, width: 5);
			circle.Draw(x: 10, y: 20, width: 5, radius: 30);
			circle.Draw(10, 20, radius: 30, width: 5);
			//utility.DrawCircle(10, 20, radius: 30, 5); // Compile Error!
			circle.Draw(10, 20, width: 5, radius: 30);

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
