namespace DigitalProductInventoryApplication;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

public interface IPrimaryProperties
{
    int Id { get; set; }
    string Title { get; set; }
}
public abstract class ProductBase : IPrimaryProperties
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int CategoryId { get; set; }
}


public static class FactoryPattern<T, U> where T : class, U, new()
                                         where U : IPrimaryProperties
{
    public static U GetInstance()
    {
        U objT;
        objT = new T();
        return objT;
    }
}
