using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingCards
{
    internal class PlayerData
    {
        public int ID;
        public string Name;
        public String Photo;
        public int GoalsScored;
        public int Number;
        public string Position;
        public string Team;
        public string HomeTown;
        public DateTime Birthdate;
        public int Age;
        public string Height;
        public string Weight;
        public PlayerData(int ID, string Name, String Photo, int GoalsScored,  int Number, string Position, string Team, string HomeTown, DateTime Birthdate, int Age, string Height, string Weight)
        {
            this.ID = ID;
            this.Name = Name;
            this.Photo = Photo;
            this.GoalsScored = GoalsScored;
            this.Number= Number;
            this.Position = Position;
            this.Team = Team;
            this.HomeTown = HomeTown;
            this.Birthdate = Birthdate.Date;
            this.Age = Age;
            this.Height = Height;
            this.Weight = Weight;

        }

      
    }
}
