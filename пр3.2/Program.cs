public interface IEntity<TKey>
{
    TKey Id { get; set; }
}
public class Repository<TEntity, TKey>
    where TEntity : IEntity<TKey>
{
    private List<TEntity> items = new List<TEntity>();

    public void Add(TEntity entity)
    {
        items.Add(entity);
    }
    public TEntity Get(TKey id)
    {
        foreach (TEntity item in items)
        {
            if (item.Id.Equals(id))
            {
                return item;
            }
        }

        return default;
    }
    public bool Delete(TKey id)
    {
        TEntity item = Get(id);

        if (item != null)
        {
            items.Remove(item);
            return true;
        }

        return false;
    }
}public class Student : IEntity<int>
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Product : IEntity<string>
{
    public string Id { get; set; }
    public string Title { get; set; }
}
class Program
{
    static void Main()
    {
        Repository<Student, int> students =
            new Repository<Student, int>();

        students.Add(new Student
        {
            Id = 1,
            Name = "владік"
        });

        students.Add(new Student
        {
            Id = 2,
            Name = "АЛЛа"
        });

        Student student = students.Get(1);
        if (student != null)
        {
            Console.WriteLine(student.Name);
        }
        Console.WriteLine(students.Delete(2));
        Repository<Product, string> products =
new Repository<Product, string>();

        products.Add(new Product
        {
            Id = "A1",
            Title = "Ноутбук"
        });

        products.Add(new Product
        {
            Id = "B2",
            Title = "Мишка"
        });

        Product product = products.Get("A1");

        if (product != null)
        {
            Console.WriteLine(product.Title);
        }

        Console.WriteLine(products.Delete("B2"));
    }
}