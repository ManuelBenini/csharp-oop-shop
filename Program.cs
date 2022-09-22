
Console.OutputEncoding = System.Text.Encoding.UTF8;

Water acqua = new Water(1.5, 5, "Lete", "salute", "Acqua che calma il tuo spirito", 50, 22);

Console.WriteLine(acqua.Name);
Console.WriteLine(acqua.Description);
Console.WriteLine(acqua.Price);
Console.WriteLine(acqua.Iva);
Console.WriteLine(acqua.PrintProduct());
