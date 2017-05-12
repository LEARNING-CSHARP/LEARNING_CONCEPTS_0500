namespace LEARNING_CONCEPTS
{
	public class Queue
	{
		private System.Collections.ArrayList _list = new System.Collections.ArrayList();

		public void Push(int data)
		{
			_list.Add(data);
		}

		public int Pop()
		{
			if (_list.Count >= 1)
			{
				int intData = (int)_list[0];

				_list.RemoveAt(0);

				return (intData);
			}
			else
			{
				return (-1);
			}
		}
	}
}
