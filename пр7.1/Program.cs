using System;
class Program
{
    static void Main()
    {
        try{Console.WriteLine(Divide(10,0));}
        catch(Exception ex){
            Console.WriteLine("Знайдений такий-то винтяток:"+ (ex.Message));
            }
    }
    static int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new Exception("а так не мона, ділення на ноль не мона ти шо");
        }
        return a / b;
    }
}