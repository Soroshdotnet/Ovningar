using Microsoft.Win32;

namespace Övning1_Personalregister

//    "Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet personalregister. De har endast två krav:
//    1.Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatningi konsolen, inget krav på persistent lagring)
//    2.Programmet skall kunna skriva ut registret i en konsol."
//
//    Uppgift 1 Vilka klasser bör ingå i programmet?
//    - Jag tror en klass program räcker.
//
//    Uppgift 2 Vilka attribut och metoder bör ingå i dessa klasser?
//    - En metod för inhämtning av strängar och en metod för inhämting av intiger. 
//
//    Uppgift 3 Skriv programmet.

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // VÄLKOMNAR ANVÄNDARE
            Console.WriteLine("\nVälkommen till personalregister!");
            Console.WriteLine("Välj ett alternativ mellan 1 - 4 och tryck Enter.");

            //SKRIV UT MENY
            Console.WriteLine("\n[1] Lägg till anställd");
            Console.WriteLine("[2] Visa register.");
            Console.WriteLine("[3] Rensa personalregister.");
            Console.WriteLine("[4] Avsluta");
            Console.Write("\nVälj: ");

            //STRÄNGVARIABLE SPARAR DATA FRÅN ANVÄNDARE (MENYVAL 1) input

            string namn = "";
            string lön = "";

            /* === WHILE LOOP OCH KODBLOCK FÖR SWITCH MENY, KÖR PROGRAMMET I EN LOOP === */
            while (true)
            {
                //LÄSER MENYVAL
                string menyVal = Console.ReadLine();

                /* === SWITCH I WHILELOPP, STRUKTURERAR MENYVAL === */
                switch (menyVal)
                {
                    //MENYVAL 1 - SPARA INNEHÅLL FRÅN ANVÄNDARE
                    case "1":
                        Console.Write("Ange fullständigt namn för anställd: ");
                        namn = Console.ReadLine();

                        Console.Write("Ange personallön: ");
                        lön = Console.ReadLine();

                        //BEKRÄFTAR ÅTGÄRD
                        Console.WriteLine("Sparad!");

                        //AVSLUTAR MENYVAL
                        break;

                    //MENYVAL 2 - VISAR INNEHÅLL SPARAD I STRÄNGVARIABEL input  
                    case "2":
              
                        Console.WriteLine("Anställda: " + namn + " har " + lön + " kr i lön.");
                        break;

                    //MENYVAL 3 - TÖMMER PERSONALREGISTRET
                    case "3":
                        namn = "";
                        lön = "";

                        //BEKRÄFTAR ÅTGÄRD
                        Console.WriteLine("Personalregistret är tomt");
                        break;

                    //MENYVAL 4 - BRYTER SWITCH LOPPEN
                    case "4":
                        break;

                    //FELMEDDELANDE
                    default:
                        Console.WriteLine("Tyvärr, allternativet finns inte. Välj mellan 1 - 4.");
                        break;
                }

                //MENYVAL 4 - BRYTER WHILE LOPPEN - LÄMNAR KONSOLEN
                if (menyVal == "4")
                    break;

                //FRÅGAR ANVÄNDARE EFTER NÄSTA MENYVAL
                else
                    Console.WriteLine("Vad vill du göra nu?");
            }

        }

    }
}