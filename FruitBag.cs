public class FruitBag : Product, ISolidFood
{    
    public int Fruits { get; set; }
    public int MaxFruits { get; set; } = 5;
    public string Source { get; set; }

    public FruitBag(int fruits, string source, string name, string description, int price, int iva) : base(name, description, price, iva)
    {
        Fruits = fruits;
        Source = source;
    }

    public int FoodToEat(int foodToEat)
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

    public int Fill(int foodToAdd)
    {
        if (Fruits < MaxFruits)
        {
            Fruits += foodToAdd;

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


