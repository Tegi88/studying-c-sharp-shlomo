using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studying_c_sharp_shlomo.TaskSport
{
    public class Team
    {
        private string name;
        private string city;
        private string currentLige;
        private int sumGames;
        private int gamesPlay;
        private int wins;
        private int lose;
        private int tiko;
        private int points;
        private int goalsFor;
        private int goalAgainst;

        
        public Team(string name, string city)
        {
            this.name = name;
            this.city = city;
            this.currentLige = "";
            this.sumGames = 0;
            this.gamesPlay = 0;
            this.wins = 0;
            this.lose = 0;
            this.tiko = 0;
            this.points = 0;
            this.goalsFor = 0;
            this.goalAgainst = 0;
        }
        public void SetName(string name)
        {
             this.name=name;
        }
        public string GetName() { return this.name; }

        public void SetCity(string city)
        {
            this.city = city;
        }
        public string GetCity() { return this.city; }

        public void SetCurrentLige(string currentLige)
        {
            this.currentLige = currentLige;
        }
        public string GetCurrentLige() { return this.currentLige; }


    }
}
