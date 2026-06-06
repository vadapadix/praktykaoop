public class NotPositiveNumberException : Exception
{
    public NotPositiveNumberException(string message):base(message){}
}
public class NotFractionalNumberException : Exception
{
    public NotFractionalNumberException(string message):base(message){}
}
class Program
{
    static void Main()
    {
        Console.WriteLine("ввідеть додатнє дробове число6 ");
        string input = Console.ReadLine();
        try
        {
            double number = double.Parse(input);
            if (number <= 0)
            {
                throw new NotPositiveNumberException("Помилка: число повинно бути додатнім");
            }
            if (number % 1 == 0)
            {
                throw new NotFractionalNumberException("помилка: число повинно бути дробовим");
            }
            Console.WriteLine("введено правильне число: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("введене значення не є числом");
        }
        catch (OverflowException)
        {
            Console.WriteLine("введене число виходить за межі доступного діапазону");
        }
        catch (NotPositiveNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotFractionalNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}