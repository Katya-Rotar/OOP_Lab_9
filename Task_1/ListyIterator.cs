class ListyIterator<T>{
    private List<T> element;
    private int currentIndex;

    public ListyIterator(T[] element)
    {
        this.element = new List<T>(element);
        this.currentIndex = 0;
    }
    public bool HasNext()
    {
        return currentIndex < element.Count - 1;
    }
    public bool Move() {
        if(HasNext())
        {
            currentIndex++;
            return true;
        }
        return false;
    }
    public void Print() {
        if (element.Count == 0){
            throw new InvalidOperationException("Invalid Operation!");
        }
        else
        {
            Console.WriteLine(element[currentIndex]);
        }
    }
}