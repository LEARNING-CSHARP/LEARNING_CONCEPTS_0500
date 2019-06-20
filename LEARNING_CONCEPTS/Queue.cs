namespace LEARNING_CONCEPTS
{
	public class Queue
	{
		private System.Collections.ArrayList _list = new System.Collections.ArrayList();

		public void Push(uint data)
		{
			_list.Add(data);
		}

		public int Pop()
		{
			if (_list.Count >= 1)
			{
				int data = (int)_list[0];

				_list.RemoveAt(0);

				return data;
			}
			else
			{
				return -1;
			}
		}
	}
}
