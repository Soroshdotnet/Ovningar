using System;
using System.ComponentModel.Design;

namespace Övning_2_Flow_Control
{
    internal class Program
    {
        private static int length;

        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till övning 2 Flow Control!");
            // 1.Berätta för användaren att de har kommit till huvudmenyn och de kommer navigeragenom att skriva in siffror för att testa olika funktioner.
            // Metod PrintMenu
            PrintMenu();

            //2.Skapa skalet till en Switch-sats som till en början har Två Cases.Ett för ”0” somstänger ner programmet och ett default som berättar att det är felaktig input.
            do //enoändlig iteration, bool med tillhörande while-loop.
            {
                string menuInput = Console.ReadLine(); //Läser menyval
                switch (menuInput) //Switch Huvudmeny
                {
                    case "1": //Menyval 1
                        AgeCheck();

                        /**************
                         **UNDERMENYN**
                         **************/
                        Console.WriteLine("_____________________________");
                        Console.WriteLine("UNDERMENY VÄLJ ETT ALTERNATIV");
                        Console.WriteLine("1: Beräkna sällskap");
                        Console.WriteLine("0: Tillbaka");

                        string menu2 = Console.ReadLine(); //Läser input undermeny

                        if (menu2 == "1")
                        {
                            Console.Write("Ange antal personer: ");
                            int lenght = int.Parse(Console.ReadLine());
                            int[] antalPers = new int[lenght];
                            RäknaSällskap(antalPers); //Metod

                        }

                        else if (menu2 == "0")
                            break;

                        else Console.WriteLine("Error");
                        break;




                    /***************************/

                    case "2":
                        TenTimes();
                        break;

                    case "3":
                        TredjeOrdet();
                        break;

                    case "4":

                      
                        
                        break;

                    case "0": //Exit program
                        Environment.Exit(0);
                        break;
                    default: //Felmeddelande
                        Console.WriteLine("\nError!");
                        break;
                }



                Console.Write("\n\nVad vill du göra nu?"); //Uppmanar användare till nytt menyval
                PrintMenu();

            } while (true);

        }


        private static void RäknaSällskap(int[] persAge)
        {

            //prisListor
            List<int> vuxen = new List<int>();
            List<int> ungdom = new List<int>();
            List<int> elder = new List<int>();

            for (int i = 0; i < persAge.Length; i++)
            {
                Console.Write($"Ange ålder person {i + 1}: ");
                int ageInput = int.Parse(Console.ReadLine());
                persAge[i] = ageInput;

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
                    vuxen.Add(ageInput);
                    Console.WriteLine("Standardpris: 120kr");
                }
            }

            for (int i = 0; i < persAge.Length; i++)
            {
                Console.WriteLine($"Angivna ålder person {i + 1}:\t{persAge[i]} år");

            }

            Console.WriteLine("\nAntal Vuxna: " + vuxen.Count + "\nAntal Ungdom: " + ungdom.Count + "\nAntal Pensionär: " + elder.Count);

            //Priser
            int prisVuxen = vuxen.Count() * 120;
            int prisUngdom = ungdom.Count() * 80;
            int prisElder = elder.Count() * 90;

            Console.Write("\nSumma Vuxen: " + prisVuxen + " Kr.");
            Console.Write("\nSumma Ungdom: " + prisUngdom + " Kr.");
            Console.Write("\nSumma Pensionär: " + prisElder + " Kr.");

            Console.Write("\nTotal summa: " + (prisElder+prisUngdom+prisVuxen) + " Kr.");

        }


        private static void AgeCheck()
        {
            Console.WriteLine("Ange ålder: ");
            int age = int.Parse(Console.ReadLine()); // Läser inmatning och konverterar detta från en sträng till en int
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


        private static void TenTimes()
        {
            Console.Write("Skriv något: ");
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
            var phrase = Console.ReadLine();
            var words = phrase.Split(" ");
            if (words.Length > 2)
                Console.Write("Det tredje ordet i din mening är: " + words[2]);
            else
                Console.WriteLine("Du måste skriva minst 3 ord");
        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n_____________________________");
            Console.WriteLine("HUVUDMENY VÄLJ EN FUNKTION");
            
            Console.WriteLine("\nNavigera genom sifferval + Enter\n");

            Console.WriteLine("Menyval 1: Ungdom eller pensionär" +
                "\n             Undermeny 1:1: Beräkna sällskap");
            Console.WriteLine("Menyval 2: Upprepa tio gånger");
            Console.WriteLine("Menyval 3: Det tredje ordet");

            Console.WriteLine("Menyval 0: Avsluta programmet");

            Console.Write("\nVälj: ");
                      
        }
    }
}