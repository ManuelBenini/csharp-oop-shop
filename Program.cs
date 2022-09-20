
Console.OutputEncoding = System.Text.Encoding.UTF8;


Product firstBook = new Product();

firstBook.Name = "Do Androids Dream About Electric Sheeps?";
firstBook.Description = "Il libro che ha ispirato Blade Runner!";
firstBook.Price = 50;
firstBook.Iva = 22;


Console.WriteLine("Nome del primo libro: " + firstBook.Name);
Console.WriteLine("Descrizione: " + firstBook.Description);
Console.WriteLine("Prezzo: " + firstBook.Price + "€");
Console.WriteLine("Iva: " + firstBook.Iva + "%");
Console.WriteLine("Prezzo tassato: " + firstBook.GetTaxedPrice());
Console.WriteLine("Codice: " + firstBook.Code);
Console.WriteLine("Nome con codice: " + firstBook.GetFullName());
Console.WriteLine("Codice completo: " + firstBook.GetFullCode());


int terminalWidth = Console.WindowWidth;
int terminalheight = Console.WindowHeight;

Console.WriteLine();
Console.WriteLine(("").PadRight(terminalWidth, '-'));
Console.WriteLine(("").PadRight(terminalWidth, '-'));
Console.WriteLine();


Product secondBook = new Product("Io, robot", "Il libro che ha venduto milioni di copie", 150, 22);

Console.WriteLine("Nome del secondo libro: " + secondBook.Name);
Console.WriteLine("Descrizione: " + secondBook.Description);
Console.WriteLine("Prezzo: " + secondBook.Price + "€");
Console.WriteLine("Iva: " + secondBook.Iva + "%");
Console.WriteLine("Prezzo tassato: " + secondBook.GetTaxedPrice());
Console.WriteLine("Codice: " + secondBook.Code);
Console.WriteLine("Nome con codice: " + secondBook.GetFullName());
Console.WriteLine("Codice completo: " + secondBook.GetFullCode());
