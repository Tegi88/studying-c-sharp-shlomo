using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.TaskSport
{
    public class Season
    {
        private int year;
        private string brunchGame;
        private string ligeName;
        private int roundesAmount;
        private Round nextRounde;
        private Team[] teams;
        private bool played;

        public void SetTeams(Team[] teams)
        {
            this.teams = teams;
        }

    }


    
}
