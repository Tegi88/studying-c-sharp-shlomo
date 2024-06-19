using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.TaskSport
{
    public class Game
    {
        private Team a;
        private Team b;
        private int sumGoalsTeamA;
        private int sumGoalsTeamB;
        private double currentMinites;
        private bool gamePlay;

        

        public Game(Team a, Team b, bool gamePlay)
        {
            this.a = a;
            this.b = b;
            this.sumGoalsTeamA = 0;
            this.sumGoalsTeamB = 0;
            this.currentMinites = 0;
            this.gamePlay = gamePlay;
        }

        public void SetTeamA(Team team)
        {
            this.a = team;
        }
        public Team GetTeamA() { return this.a;}
        public void SetTeamB(Team team)
        {
            this.b = team;
        }
        public Team GetTeamB() { return this.b; }


        public void SetSumGoalsTeamA(int sumGoalsTeamA)
        {
            this.sumGoalsTeamA = sumGoalsTeamA;
        }
        public int GetSumGoalsTeamA() { return this.sumGoalsTeamA; }

        public void SetSumGoalsTeamB(int sumGoalsTeamB)
        {
            this.sumGoalsTeamB = sumGoalsTeamB;
        }
        public int GetSumGoalsTeamB() { return this.sumGoalsTeamB; }

        public void SetcurrentMinites(int currentMinites)
        {
            this.currentMinites = currentMinites;
        }
        public double GetcurrentMinites() { return this.currentMinites; }

        public void SetgamePlay(bool gamePlay)
        {
            this.gamePlay = gamePlay;
        }
        public bool GetgamePlay() { return this.gamePlay; }

    }
}
