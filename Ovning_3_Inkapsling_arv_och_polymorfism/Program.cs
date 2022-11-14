namespace Ovning_3_Inkapsling_arv_och_polymorfism
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //F: Instansiera en person i Program.cs, kommer du direkt åt variablerna?
            //S: Nej jag kommer inte åt fält/variabler i Klassen Person om det inte skapas en publik konstruktor/metod i klassen(?)

            var ph = new PersonHandler();
            try
            {
                //Person person = new Person();
                //person.Age = -1;
                var person = ph.CreatePerson("Vad är", "detta?", 40, 40, 40);
                ph.SetAge(person, -20);

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }

            var ph2 = new PersonHandler();
            try
            {
                var person = ph.CreatePerson("Det kan", "Stå olika", 40, 40, 40);
                ph.SetFirstName(person, "Fööörrnnaaamnn");

            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
                     
            
            var ph3 = new PersonHandler();
            try
            {
                var person = ph.CreatePerson("Här", "och här", 40, 40, 40);
                ph.SetLastName(person, "Efternaaaammnnnnnnnnn");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }










        }
    }
}