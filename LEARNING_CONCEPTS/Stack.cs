namespace LEARNING_CONCEPTS
{
	/// <summary>
	/// Stack
	/// </summary>
	public class Stack
	{
		//public int Index = -1;
		//public System.Collections.ArrayList List = new System.Collections.ArrayList();

		private int _index = -1;
		private System.Collections.ArrayList _list = new System.Collections.ArrayList();

		public void Push(uint data)
		{
			_index++;

			_list.Add(data);
		}

		public int Pop()
		{
			if (_index >= 0)
			{
				int data = (int)_list[_index];

				_list.RemoveAt(_index);

				_index--;

				return data;
			}
			else
			{
				return -1;
			}
		}
	}
}
