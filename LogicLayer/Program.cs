using ClassLibrary1;
using LogicLayer;
using System;
using System.ComponentModel.Design;


namespace GUI
{
    class Program
    {
        static void Main(string[] args) //Metod för in/utloggningsmeny.
        {
            Console.Title = "Utloggat läge";

            Console.ForegroundColor = ConsoleColor.Red; //byter färg på text.
            bool ärInloggad= Affärslager.Login(); //bekräftar inlogg via LogIn metod.

            if (ärInloggad)
            {
                Console.WriteLine();
                Menu(); //Huvudmenyn för inloggat läge visas om användare är inloggad i enlighet med LogIn metoden.
            }
            else
            { Console.WriteLine("Inloggning misslyckades. Försök igen"); } //Om inlogg misslyckas ges denna utskrift.

            //Lägga in metod för registrering här?
        }
        //Definierar vilken meny som visas.
        public static void Menu()
        {
            Affärslager.Meny(); //Kallar på metoden Meny från affärslagret.

            Console.ReadLine();
        }
        }

    }


