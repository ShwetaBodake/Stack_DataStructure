using System;
namespace Stack_DataStructure
{
	public class LinkedListStack
	{
		private Node top;
		public LinkedListStack()
		{
			this.top = null;
		}

		public void push(int value)
		{
			Node node = new Node(value);
			if(this.top==null)
			{
				node.next = null;
			}
			else
			{
				node.next = this.top;

			}
			this.top = node;
			Console.WriteLine("{0} pushed to stack " + value);
		}


		public void display()
		{
			Node temp = this.top;
			while(temp!= null)
			{
				Console.Write(temp.data + " ");
				temp = temp.next;
			}
		}
	}
}

