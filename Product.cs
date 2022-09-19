using System.Drawing;

public class Product
{

    // Attributes
    int code;
    string name;
    string description;
    int price;
    int iva;

    // costruttore
    public Product()
    {
       code = GenerateCode();
    }

    // costruttore con parametri
    public Product(string name, string description, int price, int iva)
    {
        code = GenerateCode();
        this.name = name;
        this.description = description;
        this.price = price;
        this.iva = iva;
    }

    // Getters
    public int GetCode()
    {
        return code;
    }
    public string GetName()
    {
       return name;
    }
    public string GetDescription()
    {
        return description;
    }
    public int GetPrice()
    {
        return price;
    }
    public int GetIva()
    {
        return iva;
    }
    public float GetTaxedPrice()
    {
        float taxedPrice = ((float)price / 100) * iva;
        return taxedPrice;
    }

    public string GetFullName()
    {
        string fullname = GetName() + code;
        return fullname;
    }

    public string GetFullCode()
    {
        char pad = '0';
        return code.ToString().PadLeft(8, pad);
    }

    // Setters
    public void SetName(string newName)
    {
        name = newName;
    }
    public void SetDescription(string newDescription)
    {
        description = newDescription;
    }
    public void SetPrice(int newPrice)
    {
        price = newPrice;
    }
    public void SetIva(int newIva)
    {
        iva = newIva;
    }

    // Methods
    private int GenerateCode()
    {
        return new Random().Next(1, 999999999);
    }

}
