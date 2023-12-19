using System.Collections;
using System.Collections.Generic;
using Labb2_Databaser_RisbergsBokHandel;
using Labb2_Databaser_RisbergsBokHandel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;


var db = new RisbergsMysigaBokhandelContext();

Mainmenu();

void Mainmenu()
{

    List<Option> options;

    options = new List<Option>

    {
        new Option("Se Lagersaldo", () => ListaLagersaldo()),
        new Option("Hantera Lagersaldo", () =>  HanteraLagersaldo()),
        new Option("Avsluta", () => Environment.Exit(0)),
    };

    int index = 0;

    WriteMenu(options, options[index]);

    ConsoleKeyInfo keyinfo;
    do
    {
        keyinfo = Console.ReadKey();

        if (keyinfo.Key == ConsoleKey.DownArrow)
        {
            if (index + 1 < options.Count)
            {
                index++;
                WriteMenu(options, options[index]);
            }
        }
        if (keyinfo.Key == ConsoleKey.UpArrow)
        {
            if (index - 1 >= 0)
            {
                index--;
                WriteMenu(options, options[index]);
            }
        }
        
        if (keyinfo.Key == ConsoleKey.Enter)
        {
            options[index].Selected.Invoke();
            index = 0;
        }
    }
    while (keyinfo.Key != ConsoleKey.X);

    Console.ReadKey();

    static void WriteMenu(List < Option > options, Option selectedOption)
    {
        Console.Clear();

        Console.WriteLine("Välkommen till den mysiga bokhandelns databas!\nVälj ett av nedanstående alternativ:\n");

        foreach (Option option in options)
        {
            if (option == selectedOption)
            {
                Console.Write("-> ");
            }
            else
            {
                Console.Write(" ");
            }

            Console.WriteLine(option.Name);
        }
    }

}

void HanteraLagersaldo()
{
    Console.Clear();

    Console.WriteLine("Välj vilken butik du vill justera ditt lagersaldo i: \n");

    foreach (var butik in db.Butikers)
    {
        Console.WriteLine($"{butik.Id} - {butik.StoreName} \n");
    }

    Console.WriteLine("För att återgå till huvudmenyn, tryck ENTER");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();
        Pappersdrömmar();
    }
    else if (input == "2")
    {
        Console.Clear();
        OrdensRike();
    }
    else if (input == "3")
    {
        Console.Clear();
        BokstavligaÄventyr();
    }
    else if (input == "4")
    {
        Console.Clear();
        BladvändarButiken();
    }
    else
    {
        Console.Clear();
        Mainmenu();
    }


}

void Pappersdrömmar()
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    var store = db.Butikers.Find(1).StoreName;

    Console.WriteLine($"{store.ToUpper()}\n");

    Console.ResetColor();

    Console.WriteLine("Välj att lägga till eller ta bort böcker ur lagersaldot:\n" +
                      "\n 1. Lägg till"
                      + "\n 2. Ta bort"
                      + "\n 3. Föregående meny"
                      + "\n 4. Återgå till huvudmeny");

    string input = Console.ReadLine();

    if (input == "1")
    {
        AddBooks(1);
    }

    else if (input == "2")
    {
        RemoveBooks(1);
    }
    else if (input == "3")
    {
        Console.Clear();
        HanteraLagersaldo();
    }
    else if (input == "4")
    {
        Console.Clear();
        Mainmenu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt menyval. Försök igen!");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        Pappersdrömmar();
    }

}

void OrdensRike()
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    var store = db.Butikers.Find(2).StoreName;

    Console.WriteLine($"{store.ToUpper()}\n");

    Console.ResetColor();

    Console.WriteLine("Välj att lägga till eller ta bort böcker ur lagersaldot:\n" +
                      "\n 1. Lägg till"
                      + "\n 2. Ta bort"
                      + "\n 3. Föregående meny"
                      + "\n 4. Återgå till huvudmeny");

    string input = Console.ReadLine();

    if (input == "1")
    {
        AddBooks(2);
    }
    else if (input == "2")
    {
        RemoveBooks(2);
    }
    else if (input == "3")
    {
        Console.Clear();
        HanteraLagersaldo();
    }
    else if (input == "4")
    {
        Console.Clear();
        Mainmenu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt menyval. Försök igen!");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        OrdensRike();
    }
}

