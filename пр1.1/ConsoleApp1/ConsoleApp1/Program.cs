abstract class TaskProcessor
{
    // шаблонний метод
    public void ProcessTask()
    {
        Console.WriteLine("Розпочато виконання завдання.");
        ExecuteTask();
        Console.WriteLine("Завдання успішно завершено.");
    }
    protected abstract void ExecuteTask();
}
class MathTaskProcessor : TaskProcessor
{
    protected override void ExecuteTask()
    {
        Console.WriteLine("Виконується перевірка математичного розрахунку.");
    }
}
class ProgrammingTaskProcessor : TaskProcessor
{
    protected override void ExecuteTask()
    {
        Console.WriteLine("Виконується компіляція та перевірка програмного коду.");
    }
}
class Program
{
    static void Main()
    {
        TaskProcessor math = new MathTaskProcessor();
        TaskProcessor programming = new ProgrammingTaskProcessor();
        math.ProcessTask();
        programming.ProcessTask();
    }
}
