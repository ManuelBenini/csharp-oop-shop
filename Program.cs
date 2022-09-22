
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