void BokstavligaÄventyr()
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    var store = db.Butikers.Find(3).StoreName;

    Console.WriteLine($"{store.ToUpper()}\n");

    Console.ResetColor();

    Console.WriteLine("Välj att lägga till eller ta bort böcker ur lagersaldot:\n" +
                      "\n 1. Lägg till"
                      + "\n 2. Ta bort"
                      + "\n 3. Föregående meny"
                      + "\n 4. Återgå till huvudmeny");

    string input = Console.ReadLine();

    if (input == "1")
    {
        AddBooks(3);
    }
    else if (input == "2")
    {
        RemoveBooks(3);
    }
    else if (input == "3")
    {
        Console.Clear();
        HanteraLagersaldo();
    }
    else if (input == "4")
    {
        Console.Clear();
        Mainmenu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt menyval. Försök igen!");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        BokstavligaÄventyr();
    }
}

void BladvändarButiken()
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    var store = db.Butikers.Find(4).StoreName;

    Console.WriteLine($"{store.ToUpper()}\n");

    Console.ResetColor();

    Console.WriteLine("Välj att lägga till eller ta bort böcker ur lagersaldot:\n" +
                      "\n 1. Lägg till"
                      + "\n 2. Ta bort"
                      + "\n 3. Föregående meny"
                      + "\n 4. Återgå till huvudmeny");

    string input = Console.ReadLine();

    if (input == "1")
    {
        AddBooks(4);
    }
    else if (input == "2")
    {
        RemoveBooks(4);
    }
    else if (input == "3")
    {
        Console.Clear();
        HanteraLagersaldo();
    }
    else if (input == "4")
    {
        Console.Clear();
        Mainmenu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt menyval. Försök igen!");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        BladvändarButiken();
    }
}

void ListaLagersaldo()
{
    Console.Clear();

    Console.WriteLine("Välj butik: \n");

    foreach (var butik in db.Butikers)
    {
        Console.WriteLine($"{butik.Id} - {butik.StoreName}");
    }
    
    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(1).StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

        var saldo = db.LagerSaldos
            .Include(s => s.Store)
            .Include(s => s.IsbnNavigation)
            .Where(s => s.StoreId == 1).ToList();

        Console.WriteLine("Böcker i butiken:".ToUpper() + "\n");

        foreach (var stock in saldo)
        {
            Console.WriteLine($"Titel: {stock.IsbnNavigation.Title} \nSaldo: {stock.Quantity}\nISBN: {stock.Isbn}\n");
        }

        Console.ReadKey();
        Console.Clear();
        Mainmenu();

    }
    else if (input == "2")
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(2).StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

        var saldo = db.LagerSaldos
            .Include(s => s.Store)
            .Include(s => s.IsbnNavigation)
            .Where(s => s.StoreId == 2).ToList();

        Console.WriteLine("Böcker i butiken:".ToUpper() + "\n");

        foreach (var stock in saldo)
        {
            Console.WriteLine($"Titel: {stock.IsbnNavigation.Title} \nSaldo: {stock.Quantity}\nISBN: {stock.Isbn}\n");
        }

        Console.ReadKey();
        Console.Clear();
        Mainmenu();
    }
    else if (input == "3")
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(3).StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

        var saldo = db.LagerSaldos
            .Include(s => s.Store)
            .Include(s => s.IsbnNavigation)
            .Where(s => s.StoreId == 3).ToList();

        Console.WriteLine("Böcker i butiken:".ToUpper() + "\n");

        foreach (var stock in saldo)
        {
            Console.WriteLine($"Titel: {stock.IsbnNavigation.Title} \nSaldo: {stock.Quantity}\nISBN: {stock.Isbn}\n");
        }

        Console.ReadKey();
        Console.Clear();
        Mainmenu();
    }
    else if (input == "4")
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(4).StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

        var saldo = db.LagerSaldos
            .Include(s => s.Store)
            .Include(s => s.IsbnNavigation)
            .Where(s => s.StoreId == 4).ToList();

        Console.WriteLine("Böcker i butiken:".ToUpper() + "\n");

        foreach (var stock in saldo)
        {
            Console.WriteLine($"Titel: {stock.IsbnNavigation.Title} \nSaldo: {stock.Quantity}\nISBN: {stock.Isbn}\n");
        }

        Console.ReadKey();
        Console.Clear();
        Mainmenu();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Felaktigt menyval. Du omdirigeras till huvudmenyn.");
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();
        Mainmenu();
    }
}

