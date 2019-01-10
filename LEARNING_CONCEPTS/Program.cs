namespace LEARNING_CONCEPTS
{
	class Program
	{
		static void Main(string[] args)
		{
			SomeNewNewClass xyz = new SomeNewNewClass();

			// استاندارد قدیم
			SomeClass oSomeClass = new SomeClass();
			SomeClass objSomeClass = new SomeClass();

			// استاندارد جدید
			SomeClass someClass = new SomeClass(); // It's Better!
			SomeClass theSomeClass = new SomeClass(); // It's Better!

			// استاندارد قدیم
			string strFullName = "Ali Reza Alavi";

			// استاندارد جدید
			string fullName = "Ali Reza Alavi";
			string fullNameString = "Ali Reza Alavi";

			// استاندارد قدیم
			//txtFirstName
			//lblFirstName

			// استاندارد جدید
			//firstNameTextBox
			//firstNameLabel

			someClass.FirstName = "Dariush";
			//someClass.lastName = "Tasdighi";

			SomeNewNewClass someNewNewClass = new SomeNewNewClass();

			//someNewNewClass.Sum();

			Circle circle = new Circle();

			circle.Draw(10, 20, 30, 5);
			circle.Draw(x: 10, y: 20, radius: 30, width: 5);
			circle.Draw(x: 10, width: 5, radius: 30, y: 20);
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

			System.Console.Write("Press [ENTER] To Exit... ");
			System.Console.ReadLine();
		}
	}
}
