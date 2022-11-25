using Övning_5_Garage_1._0;

/* Comments:
Garage klass
Vehicle array
    Flygplan
    Moped
    Bil
    Buss
    Båt    
Sök Vehicle array
Presentera garage
Printa meny
*/

namespace Övning_5__Garage_1._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till Garaget 1.0");

            ChooseCapacity();

            PrintGarage();
            
            PrintMenu();

            do
            {
                string menuInput = Console.ReadLine();
                switch (menuInput)
                {
                    case "1":
                        AddVehicle();
                         break;

                    case "2":
                        RemoveVehicle();
                        break;

                    case "3":
                        SearchVehicle();
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

        private static void PrintGarage()
        {
            //ToDo: Print Array from Garage class
            Garage garage = new Garage();
            Console.WriteLine(garage.Fordon);
        }

        private static void ChooseCapacity()
        {
            Console.WriteLine("\nVälj kapacitet på garaget: \nKapacitet skapad. Välj åtgärd från menyn nedan: \n");
        }

        private static void AddVehicle()
        {

            ////Test klass
            //Vehicle vehicle = new Vehicle();
            //vehicle.AirPlane = Console.ReadLine();
            //Console.WriteLine(vehicle.AirPlane);
        }

        private static void RemoveVehicle()
        {
            // throw new NotImplementedException();
        }

        private static void SearchVehicle()
        {
           // throw new NotImplementedException();
        }
        private static void PrintMenu()
        {
            Console.WriteLine("HUVUDMENY: VÄLJ EN ÅTGÄRD");
            Console.WriteLine("Menyval 1: ");
            Console.WriteLine("Menyval 2: ");
            Console.WriteLine("Menyval 3: ");
            Console.WriteLine("Menyval 0: Avsluta programmet");
            Console.Write("\nNavigera genom sifferval sedan tryck Enter: ");
        }
    } 
}