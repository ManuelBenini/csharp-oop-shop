
Console.OutputEncoding = System.Text.Encoding.UTF8;


Product firstBook = new Product();

firstBook.SetName("Do Androids Dream About Electric Sheeps?");
firstBook.SetDescription("Il libro che ha ispirato Blade Runner!");
firstBook.SetPrice(50);
firstBook.SetIva(22);


Console.WriteLine("Nome del primo libro: " + firstBook.GetName());
Console.WriteLine("Descrizione: " + firstBook.GetDescription());
Console.WriteLine("Prezzo: " + firstBook.GetPrice() + "€");
Console.WriteLine("Iva: " + firstBook.GetIva() + "%");
Console.WriteLine("Prezzo tassato: " + firstBook.GetTaxedPrice());
Console.WriteLine("Codice: " + firstBook.GetCode());
Console.WriteLine("Nome con codice: " + firstBook.GetFullName());
Console.WriteLine("Codice completo: " + firstBook.GetFullCode());


int terminalWidth = Console.WindowWidth;
int terminalheight = Console.WindowHeight;

Console.WriteLine();
Console.WriteLine(("").PadRight(terminalWidth, '-'));
Console.WriteLine(("").PadRight(terminalWidth, '-'));
Console.WriteLine();


Product secondBook = new Product("Io, robot", "Il libro che ha venduto milioni di copie", 150, 22);

Console.WriteLine("Nome del secondo libro: " + secondBook.GetName());
Console.WriteLine("Descrizione: " + secondBook.GetDescription());
Console.WriteLine("Prezzo: " + secondBook.GetPrice() + "€");
Console.WriteLine("Iva: " + secondBook.GetIva() + "%");
Console.WriteLine("Prezzo tassato: " + secondBook.GetTaxedPrice());
Console.WriteLine("Codice: " + secondBook.GetCode());
Console.WriteLine("Nome con codice: " + secondBook.GetFullName());
Console.WriteLine("Codice completo: " + secondBook.GetFullCode());