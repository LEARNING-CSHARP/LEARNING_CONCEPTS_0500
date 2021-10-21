namespace LEARNING_CONCEPTS
{
	public class Stack
	{
		private int _index = -1;
		private readonly System.Collections.ArrayList _list = new System.Collections.ArrayList();

		public void Push(int data)
		{
			_index++;

			_list.Add(data);
		}

		public int? Pop()
		{
			if (_index == -1)
			{
				return null;
			}

			int result =
				(int)_list[_index];

			_list.RemoveAt(_index);

			_index--;

			return result;
		}
	}
}
