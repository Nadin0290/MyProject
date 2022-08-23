using System;
using System.Collections.Generic;

namespace MyLibrary
{
    public class Team
    {
        string Team_Name;
        string Country;
        bool isPlaying;
        bool Win;


        public List<Player> players_obj = new List<Player>();
        public Team(string Team_Name, string Country)
        {
            this.Team_Name = Team_Name;
            this.Country = Country;
            isPlaying = false;
            Win = false;
        }

        public void Get_FullInfo()
        {
            Console.WriteLine($"\nКоманда: {Team_Name}\nСтрана: {Country}");

            Console.WriteLine($"Игроки:\n ");
            foreach (var player in players_obj)
            {
                Console.WriteLine(player.Get_Name);
            }
            Console.WriteLine();
        }


        public bool IsPLaying
        {
            get
            {
                return isPlaying;
            }
            set
            {
                isPlaying = value;
            }

        }

        public bool Winner
        {
            get
            {
                return Win;
            }
            set
            {
                Win = value;
            }
        }

        public string Teams_Name
        {
            get
            {
                return Team_Name;
            }
            set
            {
                Team_Name = value;
            }
        }


    }

}
