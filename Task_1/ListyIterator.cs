using System.Collections;
using System.Xml.Linq;

class ListyIterator<T> : IEnumerable<T>{
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
    public IEnumerator<T> GetEnumerator()
    {
        foreach (T elements in element)
        {
            yield return elements;
        }
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
    public void PrintAll() {
        foreach (T elements in element) {
            Console.Write(elements + " ");
        }
    }
}