void AddBooks(int storeId)
{

    Console.Clear();

    Console.WriteLine("Ange bokdetaljer för att lägga till:\n");

    Console.Write("ISBN: ");
    if (long.TryParse(Console.ReadLine(), out long isbn))
    {
        Console.Write("Ange kvantitet:\n");
        if (int.TryParse(Console.ReadLine(), out int quantityToAdd))
        {
            // Use the DbContext to find the existing book and stock entry for the specified store
            var existingBook = db.Böckers.FirstOrDefault(b => b.Isbn == isbn);
            var existingStock = db.LagerSaldos.FirstOrDefault(s => s.StoreId == storeId && s.Isbn == isbn);

            if (existingBook != null)
            {
                if (existingStock != null)
                {
                    // Update the quantity in the existing stock
                    existingStock.Quantity += quantityToAdd;
                }
                else
                {
                    // Create a new stock entry for the specified store
                    var newStock = new LagerSaldo()
                    {
                        StoreId = storeId,
                        Isbn = isbn,
                        Quantity = quantityToAdd
                    };

                    db.LagerSaldos.Add(newStock);
                }

                db.SaveChanges();

                Console.WriteLine($"{quantityToAdd}st utav {existingBook.Title} har lagts till!");
            }
            else
            {
                Console.WriteLine("Boken fanns ej i databasen.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltig kvantitet.");
        }
    }
    else
    {
        Console.WriteLine("Ogiltig ISBN.");
    }

    Console.ReadKey();
    Console.Clear();
    HanteraLagersaldo();
}

void RemoveBooks(int storeId)
{

    Console.Clear();

    Console.WriteLine("Ange bokdetaljer för att ta bort:\n");

    Console.Write("ISBN: ");
    if (long.TryParse(Console.ReadLine(), out long isbn))
    {
        Console.Write("Ange kvantitet:\n");
        if (int.TryParse(Console.ReadLine(), out int quantityToRemove))
        {
            // Use the DbContext to find the existing book and stock entry for the specified store
            var existingBook = db.Böckers.FirstOrDefault(b => b.Isbn == isbn);
            var existingStock = db.LagerSaldos.FirstOrDefault(s => s.StoreId == storeId && s.Isbn == isbn);

            if (existingBook != null)
            {
                if (existingStock != null)
                {
                    // Update the quantity in the existing stock
                    existingStock.Quantity -= quantityToRemove;
                }
                else
                {
                    // Create a new stock entry for the specified store
                    var newStock = new LagerSaldo()
                    {
                        StoreId = storeId,
                        Isbn = isbn,
                        Quantity = quantityToRemove
                    };

                    db.LagerSaldos.Remove(newStock);
                }

                db.SaveChanges();

                Console.WriteLine($"{quantityToRemove}st utav {existingBook.Title} har blivit borttaget!");
            }
            else
            {
                Console.WriteLine("Boken fanns ej i databasen.");
            }
        }
        else
        {
            Console.WriteLine("Ogiltig kvantitet.");
        }
    }
    else
    {
        Console.WriteLine("Ogiltig ISBN.");
    }

    Console.ReadKey();
    Console.Clear();
    HanteraLagersaldo();
}

