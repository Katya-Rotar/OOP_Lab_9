internal class Program
{
    private static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        while (true)
        {
            string command = Console.ReadLine();
            if (command.ToLower() == "end")
            {
                break;
            }
            else {
                string[] input = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (input[0].ToLower() == "push") {
                    int[] convertArray = Array.ConvertAll(input[1].Split(' '), int.Parse);
                    stack.Push(convertArray);
                }
                else if (input[0].ToLower() == "pop") {
                    stack.Pop();
                }
            }
        }
        foreach(int i in stack)
        {
            Console.WriteLine(i);
        }
        foreach (int i in stack) {
            Console.WriteLine(i);
        }
    }
}