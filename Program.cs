namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stacks and Queues Problem");
            Console.WriteLine("Use case #1: Create a Stack");
            Console.WriteLine("Use case #2: Peek and Pop from Stack till its empty");

            Console.Write("Please select a program to run from options above: ");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch(choice)
            {
                case 1:
                    Stack stack = new Stack();
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    Stack stackOne = new Stack();
                    stackOne.Push(70);
                    stackOne.Push(30);
                    stackOne.Push(56);
                    Console.WriteLine("-----------Stack before empty operation-----------");
                    stackOne.Display();
                    Console.WriteLine("\n--------------------------------------------------");
                    Console.Write("\n");
                    stackOne.IsEmpty();
                    Console.WriteLine("-----------Stack after empty operation-----------");
                    stackOne.Display();
                    Console.WriteLine("-------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }

        }
    }
}