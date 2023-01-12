// See https://aka.ms/new-console-template for more information
namespace Stack_DataStructure
{
 public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.push(70);
            stack.push(30);
            stack.push(56);
            stack.display();
            stack.peek();
            stack.pop();

        }
    }
}
