using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Output
    {
        Player Player_1 = new("Криштиану Роналду 7");
        Player Player_2 = new("Родриго Бентакур 30");
        Player Player_3 = new("Уэстон Маккенни 14");
        Player Player_4 = new("Альваро Мората 9");
        Player Player_5 = new("Френки де Йонг 21");
        Player Player_6 = new("Родриго Бентакур 30");
        Player Player_7 = new("Усман Дембеле 11");
        Player Player_8 = new("Рикард Путч 28");
        Player Player_9 = new("Карлес Аленья 9");
        Player Player_10 = new("Родриго Бентакур 30");
        Player Player_11 = new("Уэстон Маккенни 14");




        Player Player_12 = new("Лионель Месси 10");
        Player Player_13 = new("Антуан Гризман 7");
        Player Player_14 = new("Мартин Брейтуэйт 19");
        Player Player_15 = new("Френки де Йонг 21");
        Player Player_16 = new("Усман Дембеле 11");
        Player Player_17 = new("Рикард Путч 28");
        Player Player_18 = new("Карлес Аленья 9");
        Player Player_19 = new("Карим Бензема 13");
        Player Player_20 = new("Мариано Диас 24");
        Player Player_21 = new("Эден Азар 7");
        Player Player_22 = new("Карфи Немо 18");



        Player Player_23 = new("Жуниор Мораес 19");
        Player Player_24 = new("Роман Яремчук 9");
        Player Player_25 = new("Артем Довбик 16");
        Player Player_26 = new("Френки де Йонг 21");
        Player Player_27 = new("Николай Шапаренко 10");
        Player Player_28 = new("Рикард Путч 28");
        Player Player_29 = new("Александр Зубков 15");
        Player Player_30 = new("Георгий Бущан 1");
        Player Player_31 = new("Мариано Диас 24");
        Player Player_32 = new("Александр Зинченко 17");
        Player Player_33 = new("Николай Шапаренко 14");




        Player Player_34 = new("Френки де Йонг 19");
        Player Player_35 = new("Усман Дембеле 11");
        Player Player_36 = new("Рикард Путч 28");
        Player Player_37 = new("Френки де Йонг 21");
        Player Player_38 = new("Родриго Бентакур 30");
        Player Player_39 = new("Рикард Путч 28");
        Player Player_40 = new("Карлес Аленья 9");
        Player Player_41 = new("Френки де Йонг 22");
        Player Player_42 = new("Карим Бензема 13");
        Player Player_43 = new("Эден Азар 7");
        Player Player_44 = new("Мариано Диас 24");


        Team[] teams = {
            new Team("Ювентус", "Италия"), new Team("Барселона", "Испания"),
            new Team("Динамо", "Украина"), new Team("Реал Мадрид", "Испания")
        };

        public void Set_Players()
        {
            Player_1.Set_Team(teams[0]);
            //Player_1.Exit_Team();
            Player_2.Set_Team(teams[0]);
            Player_3.Set_Team(teams[0]);
            Player_4.Set_Team(teams[0]);
            Player_5.Set_Team(teams[0]);
            Player_6.Set_Team(teams[0]);
            Player_7.Set_Team(teams[0]);
            Player_8.Set_Team(teams[0]);
            Player_9.Set_Team(teams[0]);
            Player_10.Set_Team(teams[0]);
            Player_11.Set_Team(teams[0]);



            Player_12.Set_Team(teams[1]);
            Player_13.Set_Team(teams[1]);
            Player_14.Set_Team(teams[1]);
            Player_15.Set_Team(teams[1]);
            Player_16.Set_Team(teams[1]);
            Player_17.Set_Team(teams[1]);
            Player_18.Set_Team(teams[1]);
            Player_19.Set_Team(teams[1]);
            Player_20.Set_Team(teams[1]);
            Player_21.Set_Team(teams[1]);
            Player_22.Set_Team(teams[1]);


            Player_23.Set_Team(teams[2]);
            Player_24.Set_Team(teams[2]);
            Player_25.Set_Team(teams[2]);
            Player_26.Set_Team(teams[2]);
            Player_27.Set_Team(teams[2]);
            Player_28.Set_Team(teams[2]);
            Player_29.Set_Team(teams[2]);
            Player_30.Set_Team(teams[2]);
            Player_31.Set_Team(teams[2]);
            Player_32.Set_Team(teams[2]);
            Player_33.Set_Team(teams[2]);



            Player_34.Set_Team(teams[3]);
            Player_35.Set_Team(teams[3]);
            Player_36.Set_Team(teams[3]);
            Player_37.Set_Team(teams[3]);
            Player_38.Set_Team(teams[3]);
            Player_39.Set_Team(teams[3]);
            Player_40.Set_Team(teams[3]);
            Player_41.Set_Team(teams[3]);
            Player_42.Set_Team(teams[3]);
            Player_43.Set_Team(teams[3]);
            Player_44.Set_Team(teams[3]);
        }

        private void Play_Game()
        {
            Console.WriteLine("To play game press Enter");
            Console.ReadLine();
        }
        private void Continue()
        {
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
        private void Get_Info_Of_Current_TEAM()
        {
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("Все команды: ");
                foreach (var team in teams)
                {
                    Console.WriteLine(team.Teams_Name);
                }
                Console.WriteLine("Введите навзание команды: ");
                string cur_choice = Console.ReadLine();

                foreach (var Team in teams)
                {
                    if (Team.Teams_Name == cur_choice)
                    {
                        flag = false;
                        Team.Get_FullInfo();
                    }
                }

                
            }
        }

        Match mathes = new();


        public Team[] RandomTeams()
        {
            Random r = new();

            Team[] randomTeams = new Team[4];

            List<Team> checkList = new List<Team>();


            foreach (var item in teams)
            {

                checkList.Add(item);

            }

            for (int i = 0; i < 4; i++)
            {

                int check = r.Next(checkList.Count);
                randomTeams[i] = checkList[check];
                checkList.RemoveAt(check);
            }


            return randomTeams;

        }
        public void Get_Info_About_CurrentPlayer()
        {
            for (int i = 0; i < teams.Length; i++)
            {
                foreach (var player in teams[i].players_obj)
                {
                    Console.WriteLine($"Player: {player.Get_Name} ID: {player.ID_Player}\n");

                }

            }
            bool flag = true;
            while (flag)
            {
                int cur_id;
                Console.Write("Введите ID игрока: ");
                string strcur_id = Console.ReadLine();
                int.TryParse(strcur_id, out cur_id);
                //int cur_ID = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < teams.Length; i++)
                {
                    foreach (var player in teams[i].players_obj)
                    {

                        if (cur_id == player.ID_Player)
                        {
                            flag = false;
                            player.Get_Info_of_player();
                            break;
                        }


                    }


                }
                if (flag == true)
                {
                    Console.WriteLine("Такого игрока нет!");
                }

            }



        }
        public void Make_Tournament()
        {

            Team[] randomTeams = RandomTeams();

            mathes.Add_match(randomTeams[0], randomTeams[1]);
            mathes.Add_match(randomTeams[2], randomTeams[3]);

            Play_Game();
            mathes.Win_Teams();
            Continue();
            mathes.Final();
            mathes.Results();
            mathes.Close_Final();
        }
        public void Start()
        {
            Set_Players();
            bool flag = true;
            while (flag)
            {
                Console.Clear();
                Console.WriteLine("-------Клуб футбольных фанатов-------");
                Console.WriteLine("----------Меню Фаната----------");
                Console.Write("\nУзнать больше о командах - Узнать\n" +
                "Узнать состав текущей команды - Команды\n" +
                "Узнать информацию о игроке - Игроки\n" +
                "Сезонные игры - Игры\n" +
                "Попасть в журнал - Журнал\n" +
                "Закончить программу - Закрыть\n");

                string Currrent_Choice = Console.ReadLine();

                switch (Currrent_Choice)
                {
                    case "Узнать":
                        Console.Clear();
                        Console.WriteLine("\nСписок команд: ");
                        foreach (Team team in teams)
                            team.Get_FullInfo();
                        Continue();
                        break;

                    case "Команды":
                        Get_Info_Of_Current_TEAM();
                        Continue();
                        break;

                    case "Игры":
                        Console.Clear();
                        Console.WriteLine("----Турнир Европы----");
                        Make_Tournament();
                        Continue();
                        break;

                    case "Игроки":
                        Console.WriteLine("Все игроки: ");
                        Get_Info_About_CurrentPlayer();
                        Continue();
                        break;

                    case "Закрыть":
                        flag = false;
                        break;

                    case "Журнал":
                        bool flag2 = true;
                        while (flag2)
                        {
                            Console.Clear();
                            Console.WriteLine("-------Клуб футбольных фанатов-------");
                            Console.WriteLine("----------Меню Журнал----------");
                            Console.Write("Узнать историю матчей - История\n" +
                            "Узнать Анонсы матчей в этом году - Анонсы\n" +
                            "Выйти в главное меню - Выйти\n");

                            string Currrent_Choice_inMenu2 = Console.ReadLine();

                            switch (Currrent_Choice_inMenu2)
                            {

                                case "Анонсы":
                                    Console.WriteLine();
                                    mathes.Announcments();
                                    Continue();
                                    break;

                                case "История":
                                    Console.WriteLine();
                                    mathes.History();
                                    Continue();
                                    break;

                                case "Выйти":
                                    flag2 = false;
                                    break;
                            }



                        }
                        break;

                }
            }

        }
    }
}
