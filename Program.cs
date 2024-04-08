using System;
using System.Collections.Generic;

class Program
{
    // Liste der Personen anlegen
    static List<string[]> listePersonen = new List<string[]>();

    static void Main(string[] args)
    {
        // Startwerte für Personenliste
        string[] startPerson1 = { "Jürgen", "Marek", "50", "0664534256355" };
        listePersonen.Add(startPerson1);
        string[] startPerson2 = { "Werner", "Huber", "25", "06767678636355" };
        listePersonen.Add(startPerson2);
        string[] startPerson3 = { "Anita", "Meier", "33", "038426763673" };
        listePersonen.Add(startPerson3);
        string[] startPerson4 = { "Maria", "Galler", "27", "0699674635267" };
        listePersonen.Add(startPerson4);

        bool exit = false;
        while (!exit)
        {
            // Hapumenü anzeigen
            Console.WriteLine("Hauptmenü:");
            Console.WriteLine("1___Person anlegen");
            Console.WriteLine("2___Personen nach Alter anzeigen");
            Console.WriteLine("3___Alle Personen anzeigen");
            Console.WriteLine("4___Programm beenden");

            Console.Write("Wählen Sie eine Option: ");
            string auswahlHauptmenü = Console.ReadLine();

            switch (auswahlHauptmenü)
            {
                case "1":
                    if (listePersonen.Count < 10)
                        personAnlegen();
                    else
                        Console.WriteLine("Die maximale Anzahl von 10 Personen wurde erreicht!");
                    Console.WriteLine("Drücken Sie eine Taste, um zurück ins Hauptmenü zu gelangen.");
                    Console.ReadKey();
                    break;
                case "2":
                    personenNachAlterAnzeigen();
                    break;
                case "3":
                    allePersonenAnzeigen();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe, bitte geben Sie einen Wert von 1 - 4 ein!");
                    break;
            }
        }
    }

    static void personAnlegen()
    {
        Console.Write("Vorname: ");
        string vorname = Console.ReadLine();
        Console.Write("Nachname: ");
        string nachname = Console.ReadLine();
        Console.Write("Alter: ");
        int alter = int.Parse(Console.ReadLine());
        Console.Write("Telefonnummer: ");
        string telefonnummer = Console.ReadLine();

        string[] person = { vorname, nachname, alter.ToString(), telefonnummer };
        listePersonen.Add(person);

        Console.WriteLine("Person hinzugefügt.");
        Console.WriteLine("Drücken Sie eine Taste, um zurück ins Hauptmenü zu gelangen.");
        Console.ReadKey();
    }

    static void personenNachAlterAnzeigen()
    {
        Console.Write("Bis zu welchem Alter möchten Sie die Personen angezeigt bekommen? ");
        int maximalesAlter = int.Parse(Console.ReadLine());

        Console.WriteLine($"Personen bis zum Alter von {maximalesAlter}:");

        foreach (string[] person in listePersonen)
        {
            int age = int.Parse(person[2]);
            if (age <= maximalesAlter)
            {
                Console.WriteLine($"{person[0]} {person[1]}, {person[2]} Jahre, Telefonnummer: {person[3]}");
            }
        }

        Console.WriteLine("Drücken Sie eine Taste, um zurück ins Hauptmenü zu gelangen.");
        Console.ReadKey();
    }

    static void allePersonenAnzeigen()
    {
        Console.WriteLine("Alle Personen:");

        foreach (string[] person in listePersonen)
        {
            Console.WriteLine($"{person[0]} {person[1]}, {person[2]} Jahre, Telefonnummer: {person[3]}");
        }

        Console.WriteLine("Drücken Sie eine Taste, um zurück ins Hauptmenü zu gelangen.");
        Console.ReadKey();
    }
}
