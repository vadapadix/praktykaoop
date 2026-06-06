public class KeyValueStore<TKey, TValue>
{
    private List<KeyValuePair<TKey, TValue>> items =
        new List<KeyValuePair<TKey, TValue>>();

    public void Add(TKey key, TValue value)
    {
        items.Add(new KeyValuePair<TKey, TValue>(key, value));
    }

    public TValue Get(TKey key)
    {
        foreach (var item in items)
        {
            if (item.Key.Equals(key))
            {
                return item.Value;
            }
        }

        throw new Exception("Ключ не знайдено");
    }
}

class Program
{
    static void Main()
    {
        KeyValueStore<int, string> store =
            new KeyValueStore<int, string>();

        store.Add(1, "Ноутбук");
        store.Add(2, "Мишка");
        store.Add(3, "Клавіатура");

        Console.WriteLine(store.Get(1));
        Console.WriteLine(store.Get(2));

        Console.WriteLine(store.Get(5));
    }
}