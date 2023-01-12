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

		public void peek()
		{
			if(this.top==null)
			{
				Console.WriteLine("Stack is empty");
				return;
			}
			Console.WriteLine("{ 0} is in the top of the stack " + this.top.data);
		}

		public void pop()
		{
			if(this.top==null)
			{
				Console.WriteLine("Stack is empty,Deletion is not possible");
				return;
			}
			Console.WriteLine("Value popped is {0}", this.top.data);
			this.top = this.top.next;
		}
	}
}

