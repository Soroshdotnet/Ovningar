using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3_Inkapsling_arv_och_polymorfism
{
    public class Person
    {

        public int ageField { get; set; }



        // private int ageObject = new Person();




        private string fNameField;
        private string lNameField;
        private int heightField;
        private int weightField;


       


        //public int PersonId { get; private set; }
        //public int age { get; set; }



        //** Auto-implemented properties
        //public string age { get; set; }

        //** klass propertie(?)
        //private int _age;
        //public int age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    set
        //    {
        //        _age = value;
        //    }
        //}


    }
}
