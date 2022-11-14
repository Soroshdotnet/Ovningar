using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning_3_Inkapsling_arv_och_polymorfism
{
    internal class PersonHandler
    {

        public Person CreatePerson(string fname, string lname, int age, int height, int weight)
        {
            Person person = new Person();
            person.Age = age;
            person.Fname = fname;
            person.Lname = lname;
            
            // gör samma sak för resten av properties
            return person;  

        }

        public void SetAge(Person person, int age)
        {
            person.Age = age;
        }

        public void SetFirstName(Person person, string fname)
        {
            person.Fname = fname;
        }
        public void SetLastName(Person person, string lname)
        {
            person.Lname = lname;
        }


    }
}
