using Newtonsoft.Json;

public class Product
{
public string Name { get; set; }
public decimal Price { get; set; }
public int Quantity { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add(new Product {Name = "клявіатюра", Price = 6767, Quantity = 67 });
        products.Add(new Product {Name = "мішка", Price = 52, Quantity = 5 });
        products.Add(new Product {Name = "монік", Price = 6000, Quantity = 77 });

        string json = JsonConvert.SerializeObject(products);
        Console.WriteLine($"Json рядок: {json}");

        List<Product> newProd = JsonConvert.DeserializeObject<List<Product>>(json);
        Console.WriteLine("тьовари після десереалізації: ");
        foreach(Product product in newProd)
        {
            Console.WriteLine("Назва: " + product.Name + " " + "Ціна: "+ product.Price + " " + "Кількість" + product.Quantity);
        }
    }
}