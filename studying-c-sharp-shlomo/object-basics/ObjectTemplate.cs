using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.object_basics
{
    public class ObjectTemplate
    {
        
        public string stringName = "Shlomo";
        public string stringLastName = "Tagaya";
        public int intAge = 36;
        public bool male = false;
    }

    public class ChekPersone
    {
        public static void Person()
        {
            ObjectTemplate person1= new ObjectTemplate();

            Console.WriteLine("personFirstName= {0}, personLasttName= {1}, personAge= {2}, personGendeMan= {3}",
                person1.stringName, person1.stringLastName, person1.intAge, person1.male);


            person1.stringName = "David";
            person1.stringLastName = "Dor";
            person1.intAge = 44;
            person1.male = true;

            Console.WriteLine("personFirstName= {0}, personLasttName= {1}, personAge= {2}, personGendeMan= {3}",
                person1.stringName, person1.stringLastName, person1.intAge, person1.male);
        }
    }
}
