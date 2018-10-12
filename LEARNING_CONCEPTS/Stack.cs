namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// Stack
	/// </summary>
	public class Stack
	{
		//public int Index = -1;
		//public System.Collections.ArrayList List = new System.Collections.ArrayList();

		private int index = -1;
		private System.Collections.ArrayList list = new System.Collections.ArrayList();

		public void Push(int data)
		{
			index++;

			list.Add(data);
		}

		public int Pop()
		{
			if (index >= 0)
			{
				int data = (int)list[index];

				list.RemoveAt(index);

				index--;

				return data;
			}
			else
			{
				return -1;
			}
		}
	}
}
