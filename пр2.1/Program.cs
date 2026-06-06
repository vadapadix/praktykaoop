// завдання 1
public class SequenceBuilder<T>
{
    private List<T> items = new List<T>();
    public void Add(T item)
    {
        items.Add(item);
    }
    public List<T> GetAll()
    {
        return items;
    }
    public void PrintAll()
    {
        foreach (T item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main()
    {
        SequenceBuilder<string> words =new SequenceBuilder<string>();
        words.Add("перший");
        words.Add("другій");
        words.Add("третій");
        words.PrintAll();
    }
}