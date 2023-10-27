internal class Program
{
    private static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var SortedSetsName = new SortedSet<Person>(new NameComparator());
        var SortedSetsAge = new SortedSet<Person>(new AgeComparator());

        for (int i = 0; i < n; i++) {
            string[] input = Console.ReadLine().Split(' ');
            string name = input[0];
            int age = int.Parse(input[1]);
            Person person = new Person(name, age);
            SortedSetsName.Add(person);
            SortedSetsAge.Add(person);
        }
        Console.WriteLine();
        foreach(Person personName in SortedSetsName) {
            Console.WriteLine(personName.ToString());
        }
        foreach(Person personAge in SortedSetsAge) {
            Console.WriteLine(personAge.ToString());
        }
    }
}