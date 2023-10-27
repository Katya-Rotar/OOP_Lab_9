class Person: IComparable<Person> //тип T повинен реалізовувати інтерфейс IComparable<T>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Town { get; set; }
    public Person(string name, int age, string town) {
        this.Name = name;
        this.Age = age;
        this.Town = town;
    }
    public int CompareTo(Person other)
    {
        int nameComparison = Name.CompareTo(other.Name);
        if (nameComparison != 0)
        {
            return nameComparison;
        }

        int ageComparison = Age.CompareTo(other.Age);
        if (ageComparison != 0)
        {
            return ageComparison;
        }

        return Town.CompareTo(other.Town);
    }
}
