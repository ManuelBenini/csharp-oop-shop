public class FruitBag : Product, ISolidFood
{    
    public double Fruits { get; set; }
    public string FruitKg { get; set; }
    public double MaxFruits { get; set; } = 5;
    public string Source { get; set; }

    public FruitBag(double fruits, string fruitKg, double maxFruits, string source, string name, string description, int price, int iva) : base(name, description, price, iva)
    {
        Fruits = fruits;
        FruitKg = fruitKg;
        MaxFruits = maxFruits;
        Source = source;
    }

    public double FoodToEat(double foodToEat)
    {
        if (Fruits >= foodToEat)
        {
            Fruits -= foodToEat;
            return Fruits;
        }
        else
        {
            Console.WriteLine("Stai mangiando più frutta di quanto ce ne sia.");
            return 0;
        }
    }

    public double Fill(double foodToAdd)
    {
        if (Fruits < MaxFruits)
        {
            Fruits += MaxFruits;

            if (Fruits > MaxFruits)
            {
                Fruits = 5;
                Console.WriteLine("Il sacchetto è stato riempito fino al suo limite.");
                return Fruits;
            }
            else
            {
                Console.WriteLine("Il sacchetto è stato riempito!");
                return Fruits;
            }
        }
        else
        {
            Console.WriteLine("Il sacchetto è gia al massimo della sua capacità.");
            return Fruits;
        }

    }

    public void bagToEmpty()
    {
        Fruits = 0;
    }

    public override void PrintProduct()
    {
        base.PrintProduct();
        Console.WriteLine($", Fonte: {Source}, Frutti: {Fruits}");
    }
}


