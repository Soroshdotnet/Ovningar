using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3_Inkapsling_arv_och_polymorfism
{
    public class Person
    {

        private int ageField;
        private string fNameField;
        private string lNameField;
        private int heightField;
        private int weightField;

        public int Age 
        {
            get => ageField;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age cannot be negative.");
                }
                ageField = value;
            }
        }
        //ageField
        //Fungerar***
        // 
        public Person(int age = 0)
        {
            //ageField = age;

            //Console.WriteLine("Ange ålder: ");
            //int ageField = Convert.ToInt32(Console.ReadLine());
            //int[] age = { 10, 7 };
           // foreach (var value in values)
           //ToDo: Validering
            //{
            //    try
            //    {
                    
            //        Console.WriteLine("Age: " + age + "\n ageField: " + ageField);
            //    }
            //    catch (ArgumentException)
            //    {
            //        Console.WriteLine("Minsuvärde");
            //    }
            //    Console.WriteLine();
            //}

            //    try
            //{
            //    Console.WriteLine("Ange ålder");
            //    int ageField = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("Age: " + age +" \nageField: " + ageField );



            //}
            //catch
            //{
            //    Console.WriteLine("Minusvärde");
            //}



            //if (age > 0)
            //{
            //    Console.WriteLine(age);
            //}
            //else
            //{
            //    Console.WriteLine("Minusvärde");
            //}



            // public string age { get; set; }
            // private int ageField; //{ get; set; }
            // private int ageObj = new Person();
            //public int PersonId { get; private set; }
            //public int age { get; set; }


            //** Auto-implemented properties
            //public string age { get; set; }

            //** klass propertie(?)
            //private int _age;
            //public int age
            //{
            //get
            //{
            //    return _age;
            //}
            //set
            //{
            //    _age = value;
            //}
            //
        }
    }
}
