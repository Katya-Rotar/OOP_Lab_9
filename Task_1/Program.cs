internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Create ");
        string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        ListyIterator<string> listyIterator = new ListyIterator<string>(input);

        while (true) {
            try
            {
                string command = Console.ReadLine();
                if (command.ToLower() == "end")
                {
                    break;
                }
                else
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(listyIterator.Move());
                            break;
                        case "HasNext":
                            Console.WriteLine(listyIterator.HasNext());
                            break;
                        case "Print":
                            listyIterator.Print();
                            break;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}