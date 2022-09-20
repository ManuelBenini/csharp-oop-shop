using System.Drawing;

public class Product
{

    // Attributes
    public int Code { get; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int Iva { get; set; }

    // costruttore
    public Product()
    {
        Code = GenerateCode();
    }

    // costruttore con parametri
    public Product(string name, string description, int price, int iva)
    {
        Code = GenerateCode();
        Name = name;
        Description = description;
        Price = price;
        Iva = iva;
    }

    // Getters & Setters
    public float GetTaxedPrice()
    {
        float taxedPrice = ((float)Price / 100) * Iva;
        return taxedPrice;
    }

    public string GetFullName()
    {
        string fullname = Name + Code;
        return fullname;
    }

    public string GetFullCode()
    {
        char pad = '0';
        return Code.ToString().PadLeft(8, pad);
    }

    // Methods
    private int GenerateCode()
    {
        return new Random().Next(1, 999999999);
    }

}
