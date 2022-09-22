
Console.OutputEncoding = System.Text.Encoding.UTF8;

Water water = new Water(1.5, 5, "Lete", "salute", "water che calma il tuo spirito", 50, 22);

Console.WriteLine(water.Name);
Console.WriteLine(water.Description);
Console.WriteLine(water.Price);
Console.WriteLine(water.Iva);
water.PrintProduct();

water.LitersToEmpty();
water.Fill(1.5);
water.Fill(1.4);
water.LitersToDrink(1.6);
water.LitersToDrink(1.5);
Console.WriteLine(water.Liters);
Console.WriteLine(Water.ConvertToGallons(2));

Console.WriteLine();
Console.WriteLine();

FruitBag fruitBag = new FruitBag(4, "cioccola", "Mela", "frutto tropicale", 2, 22);

Console.WriteLine(fruitBag.Name);
Console.WriteLine(fruitBag.Description);
Console.WriteLine(fruitBag.Price);
Console.WriteLine(fruitBag.Iva);
fruitBag.PrintProduct();

fruitBag.bagToEmpty();
fruitBag.Fill(3);
fruitBag.Fill(4);
fruitBag.FoodToEat(2);
fruitBag.FoodToEat(4);
Console.WriteLine(fruitBag.Fruits);
fruitBag.PrintProduct();