using System.Drawing;

public abstract class Product
{

    // Attributes
    public int Code { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Iva { get; set; }

    // costruttore
    public Product(string name, string description, int price, int iva)
    {
        Code = GenerateCode();
        Name = name;
        Description = description;
        Price = price;
        Iva = iva;
    }

    // Methods
    public float GetTaxedPrice()
    {
        float taxedPrice = ((float)Price / 100) * Iva;
        return taxedPrice;
    }

    public virtual void PrintProduct()
    {
        Console.Write($"Nome: {Name}, Codice: {Code}");
    }

    public string GetFullCode()
    {
        char pad = '0';
        return Code.ToString().PadLeft(8, pad);
    }

    public static int GenerateCode()
    {
        return new Random().Next(1, 999999999);
    }

}

interface ILiquids
{
    public double LitersToDrink(double litersToDrink);
    public double Fill(double litersToAdd);
}

interface ISolidFood
{
    public double FoodToEat(double foodToEat);
    public double Fill(double foodToAdd);
}