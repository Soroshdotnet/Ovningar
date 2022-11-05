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


                   



                            /* ToDo: Beräkna sällsak i undermenyn
                            
                            Initisiera prisklasser för att kunna beräkna sällskap
                         
                            Kolla lista och arrays.
                            Antal pers
                            Ålder per pers -> ger pris per person

                            fråga antal personer
                            skriv ut personer
                            fråga ålder per person
                            ange prisklass per person
                            summera totalet
                             */

                            


                            
                            //string prisKlass = Console.ReadLine();
                            //Console.Write("Ange ålder för varje person: ");

                        }
                        else if (menu2 == "0")
                            break;
                        else Console.WriteLine("Error");
                        break;
                    /***************************/



                    case "2":
                        Console.Write("Skriv något: ");
                        string x10 = Console.ReadLine();
                        Console.Write("\nResultat: ");
                        for (int index = 0; index < 10; index++)
                        {
                            Console.Write(x10);
                        }
                        break;








                    // ToDo: Menyval 3: Det tredje ordet
                    case "3":

                        Console.WriteLine("Menyval 3: Det tredje ordet kommer snart");

                        break;







                    case "4":

                        /*TEST 
                        Beräkna sällskap - Flyttas till Case 1:1 */
                        Console.Write("Ange antal personer: ");
                        int lenght = int.Parse(Console.ReadLine());
                        int[] antalPers = new int[lenght];
                        RäknaSällskap(antalPers); //Metod









                        //List<int> antalPersList = new List<int>();
                        //Console.Write("Ange antal personer: ");
                        //int lenght = int.Parse(Console.ReadLine());
                        //for (int i = 0; i < length; i++)
                        //{
                        //    Console.Write($"Ange ålder person {i + 1}: ");
                        //    int age2 = int.Parse(Console.ReadLine());
                        //    antalPersList.Add(age2);
                        //}


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

        private static void RäknaSällskap(int[] antalPers)
        {
            int[] ungdom = new int[antalPers.Length];
            int[] standard = new int[antalPers.Length];
            int[] elder = new int[antalPers.Length];

            for (int i = 0; i < antalPers.Length; i++)
            {
                Console.Write($"Ange ålder person {i + 1}: ");
                int age2 = int.Parse(Console.ReadLine());
                antalPers[i] = age2;

                if (age2 <= 20)
                {
                    ungdom[i] = age2;
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age2 >= 64)
                {
                    elder[i] = age2;
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    standard[i] = age2;
                    Console.WriteLine("Standardpris: 120kr");
                }
            }

            for (int i = 0; i < antalPers.Length; i++)
            {
                Console.WriteLine($"Angivna ålder person {i + 1}:\t{antalPers[i]} år");

            }

        }

        private static void PrintMenu()
        {
            Console.WriteLine("\n_____________________________");
            Console.WriteLine("HUVUDMENY VÄLJ EN FUNKTION");
            
            Console.WriteLine("\nNavigera genom sifferval + Enter");

            Console.WriteLine("Menyval 1: Ungdom eller pensionär");
            Console.WriteLine("Menyval 2: Upprepa tio gånger");
            Console.WriteLine("Menyval 3: Det tredje ordet");
            Console.WriteLine("Menyval 4: Test");

            Console.WriteLine("Menyval 0: Avsluta programmet");

            Console.Write("\nVälj: ");
                      
        }
    }
}