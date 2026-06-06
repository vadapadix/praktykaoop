// завдання 2
public class ChangeTracker<T>
{
    private T currentValue;
    private bool firstCall = true;
    public void LogValue(T newValue)
    {
        if (firstCall)
        {
            Console.WriteLine($"Початкове значення: {newValue}");
            currentValue = newValue;
            firstCall = false;
        }
        else
        {
            Console.WriteLine($"Значення змінилось з {currentValue} на {newValue}");
            currentValue = newValue;
        }
    }
}

class Program
{
    static void Main()
    {
        ChangeTracker<int> intTracker = new ChangeTracker<int>();
        intTracker.LogValue(5);
        intTracker.LogValue(15);

        ChangeTracker<double> doubleTracker = new ChangeTracker<double>();
        doubleTracker.LogValue(2.5);
        doubleTracker.LogValue(3.9);

        ChangeTracker<string> stringTracker = new ChangeTracker<string>();
        stringTracker.LogValue("здрастє");
        stringTracker.LogValue("мардастє");

    }
}