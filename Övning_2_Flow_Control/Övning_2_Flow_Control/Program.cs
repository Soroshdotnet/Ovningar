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
            Console.WriteLine("--------------------------------------\n" + "Välkommen till övning 2 Flow Control!"+ "\n--------------------------------------");

            PrintMenu();

            do 
            {
                string menuInput = Console.ReadLine();
                switch (menuInput) 
                {
                    case "1": 
                        //Hantera metod AgeCheck
                        //Sedan skriv ut Undermeny
                        // OM RäknaSällskap > Hantera metod
                        // ANNARS tillbaka till Hvudmeny

                        AgeCheck();

                        //UNDERMENYN 1:1
                        Console.WriteLine("_____________________________");
                        Console.WriteLine("UNDERMENY VÄLJ ETT ALTERNATIV");
                        Console.WriteLine("1: Beräkna sällskap");
                        Console.WriteLine("0: Tillbaka");

                        //Läser input undermeny
                        string menu2 = Console.ReadLine(); 

                        if (menu2 == "1") //om menyval 1:1 påbörja beräkning av sällskap

                        /*
                         * Hämtar antal personer
                         * Hämtar ålder per person
                         * Sparar personer i respektive kundgrupper (vuxen, ung, elder, free)
                         * Kalkylerar pris per kundgrupp
                         * Summerar pris för kundgrupp
                         */
                        {   //Hämtar antal och omvandlar sträng till int
                            //Array för att spara antal personer
                            //Metod beräkna sällskap
                            Console.Write("Ange antal personer sedan tryck Enter: ");
                            int lenght = int.Parse(Console.ReadLine());
                            int[] antalPers = new int[lenght];
                            RäknaSällskap(antalPers);
                        }
                     
                        else if (menu2 == "0")
                            break;

                        else Console.WriteLine("Error");                               
                            break;

                    case "2":
                        TenTimes(); 
                        break;

                    case "3":
                        TredjeOrdet(); 
                        break;

                    case "0": 
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("\nError!");
                        break;
                }

                //Uppmanar användare till nytt menyval
                Console.Write("\n--------------------" +
                    "\nVad vill du göra nu?\n--------------------\n"); 
                
                PrintMenu();

            } while (true);
        }
        private static void AgeCheck()
        {
            Console.Write("Ange ålder: ");
            int age = int.Parse(Console.ReadLine()); 
            
            // Läser inmatning och konverterar detta från en sträng till en int
            //Programmet selecterar om personen är ungdom (under 5 år eller över 100)
            //Programmet selecterar om personen är ungdom (under 20 år)
            //4.Om det ovanstående är sant skall programmet skriva ut: Ungdomspris: 80kr
            //5.Annars kollar programmet om personen är en pensionär (över 64 år)
            // 6.Om ovanstående är sant skall programmet skruva ut: Pensionärspris: 90kr
            // skriva ut: Standardpris: 120kr
            //ANNARS ovanstående inte stämmer skriv ut Gratis 

            if (age >= 6 && age <= 99)
            {
                if (age <= 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr"); 
                }
                else if (age >= 64) 
                {
                    Console.WriteLine("Pensionärspris: 90kr"); 
                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr"); 
                }
            }
            else 
            {
                Console.WriteLine("Gratis Entré!");
            }
        }
        private static void RäknaSällskap(int[] persAge)
        {
            //Kundgrupper i listor
            List<int> standard = new List<int>();
            List<int> ungdom = new List<int>();
            List<int> elder = new List<int>();
            List<int> free = new List<int>();

            for (int i = 0; i < persAge.Length; i++) // Loopar lika många gånger som det finns element i array 
            {

                //Hämtar ålder per element
                //omvandlar sträng till int
                //sparar ålder per element/person
                Console.Write($"Ange ålder person {i + 1}: "); 
                int ageInput = int.Parse(Console.ReadLine()); 
                persAge[i] = ageInput;

                //Selecterar indata till listor kundgrupper
                // OM mellan 5 - 100 år gör nedan
                //OM under 20 år lägg i lista ungdom
                //ANNARS OM över 64 år
                //Lägg i lista elder
                //ANNARS mellan 20 - 64 år
                //Lägg i lista standard
                //ANNARS under 5 år eller över 100 år
                //Placsera i listan free

                if (ageInput >= 6 && ageInput <= 99)
                {
                    if (ageInput <= 20)
                    {
                        ungdom.Add(ageInput); 
                        Console.WriteLine("Ungdomspris: 80kr");
                    }
                    else if (ageInput >= 64) 
                    {
                        elder.Add(ageInput);
                        Console.WriteLine("Pensionärspris: 90kr");
                    }
                    else 
                    {
                        standard.Add(ageInput);
                        Console.WriteLine("Standardpris: 120kr");
                    }
                }
                else 
                {
                    free.Add(ageInput); 
                    Console.WriteLine("Gratis Entré!");
                }
            }

            Console.WriteLine("\n//////////////////////////////\n" + "/////  SUMMERING SF BIO  /////" + "\n//////////////////////////////");
            //Loppar genom personer och skriver ut angivna ålder
            for (int i = 0; i < persAge.Length; i++)
            {
                Console.WriteLine($"Angivna ålder person {i + 1}:\t{persAge[i]} år");
            }     
            
            //Skriver ut antal personer i varje kundgrupp i listor
            Console.WriteLine("\nAntal Vuxna: " + 
                standard.Count + "\nAntal Ungdom: " + 
                ungdom.Count + "\nAntal Pensionär: " + 
                elder.Count + "\nFria platser: " + 
                free.Count) ;

            //Multipicerar antal element i varje lista med priset för varje kundgrupp
            int prisVuxen = standard.Count() * 120;
            int prisUngdom = ungdom.Count() * 80;
            int prisElder = elder.Count() * 90;
            int prisFree = free.Count() * 0;

            //Skriver ut priset för varje krundgrupp/lista
            Console.Write("\nSumma Vuxna: " + prisVuxen + " Kr");
            Console.Write("\nSumma Ungdom: " + prisUngdom + " Kr");
            Console.WriteLine("\nSumma Pensionär: " + prisElder + " Kr");
            Console.WriteLine("Fria platser: " + prisFree + " Kr\n");

            //Summerar antal personer och kostnad per person
            Console.Write("Total personer: " + (standard.Count + ungdom.Count + elder.Count + free.Count));
            Console.Write("\nTotal summa: " + (prisElder+prisUngdom+prisVuxen) + " Kr\n");
        }
        private static void TenTimes()
        {
            //Sparar sträng i variabel x10
            //Loppar index 10 gånger
            //Skriver ut ordet varje loop

            Console.Write("Skriv något sedan tryck Enter: ");
            string x10 = Console.ReadLine(); 
            Console.Write("\nResultat: ");
            for (int index = 0; index < 10; index++) 
            {
                Console.Write(x10+ ". "); 
            }
        }
        private static void TredjeOrdet()
        {
            //Läser sträng och sparar i variabel phrase
            //Delar upp sträng för varje mellanslag och placerar i array variabel words.
            //om array innheåller 3 eller fler element ->
            //Skriv ut tredje ordet 

            Console.Write("Skriv en mening över 3 ord: ");
            var phrase = Console.ReadLine(); 
            var words = phrase.Split(" ", StringSplitOptions.RemoveEmptyEntries); 
            if (words.Length > 2) 
                Console.Write("Det tredje ordet i din mening är: " + words[2]); 
            else //undantagshantering
                Console.WriteLine("ERROR. Du måste skriva minst 3 ord!");
        }
        private static void PrintMenu() //Huvudmeny
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