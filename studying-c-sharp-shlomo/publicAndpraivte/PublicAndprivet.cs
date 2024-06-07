using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.publicAndpraivte
{
    public class PublicAndprivet
    {
        private string name = "shlomo";
        public int age = 36;

        public PublicAndprivet (string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string GetName() { return name; }
        public void SetName(string name) { this.name = name;}
    }

    public class Change
    {
        
        public static void ChangeName()
        {
            PublicAndprivet gg = new PublicAndprivet("david",22);
            Console.WriteLine(gg.GetName());
            gg.SetName("avi");
            Console.WriteLine(gg.GetName());
        }

    }
}
