﻿using System;
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

                            //Console.Write("Ange antal personer: ");
                            //int lenght = int.Parse(Console.ReadLine());
                            //int[] antalPers = new int[lenght];
                            //RäknaSällskap(antalPers); //Metod

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
                            Console.Write(". " + x10);
                        }
                        break;

                    case "3":

                    //Händelseförloppet förklaras nedan: 1.
                    //Användaren anger en mening med minst 3 ord
                    //2.Programmet delar upp strängen med split - metoden på varje mellanslag
                    //3.Programmet plockar ut den tredje strängen(ordet) ur input
                    //4.Programmet skriver ut den tredje strängen(ordet)

                        Console.Write("Skriv en mening över 3 ord: ");
                        var phrase = Console.ReadLine();
                        var words = phrase.Split(" ");

                        Console.Write("Det tredje ordet i din mening är: " + words[2]);
                        
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

            //prisListor
            List<int> standard = new List<int>(120);
            List<int> ungdom = new List<int>(80);
            List<int> elder = new List<int>(90);

            //prisKlasser (arrays)
            //int[] ungdom = new int[80];
            //int[] standard = new int[120];
            //int[] elder = new int[90];

            for (int i = 0; i < antalPers.Length; i++)
            {
                Console.Write($"Ange ålder person {i + 1}: ");
                int age2 = int.Parse(Console.ReadLine());
                antalPers[i] = age2;

                if (age2 <= 20)
                {
                    ungdom.Add(age2);
                    Console.WriteLine("Ungdomspris: 80kr");
                }
                else if (age2 >= 64)
                {
                    elder.Add(age2);
                    Console.WriteLine("Pensionärspris: 90kr");
                }
                else
                {
                    standard.Add(age2);
                    Console.WriteLine("Standardpris: 120kr");
                }
            }

            for (int i = 0; i < antalPers.Length; i++)
            {
                Console.WriteLine($"Angivna ålder person {i + 1}:\t{antalPers[i]} år");

                Console.WriteLine("\nAntal Vuxna: " + standard.Count + "\nAntal Ungdom: " + ungdom.Count + "\nAntal Pensionär: " + elder.Count);

                Console.WriteLine("Total summa: ");
                Console.WriteLine("");

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