using LogicLayer;
using System;
using System.ComponentModel.Design;


namespace ConsoleGUI1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Magenta ; // BYTER FÄRG PÅ CONSOLE!!! WOOOOOO
            Console.WriteLine("Välkommen till schemaadministration!");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Skapa ett nytt schema");
            Console.WriteLine("2. Visa befintliga scheman");
            Console.WriteLine("3. Avsluta applikationen");
            Console.Write("Ditt val?: ");
            string val = Console.ReadLine();

            switch (val) // Use the input value for switching
            {
                case "1":
                    Affärslager.HyraFordon(); // Call the static method from the Affärslager class
                    break;

                case "2":
                    Affärslager.VisaBetalningsmetod();
                    break; 

                case "3":
                    break;

            }
         }

    }
}

