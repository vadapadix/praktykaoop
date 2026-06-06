public class ValidationException : Exception
{
    public ValidationException(string message) : base(message){}
}
public class PasswordValidator
{
    public void Validate(string password)
    {
        if (password.Length < 6)
        {
            throw new ValidationException("а так не мона там менше 6 символів");
        }
        bool hasLetter = false;
        bool hasDigit = false;
        foreach(char c in password)
        {
            if (char.IsLetter(c))
            {
                hasLetter = true;
            }
            if (char.IsDigit(c))
            {
                hasDigit = true;
            }
        }
        if (!hasLetter)
        {
            throw new Exception("пароль повинен містити хоча б одну цифру");
        }
        if (!hasDigit)
        {
            throw new Exception("пароль повинен мати хоча б одну цифру");
        }
    }
}
class Prgoram
{
    static void Main()
    {
        Console.WriteLine("Введіть пароль: ");
        string password = Console.ReadLine();
        PasswordValidator validator = new PasswordValidator();

        try
        {
            validator.Validate(password);
            Console.WriteLine("success yay");
        } catch (ValidationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}