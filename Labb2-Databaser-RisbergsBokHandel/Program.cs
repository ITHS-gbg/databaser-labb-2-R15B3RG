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
        new Option("Pappersdrömmar", () => Pappersdrömmar()),
        new Option("Ordens Rike", () =>  OrdensRike()),
        new Option("Bokstavliga äventyr", () =>  BokstavligaÄventyr()),
        new Option("Bladvändarbutiken", () =>  BladvändarButiken()),
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

    static void WriteMenu(List<Option> options, Option selectedOption)
    {
        Console.Clear();

        Console.WriteLine("Välkommen till den mysiga bokhandelns databas!\nVälj vilken butik du vill kolla:\n");

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

void Pappersdrömmar()
{

    List<Option> options;

    options = new List<Option>

    {
        new Option("Se lagersaldot", () => ListaLagersaldo(1)),
        new Option("Lägg till böcker", () =>  AddBooks(1)),
        new Option("Ta bort böcker", () =>  RemoveBooks(1)),
        new Option("Gå till huvudmenyn", () =>  Mainmenu()),
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

    void WriteMenu(List<Option> options, Option selectedOption)
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(1)?.StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

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

    Pappersdrömmar();

}

void OrdensRike()
{

    List<Option> options;

    options = new List<Option>

    {
        new Option("Se lagersaldot", () => ListaLagersaldo(2)),
        new Option("Lägg till böcker", () =>  AddBooks(2)),
        new Option("Ta bort böcker", () =>  RemoveBooks(2)),
        new Option("Gå till huvudmenyn", () =>  Mainmenu()),
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

    void WriteMenu(List<Option> options, Option selectedOption)
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(2)?.StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

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

    OrdensRike();
}

void BokstavligaÄventyr()
{

    List<Option> options;

    options = new List<Option>

    {
        new Option("Se lagersaldot", () => ListaLagersaldo(3)),
        new Option("Lägg till böcker", () =>  AddBooks(3)),
        new Option("Ta bort böcker", () =>  RemoveBooks(3)),
        new Option("Gå till huvudmenyn", () =>  Mainmenu()),
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

    void WriteMenu(List<Option> options, Option selectedOption)
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(3)?.StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

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

    BokstavligaÄventyr();
}

void BladvändarButiken()
{

    List<Option> options;

    options = new List<Option>

    {
        new Option("Se lagersaldot", () => ListaLagersaldo(4)),
        new Option("Lägg till böcker", () =>  AddBooks(4)),
        new Option("Ta bort böcker", () =>  RemoveBooks(4)),
        new Option("Gå till huvudmenyn", () =>  Mainmenu()),
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

    void WriteMenu(List<Option> options, Option selectedOption)
    {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGreen;

        var store = db.Butikers.Find(4)?.StoreName;

        Console.WriteLine($"{store.ToUpper()}\n");

        Console.ResetColor();

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

void ListaLagersaldo(int storeId)
{

    Console.Clear();

    Console.ForegroundColor = ConsoleColor.DarkGreen;

    var store = db.Butikers.Find(storeId).StoreName;

    Console.WriteLine($"{store.ToUpper()}\n");

    Console.ResetColor();

    var saldo = db.LagerSaldos
        .Include(s => s.Store)
        .Include(s => s.IsbnNavigation)
        .Where(s => s.StoreId == storeId).ToList();

    Console.WriteLine("Böcker i butiken:".ToUpper() + "\n");

    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("-----------------------------------------------------------------");
    Console.ResetColor();
    Console.WriteLine("\n");

    foreach (var stock in saldo)
    {
        Console.WriteLine($"Titel: {stock.IsbnNavigation.Title}");
        Console.WriteLine($"Saldo: {stock.Quantity}");
        Console.WriteLine($"ISBN: {stock.Isbn}");


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Författare: {stock.IsbnNavigation.FörfattareFirstName} {stock.IsbnNavigation.FörfattareLastName}");

        Console.ResetColor();

        Console.WriteLine("\n");

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("-----------------------------------------------------------------");
        Console.ResetColor();

        Console.WriteLine("\n");

        
    }

    Console.WriteLine("'ENTER' för att återgå till menyn");
    Console.ReadKey();
    Console.Clear();
    Mainmenu();
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
    Mainmenu();
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
    Mainmenu();
}

