using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.TaskSport
{
    internal class TestSportApp
    {
        public static void Test1()
        {

            Console.WriteLine("Test 1 - champions league mock");
            Season[] groups = CreateChampionsLeagueMock();

            for (int i = 0; i < groups.Length; i++)
            {
                groups.DisplayTable();
            }

        }
        public static Season[] CreateChampionsLeagueMock()
        {
            Season[] groups = new Season[4];

            //your code come here
            Team bayern = new Team("Bayern", "Bayern");








            return groups;



        }

    }
}
