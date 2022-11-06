using System;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Övning_2_Flow_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till övning 2 Flow Control!");
            Console.WriteLine("\n--------------------------\n");

            // Metod PrintMenu
            PrintMenu();

            //2.Skapa skalet till en Switch-sats som till en början har Två Cases.Ett för ”0” somstänger ner programmet och ett default som berättar att det är felaktig input.
            do //enoändlig iteration, bool med tillhörande while-loop.
            {
                string menuInput = Console.ReadLine(); //Läser menyval
                switch (menuInput) //Switch Huvudmeny
                {
                    case "1": //Menyval 1
                        AgeCheck(); //Metod kontrollera pensionär eller ungdom

                        //UNDERMENYN 1:1
                        Console.WriteLine("_____________________________");
                        Console.WriteLine("UNDERMENY VÄLJ ETT ALTERNATIV");
                        Console.WriteLine("1: Beräkna sällskap");
                        Console.WriteLine("0: Tillbaka");
                        string menu2 = Console.ReadLine(); //Läser input undermeny

                        if (menu2 == "1") //om menyval 1:1 påbörja beräkning av sällskap

                        /*
                         * Hämtar antal personer
                         * Hämtar ålder per person
                         * Sparar personer i respektive kundgrupper (vuxen, ung, elder)
                         * Kalkylerar pris per kundgrupp
                         * Summerar pris för kundgrupp
                         */
                        {
                            Console.Write("Ange antal personer sedan tryck Enter: ");
                            int lenght = int.Parse(Console.ReadLine()); //hämtar antal och omvandlar sträng till int
                            int[] antalPers = new int[lenght]; //array för att spara antal personer
                            RäknaSällskap(antalPers); //Metod beräkna sällskap
                        }

                        else if (menu2 == "0") // tillbaka till huvudmenyn
                            break;

                        //Console.Write("Navigera med sifferval sedan tryck Enter: ");

                        else Console.WriteLine("Error"); //Undantagshantering 
                        break;

                    case "2":
                        TenTimes(); // Metod upperpa tio gånger i samma rad
                        break;

                    case "3":
                        TredjeOrdet(); // Metod funktion hitta tredje ordet i en mening
                        break;

                    case "0": //Exit program
                        Environment.Exit(0);
                        break;
                    default: //Felmeddelande
                        Console.WriteLine("\nError!");
                        break;
                }
                Console.Write("\n--------------------" +
                    "\nVad vill du göra nu?\n--------------------\n"); //Uppmanar användare till nytt menyval
                PrintMenu();

            } while (true);
        }
        private static void AgeCheck()
        {
            Console.Write("Ange ålder: ");
            int age = int.Parse(Console.ReadLine()); // Läser inmatning och konverterar detta från en sträng till en int

            if (age >= 6 && age <= 99)//3.Programmet ser om personen är ungdom (under 5 år eller över 100)
            {
                if (age <= 20)//3.Programmet ser om personen är ungdom (under 20 år)
                {
                    Console.WriteLine("Ungdomspris: 80kr"); //4.Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
                }
                else if (age >= 64) //5.Annars kollar programmet om personen är en pensionär (över 64 år)
                {
                    Console.WriteLine("Pensionärspris: 90kr"); // 6.Om ovanstående är sant skall programmet skruva ut: Pensionärspris: 90kr
                }
                else //7.Annars skall programmet
                {
                    Console.WriteLine("Standardpris: 120kr"); // skriva ut: Standardpris: 120kr
                }
            }
            else //3.Programmet ser om personen är ungdom (under 5 år eller över 100)
            {
                Console.WriteLine("Gratis Entré!"); //4.Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
            }
        }
        private static void RäknaSällskap(int[] persAge)
        {
            //Kundgrupper
            List<int> vuxen = new List<int>();
            List<int> ungdom = new List<int>();
            List<int> elder = new List<int>();
            List<int> free = new List<int>();

            for (int i = 0; i < persAge.Length; i++) // Loopar lika många gånger som det finns element i array 
            {
                Console.Write($"Ange ålder person {i + 1}: "); //Hämtar ålder per element
                int ageInput = int.Parse(Console.ReadLine()); //omvandlar sträng till int
                persAge[i] = ageInput; // sparar ålder per element/person


                if (ageInput >= 6 && ageInput <= 99)//3.Programmet ser om personen är ungdom (under 5 år eller över 100)
                {
                    if (ageInput <= 20)//3.Programmet ser om personen är ungdom (under 20 år)
                    {
                        ungdom.Add(ageInput);
                        Console.WriteLine("Ungdomspris: 80kr");
                    }
                    else if (ageInput >= 64) //5.Annars kollar programmet om personen är en pensionär (över 64 år)
                    {
                        elder.Add(ageInput);
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else //7.Annars skall programmet
                    {
                        vuxen.Add(ageInput);
                        Console.WriteLine("Standardpris: 120kr");
                    }
                }
                else //3.Programmet ser om personen är ungdom (under 5 år eller över 100)
                {
                    free.Add(ageInput);
                    Console.WriteLine("Gratis Entré!"); //4.Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
                }
            }

            Console.WriteLine("\n//////////////////////////////\n" +
                "/////  SUMMERING SF BIO  /////" + "\n//////////////////////////////");
            //Loppar genom personer och skriver ut angivna ålder
            for (int i = 0; i < persAge.Length; i++)
            {
                Console.WriteLine($"Angivna ålder person {i + 1}:\t{persAge[i]} år");
            }      
            //Skriver ut antal personer i varje kundgrupp i listor
            Console.WriteLine("\nAntal Vuxna: " + vuxen.Count + "\nAntal Ungdom: " + ungdom.Count + "\nAntal Pensionär: " + elder.Count + "\nFria platser: " + free.Count) ;

            //Multipicerar antal element i varje lista med priset för varje kundgrupp
            int prisVuxen = vuxen.Count() * 120;
            int prisUngdom = ungdom.Count() * 80;
            int prisElder = elder.Count() * 90;
            int prisFree = free.Count() * 0;
            //Skriver ut priset för varje krundgrupp/lista
            Console.Write("\nSumma Vuxna: " + prisVuxen + " Kr");
            Console.Write("\nSumma Ungdom: " + prisUngdom + " Kr");
            Console.WriteLine("\nSumma Pensionär: " + prisElder + " Kr");
            Console.WriteLine("Fria platser: " + prisFree + " Kr\n");

            //Summerar antal personer och kostnad per person
            Console.Write("Total personer: " + (vuxen.Count + ungdom.Count + elder.Count + free.Count));
            Console.Write("\nTotal summa: " + (prisElder+prisUngdom+prisVuxen) + " Kr\n");
        }
        private static void TenTimes()
        {
            Console.Write("Skriv något sedan tryck Enter: ");
            string x10 = Console.ReadLine(); //Sparar sträng i variabel x10
            Console.Write("\nResultat: ");
            for (int index = 0; index < 10; index++) //Loppar index 10 gånger
            {
                Console.Write(x10+ ". "); //Skriver ut ordet varje loop
            }
        }
        private static void TredjeOrdet()
        {
            Console.Write("Skriv en mening över 3 ord: ");
            var phrase = Console.ReadLine(); //Läser sträng och sparar i variabel phrase
            var words = phrase.Split(" "); //Delar upp sträng för varje mellanslag och placerar i array variabel words.
            if (words.Length > 2) //om array innheåller 3 eller fler element ->
                Console.Write("Det tredje ordet i din mening är: " + words[2]); //Skriv ut tredje ordet 
            else //undantagshantering
                Console.WriteLine("ERROR. Du måste skriva minst 3 ord!");
        }
        private static void PrintMenu() // Metod skriver ut menyn
        {
            Console.WriteLine("HUVUDMENY VÄLJ EN FUNKTION");
            Console.WriteLine("Menyval 1: Ungdom eller pensionär" +
                "\n    Undermeny 1:1: Beräkna sällskap");
            Console.WriteLine("Menyval 2: Upprepa tio gånger");
            Console.WriteLine("Menyval 3: Det tredje ordet");
            Console.WriteLine("Menyval 0: Avsluta programmet");
            Console.Write("\nNavigera genom sifferval sedan tryck Enter: ");                   
        }
    }
}