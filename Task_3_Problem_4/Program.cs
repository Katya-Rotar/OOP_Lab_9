internal class Program
{
    private static void Main(string[] args)
    {
        int[] input = Array.ConvertAll(Console.ReadLine().Split(", "), int.Parse);
        Lake<int> lake = new Lake<int>(input);
        Console.WriteLine("\n"+string.Join(", ", lake)); // об'єднання значень у певну послідовність використовуючи IEnumerable 
    }
}