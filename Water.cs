public class Water : Product , ILiquids
{
    public double Liters { get; set; }
    public double MaxCapacity { get; set; } = 1.5;
    public double Ph { get; set; }
    public string Source { get; set; }
    public static double LitersToGallonsConversionRate { get; set; } = 3.785;

    public Water(double liters, int ph, string source, string name, string description, int price, int iva) : base(name, description, price, iva)
    {
        Liters = liters;
        Ph = ph;
        Source = source;
    }

    public double LitersToDrink(double litersToDrink)
    {
        if(Liters >= litersToDrink)
        {
            Liters -= litersToDrink;
            return Liters;
        }
        else
        {
            Console.WriteLine("Stai bevendo più acqua di quanto ce ne sia.");
            return 0;
        }
    }

    public double Fill(double litersToAdd)
    {
        if(Liters < MaxCapacity)
        {
            Liters += litersToAdd;

            if(Liters > MaxCapacity)
            {
                Liters = 1.5;
                Console.WriteLine("La bottiglia è stata riempita fino al suo limite.");
                return Liters;
            }
            else
            {
                Console.WriteLine("La bottiglia è stata riempita!");
                return Liters;
            }
        }
        else
        {
            Console.WriteLine("La bottiglia è gia al massimo della sua capacità.");
            return Liters;
        }

    }

    public void LitersToEmpty()
    {
        Liters = 0;
    }

    public override void PrintProduct()
    {
        base.PrintProduct();
        Console.Write($", Fonte: {Source}, Acidità(Ph): {Ph}, Litri: {Liters}");
        Console.WriteLine();
    }

    public static double ConvertToGallons(double liters)
    {
        double convertedLiters = liters * Water.LitersToGallonsConversionRate;
        return convertedLiters;
    }
}


