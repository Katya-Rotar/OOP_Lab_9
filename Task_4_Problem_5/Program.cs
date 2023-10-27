internal class Program
{
    private static void Main(string[] args)
    {
        List<Person> people = new List<Person>();
        while (true) {
            string input = Console.ReadLine();
            if (input.ToLower() == "end")
            {
                break;
            }
            else {
                string[] arrayInput = input.Split(" ");
                string name = arrayInput[0];
                int age = int.Parse(arrayInput[1]);
                string town = arrayInput[2];
                Person person = new Person(name, age, town);
                people.Add(person);
            }
        }
        int n = int.Parse(Console.ReadLine());
        if (n >= 1 && n <= people.Count)
        {
            Person targetPerson = people[n - 1];
            int equalCount = 0;
            int notEqualCount = 0;

            foreach (Person person in people)
            {
                int comparison = targetPerson.CompareTo(person);
                if (comparison == 0)
                {
                    equalCount++;
                }
                else
                {
                    notEqualCount++;
                }
            }

            if (equalCount > 1)
            {
                Console.WriteLine($"{equalCount} {notEqualCount} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}