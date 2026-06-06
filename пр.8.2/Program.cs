using System.Diagnostics;

public class NotPositiveNumberException : Exception
{
    public NotPositiveNumberException(string message) : base(message){}
}
public class NotFractionalNumberException: Exception
{
    public NotFractionalNumberException(string message) : base(message){}
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть додатнє число: ");
        string input = Console.ReadLine();
        try
        {
            double number = ParsePositiveFractionalNumber(input);
            Console.WriteLine("введено правильне число: " + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("помилка - введене значення не є число");
        }
        catch (OverflowException)
        {
            Console.WriteLine("помилка - введене число виходить за межі діапазону");
        }
        catch (NotPositiveNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch(NotFractionalNumberException ex)
        {
            Console.WriteLine(ex.Message);
        }
        static double ParsePositiveFractionalNumber(string input)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                double number = double.Parse(input);
                if(number <= 0)
                {
                    throw new NotPositiveNumberException("число повинно бути додатнім");
                }
                if (number % 1 == 0)
                {
                    throw new NotFractionalNumberException("число повинно бути дробовим");
                }
                return number;
            }
            finally
            {
                stopwatch.Stop();
                Console.WriteLine("перетворення тексту в число зайняло "+ stopwatch.ElapsedTicks + " такти таймера");
            }
        }
    }
}