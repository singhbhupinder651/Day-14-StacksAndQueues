namespace StacksAndQueues
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Stacks and Queues Problem");
            Console.WriteLine("Use case #1: Create a Stack");
            Console.WriteLine("Use case #2: Peek and Pop from Stack till its empty");
            Console.WriteLine("Use case #3: Create a Queue");
            Console.WriteLine("Use case #4: Dequeue from beginning of Queue");

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
                case 3:
                    Queue queueOne = new Queue();
                    queueOne.Enqueue(56);
                    queueOne.Enqueue(30);
                    queueOne.Enqueue(70);
                    queueOne.Display();
                    break;
                case 4:
                    Queue queueTwo = new Queue();
                    queueTwo.Enqueue(56);
                    queueTwo.Enqueue(30);
                    queueTwo.Enqueue(70);
                    Console.WriteLine("-----------Queue before dequeue operation-----------");
                    queueTwo.Display();
                    Console.WriteLine("\n--------------------------------------------------");
                    queueTwo.Dequeue();
                    Console.WriteLine("-----------Queue after dequeue operation-----------");
                    queueTwo.Display();
                    Console.WriteLine("\n--------------------------------------------------");
                    break;
                default:
                    Console.WriteLine("Please enter a valid number from given options");
                    break;
            }

        }
    }
}