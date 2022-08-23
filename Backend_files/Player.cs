using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Player
    {
        Team team_of_player;
        bool Is_Player_InTeam;
        string Name;
        int ID;
        List<int> ids = new List<int>();

        public Player(string Name)
        {
            Random r = new();
            ID = r.Next(1, 100);
            if (ids.Contains(ID))
            { }
            else
            {
                ids.Add(ID);
            }
            this.Name = Name;
        }
        public void Set_Team(Team team)
        {
            if (Is_Player_InTeam)
            {
                throw new Exception("Player has already in team!");
            }
            team_of_player = team;
            Is_Player_InTeam = true;
            team.players_obj.Add(this);
        }
        public void Exit_Team()
        {
            Is_Player_InTeam = false;
        }

        public void Get_Info_of_player()
        {
            if (Is_Player_InTeam)
                Console.WriteLine($"Игрок {Name} находится в {team_of_player.Teams_Name}");
            else
                Console.WriteLine($"Игрок {Name} свободен");
        }
        public int ID_Player
        {
            get
            {
                return ID;
            }
        }
        public string Get_Name
        {
            get
            {
                return Name;
            }
        }


    }
}
