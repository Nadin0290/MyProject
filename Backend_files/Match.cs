using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Match
    {
        List<Team> playing_teams = new List<Team>();
        List<string> Mathess = new List<string>();
        bool Is_FinalEnds = false;
        Team Team1_Winner;
        Team Team2_Winner;

        int tmp_score1;
        int tmp_score2;
        public void Add_match(Team team1, Team team2)
        {
            Console.WriteLine($"Now playing {team1.Teams_Name} and {team2.Teams_Name}");


            if (team1.IsPLaying == true || team2.IsPLaying == true)
            {
                throw new Exception("Team is playing now!");
            }

            team1.IsPLaying = true;
            team2.IsPLaying = true;

            if (playing_teams.Contains(team1) || playing_teams.Contains(team2))
            { }
            else
            {
                playing_teams.Add(team1);
                playing_teams.Add(team2);
            }

            Random r1 = new();
            Random r2 = new();


            int score1 = r1.Next(0, 5);
            int score2 = r2.Next(0, 5);

            tmp_score1 = score1;
            tmp_score2 = score2;


            if (tmp_score1 > tmp_score2)
            {
                team1.Winner = true;
                team2.Winner = false;
            }


            else if (tmp_score1 == tmp_score2)
            {
                team1.IsPLaying = false;
                team2.IsPLaying = false;
                Console.WriteLine($"Friendship won between {team1.Teams_Name} and {team2.Teams_Name} ({ tmp_score1 }:{ tmp_score2 })\n");
                Console.ReadLine();
                Add_match(team1, team2);
            }
            else
            {
                team2.Winner = true;
                team1.Winner = false;
            }

            Console.WriteLine($"Результат матча:\n{team1.Teams_Name}/{team2.Teams_Name}({tmp_score1}:{tmp_score2})\n");

            Mathess.AddRange(new string[] { $"{team1.Teams_Name}/{ team2.Teams_Name }({ tmp_score1 }:{ tmp_score2 })" });
        }
        public void Match_Info(Team team1, Team team2)
        {
            Console.WriteLine($"Результат матча:\n{team1.Teams_Name}/{team2.Teams_Name}({tmp_score1}:{tmp_score2})\n");
        }

        public void Win_Teams()
        {
            int i;
            for (i = 0; i < playing_teams.Count; i++)
            {
                if (playing_teams[i].Winner == true)
                {
                    Team1_Winner = playing_teams[i];
                    break;
                }

            }

            for (int k = i + 1; k < playing_teams.Count; k++)
            {
                if (playing_teams[k].Winner == true)
                {
                    Team2_Winner = playing_teams[k];
                    break;
                }

            }


            Console.WriteLine($"We have 2 finalists : {Team1_Winner.Teams_Name} and {Team2_Winner.Teams_Name}");

        }

        public void Final()
        {
            if (Team1_Winner.Winner != true && Team2_Winner.Winner != true)
            {
                throw new Exception("We can't make a final without all matches!");
            }


            Random r1 = new();
            Random r2 = new();

            int score1 = r1.Next(0, 5);
            int score2 = r2.Next(0, 5);

            tmp_score1 = score1;
            tmp_score2 = score2;

            if (tmp_score1 > tmp_score2)
            {
                Team1_Winner.Winner = true;
                Team2_Winner.Winner = false;

            }


            else if (tmp_score1 == tmp_score2)
            {
                Team1_Winner.Winner = true;
                Team2_Winner.Winner = true;

            }
            else
            {
                Team2_Winner.Winner = true;
                Team1_Winner.Winner = false;

            }



            Console.WriteLine($"Результат матча:\n{Team1_Winner.Teams_Name}/{Team2_Winner.Teams_Name}({tmp_score1}:{tmp_score2})");
            Mathess.AddRange(new string[] { $"{Team1_Winner.Teams_Name}/{ Team2_Winner.Teams_Name }({ tmp_score1 }:{ tmp_score2 })" });
        }
        public void Close_Final()
        {
            if (!Is_FinalEnds)
            {
                throw new Exception("Can't close final without results");
            }
            foreach (var team in playing_teams)
            {
                team.IsPLaying = false;
                team.Winner = false;
            }
        }
        public void Results()
        {

            if (Team1_Winner.Winner != true && Team2_Winner.Winner != true)
            {
                throw new Exception("We can't show results without final!");
            }
            else if (Team1_Winner.Winner == true && Team2_Winner.Winner == true)
            {
                Console.WriteLine("Friendship won!");
                Team1_Winner.Winner = false;
                Team2_Winner.Winner = false;
            }
            if (Team2_Winner.Winner == true)
            {
                Console.WriteLine($"Our WINNER IS {Team2_Winner.Teams_Name}!!!");
            }
            else if (Team1_Winner.Winner == true)
            {
                Console.WriteLine($"Our WINNER IS {Team1_Winner.Teams_Name}!!!");
            }

            Is_FinalEnds = true;
        }
        public void Get_PLayingTeams()
        {
            foreach (var team in playing_teams)
            {
                if (team.IsPLaying)
                    Console.WriteLine(team.Teams_Name);
            }

        }

        public void History()
        {
            foreach (var Match in Mathess)
            {
                Console.WriteLine(Match);
            }
        }
        public void Announcments()
        {
            if (!Is_FinalEnds)
            {
                //throw new Exception("No announcments, teams are tired");
                Console.WriteLine("Match has already started");
            }
            else
            {
                Output addition_info = new();
                Team[] randomTeams = addition_info.RandomTeams();

                Console.WriteLine("Future matches:");
                Console.WriteLine($"{randomTeams[0].Teams_Name}/{randomTeams[1].Teams_Name}");
                Console.WriteLine($"{randomTeams[2].Teams_Name}/{randomTeams[3].Teams_Name}");


            }
            //Console.WriteLine("Future matches soon!");
        }

    }
}
