class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int LengthComparison = x.Name.Length.CompareTo(y.Name.Length);
        if (LengthComparison != 0) {
            return LengthComparison;
        }
        return string.Compare(x.Name, y.Name, StringComparison.OrdinalIgnoreCase); //порівняння рядків повинно бути регістронезалежним
    }
}