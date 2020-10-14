using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {

            Kunder kund = new Kunder();
            kund.name = "Bertil";

            //lyckades ej få bok namn att fungera. Bokens namn är private men försökte göra den public via GetName() men lyckades ej
            // Kommenterar därför bort koden så att error ej uppstår, men jag lämnar kvar koden här den så du kan se mitt fel

            /* 
            Böcker bok = new Böcker();
            bok.GetName() = "Sagan om ringen";
            */

            Console.WriteLine("Hello " + kund.name + " and welcome to the shop!");



        }
    }
}
