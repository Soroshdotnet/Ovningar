using System;

namespace Övning_2_Flow_Control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till SF Bio!");
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

                            //ToDo: Beräkna sällsak i undermenyn

                            /*
                             * Initisiera prisklasser
                             * 
                             * /


                            /*
                             Kolla lista och arrays.
                            Antal pers
                            Ålder per pers -> ger pris per person * antal

                            fråga antal personer
                            skriv ut personer
                            fråga ålder per person
                            räkna prisklass x antal
                             
                             */


                            //string antal = Console.ReadLine();
                            //Console.Write("Ange antal personer: ");

                            //string pers = Console.ReadLine();
                            //Console.Write("Ange ålder för varje person: ");


                            //Console.Write("Ange antal personer: ");



                        }
                        else if (menu2 == "0")
                            break;
                        else Console.WriteLine("Error");
                        break;
                    /***************************/





                    case "2":

                        //ToDo: Skapa foor loop 
                        Console.Write("Skriv något: ");
                        int x10 = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nResultat");
                        for (int i = 0; i < x10; i++)
                        {
                            x10 = x10 * i;

                            Console.Write(x10);
                        }

                        break;







                    case "0": //Exit program
                        Environment.Exit(0);
                        break;
                    default: //Felmeddelande
                        Console.WriteLine("\nError!");
                        break;
                }



                Console.Write("\nVad vill du göra nu?"); //Uppmanar användare till nytt menyval
                PrintMenu();

            } while (true);

        }

        private static void PrintMenu()
        {
            Console.WriteLine("\nNavigera genom sifferval + Enter");

            Console.WriteLine("Menyval 1: Ungdom eller pensionär");
            Console.WriteLine("Menyval 2: Upprepa tio gånger");
            Console.WriteLine("Menyval 0: Avsluta programmet");

            Console.Write("\nVälj: ");

        }
    }
}