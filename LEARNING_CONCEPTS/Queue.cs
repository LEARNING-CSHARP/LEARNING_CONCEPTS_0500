namespace LEARNING_CONCEPTS
{
	public class Queue
	{
		private System.Collections.ArrayList _list = new System.Collections.ArrayList();

		public void Push(int data)
		{
			_list.Add(data);
		}

		public int? Pop()
		{
			if (_list.Count == 0)
			{
				return null;
			}

			int result =
				(int)_list[0];

			_list.RemoveAt(0);

			return result;
		}
	}
}
