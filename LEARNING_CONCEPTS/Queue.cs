namespace LEARNING_CONCEPTS
{
	public class Queue
	{
		private System.Collections.ArrayList list = new System.Collections.ArrayList();

		public void Push(int data)
		{
			list.Add(data);
		}

		public int Pop()
		{
			if (list.Count >= 1)
			{
				int intData = (int)list[0];

				list.RemoveAt(0);

				return (intData);
			}
			else
			{
				return (-1);
			}
		}
	}
}
