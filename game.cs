using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using battle.Properties;

namespace battle
{
    //ФОРМА ИГРОВОГО ПРОЦЕССА
    public partial class game : Form
    {
        private int first, second, third; //счётчики нажатия на героя

        private readonly string[]
            instructions =
                File.ReadAllText("instructions.txt").Split('\n')
                    .ToArray(); //разбор файла с инструкциями на массив с отдельными инструкциями

        //счётчик ходов
        private int moves = 10;

        private readonly int[]
            pc_heroes = File.ReadAllLines("pc_heroes.txt").Select(x => int.Parse(x))
                .ToArray(); //считывание героев компьютера из файла

        private readonly int[] pc_heroes_health = {8, 8, 8}; //здоровье героев компьютера
        private int pc_move; //выбранная компьютером карта для хода

        private readonly int[] player_heroes =
            File.ReadAllLines("player_heroes.txt").Select(x => int.Parse(x))
                .ToArray(); //считывание героев игрока из файла

        private readonly int[] player_heroes_health = {8, 8, 8}; //здоровье героев игрока

        private int player_move; //выбранная игроком карта для хода

        //победитель
        private readonly int winner = 0; //1 - выиграл игрок, 2 - выиграл компьютер

        public game()
        {
            InitializeComponent();
            player_name.Text = File.ReadAllText("name.txt"); //вывод считанного из файла имени игрока

            //вывод героев на экран
            player_heroes_out(player_heroes, 0, player_0);
            player_heroes_out(player_heroes, 1, player_1);
            player_heroes_out(player_heroes, 2, player_2);
            pc_heroes_out(pc_heroes, 0, pc_0);
            pc_heroes_out(pc_heroes, 1, pc_1);
            pc_heroes_out(pc_heroes, 2, pc_2);
        }

        //МЕТОДЫ ОТОБРАЖЕНИЯ ЭЛЕМЕНТОВ:
        //метод вывода героев компьютера на экран (режим не выбранного)
        public void pc_heroes_out(int[] a, int i, PictureBox pb)
        {
            if (a[i] >= 0 && a[i] < 5)
            {
                Bitmap[] bitmaps = {
                    Resources.swordsman, Resources.armored, Resources.magician,
                    Resources.archer, Resources.invisible
                };
                pb.Image = new Bitmap(bitmaps[a[i]]);
            }
        }

        //метод вывода героев компьютера на экран (режим выбранного)
        public void pc_heroes_out_frame(int[] a, int i, PictureBox pb)
        {
            if (a[i] >= 0 && a[i] < 5)
            {
                Bitmap[] bitmaps = {
                    Resources.swordsman_frame, Resources.armored_frame, Resources.magician_frame,
                    Resources.archer_frame, Resources.invisible_frame
                };
                pb.Image = new Bitmap(bitmaps[a[i]]);
            }
        }

        //метод вывода героев игрока на экран (режим не выбранного)
        public void player_heroes_out(int[] a, int i, Button pb)
        {
            if (a[i] == 0)
                pb.BackgroundImage = new Bitmap(Resources.swordsman);
            else if (a[i] == 1)
                pb.BackgroundImage = new Bitmap(Resources.armored);
            else if (a[i] == 2)
                pb.BackgroundImage = new Bitmap(Resources.magician);
            else if (a[i] == 3)
                pb.BackgroundImage = new Bitmap(Resources.archer);
            else if (a[i] == 4)
                pb.BackgroundImage = new Bitmap(Resources.invisible);
        }

        //метод вывода героев игрока на экран (режим выбранного)
        public void player_heroes_out_frame(int[] a, int i, Button pb)
        {
            if (a[i] == 0)
                pb.BackgroundImage = new Bitmap(Resources.swordsman_frame);
            else if (a[i] == 1)
                pb.BackgroundImage = new Bitmap(Resources.armored_frame);
            else if (a[i] == 2)
                pb.BackgroundImage = new Bitmap(Resources.magician_frame);
            else if (a[i] == 3)
                pb.BackgroundImage = new Bitmap(Resources.archer_frame);
            else if (a[i] == 4)
                pb.BackgroundImage = new Bitmap(Resources.invisible_frame);
        }

        //метод отображения уровня здоровья
        public void show_health(PictureBox health, int[] health_value, int i)
        {
            if (health_value[i] == 8)
                health.Image = new Bitmap(Resources.health_8);
            else if (health_value[i] == 7)
                health.Image = new Bitmap(Resources.health_7);
            else if (health_value[i] == 6)
                health.Image = new Bitmap(Resources.health_6);
            else if (health_value[i] == 5)
                health.Image = new Bitmap(Resources.health_5);
            else if (health_value[i] == 4)
                health.Image = new Bitmap(Resources.health_4);
            else if (health_value[i] == 3)
                health.Image = new Bitmap(Resources.health_3);
            else if (health_value[i] == 2)
                health.Image = new Bitmap(Resources.health_2);
            else if (health_value[i] == 1)
                health.Image = new Bitmap(Resources.health_1);
            else if (health_value[i] < 1)
                health.Image = null;
        }

        //метод стирания героя компьютера с поля, если его убили
        public void hide_pc_hero(int[] health_value, int i, PictureBox hero)
        {
            if (health_value[i] < 1)
                hero.Image = null;
        }

        //метод стирания героя игрока с поля, если его убили
        public void hide_player_hero(int[] health_value, int i, Button hero)
        {
            if (health_value[i] < 1)
            {
                hero.BackgroundImage = null;
                hero.Enabled = false;
            }
        }

        //МЕТОДЫ ПРОВЕРОК:
        //метод проверки победителя
        public int winner_check(int[] player_heroes_health, int[] pc_heroes_health, int winner)
        {
            if (player_heroes_health[0] < 1 && player_heroes_health[1] < 1 && player_heroes_health[2] < 1
            ) //если все герои грока погибли
                winner = 2; //выиграл компьютер
            else if (pc_heroes_health[0] < 1 && pc_heroes_health[1] < 1 && pc_heroes_health[2] < 1
            ) //если все герои компьютера погибли
                winner = 1; //выиграл игрок
            return winner;
        }

        //метод проверки сопоставления события и наличия карты у компьютера
        public int event_card_check(int[] pc_heroes, int hero_number)
        {
            if (pc_heroes[0] == hero_number || pc_heroes[1] == hero_number || pc_heroes[2] == hero_number)
                return pc_move = hero_check(pc_heroes, hero_number, pc_move);
            return pc_move = 0;
        }

        //метод проверки наличия героя в колоде у компьютера
        public int hero_check(int[] pc_heroes, int hero_index, int pc_move)
        {
            if (pc_heroes[0] == hero_index)
                pc_move = 0;
            else if (pc_heroes[1] == hero_index)
                pc_move = 1;
            else if (pc_heroes[2] == hero_index)
                pc_move = 2;
            return pc_move;
        }

        //МЕТОДЫ ВЫБОРА ХОДА:
        //методы выбора игроком героя для хода:
        private void player_0_Click(object sender, EventArgs e)
        {
            first++; //счётчик нажатия на героя

            //режим выбранного
            if (first % 2 == 1)
            {
                if (second % 2 == 1)
                {
                    second++;
                    player_heroes_out(player_heroes, 1, player_1);
                }

                if (third % 2 == 1)
                {
                    third++;
                    player_heroes_out(player_heroes, 2, player_2);
                }

                player_heroes_out_frame(player_heroes, 0, player_0);
                player_move = 0;
            }
            //режим не выбранного
            else
            {
                player_heroes_out(player_heroes, 0, player_0);
            }
        }

        private void player_1_Click(object sender, EventArgs e)
        {
            second++; //счётчик нажатия на героя

            //режим выбранного
            if (second % 2 == 1)
            {
                if (first % 2 == 1)
                {
                    first++;
                    player_heroes_out(player_heroes, 0, player_0);
                }

                if (third % 2 == 1)
                {
                    third++;
                    player_heroes_out(player_heroes, 2, player_2);
                }

                player_heroes_out_frame(player_heroes, 1, player_1);
                player_move = 1;
            }
            //режим не выбранного
            else
            {
                player_heroes_out(player_heroes, 1, player_1);
            }
        }

        private void player_2_Click(object sender, EventArgs e)
        {
            third++; //счётчик нажатия на героя

            //режим выбранного
            if (third % 2 == 1)
            {
                if (second % 2 == 1)
                {
                    second++;
                    player_heroes_out(player_heroes, 1, player_1);
                }

                if (first % 2 == 1)
                {
                    first++;
                    player_heroes_out(player_heroes, 0, player_0);
                }

                player_heroes_out_frame(player_heroes, 2, player_2);
                player_move = 2;
            }
            //режим не выбранного
            else
            {
                player_heroes_out(player_heroes, 2, player_2);
            }
        }

        //метод выбора хода компьютера
        public int pc_action(int[] pc_heroes_health, int[] player_heroes, int player_move, int pc_move,
            string[] instructions, int[] pc_heroes)
        {
            string move_state = null, move_event = null; //состояние, событие

            for (var i = 0; i < 27; i++) //проверка всех инструкций (их в файле 27)
            {
                move_state = read_one_instruction(instructions, i, 0);
                move_event = read_one_instruction(instructions, i, 1);
                //если мало здоровья
                if (move_state == "Мало_здоровья" &&
                    (pc_heroes_health[0] == 1 || pc_heroes_health[1] == 1 || pc_heroes_health[2] == 1))
                {
                    if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                }
                //если атака от мечника 
                else if (move_state == "Атака_от_Мечник" && player_heroes[0] == 0 && player_move == 0)
                {
                    if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                    else if (move_event == "Есть_Броненосец")
                        pc_move = event_card_check(pc_heroes, 1);
                    if (move_event == "Есть_Мечник")
                        pc_move = event_card_check(pc_heroes, 0);
                    else if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Лучник")
                        pc_move = event_card_check(pc_heroes, 3);
                }
                //если атака от броненосца
                else if (move_state == "Атака_от_Броненосец" && (player_heroes[1] == 1 && player_move == 1 ||
                                                                 player_heroes[0] == 1 && player_move == 0))
                {
                    if (move_event == "Есть_Мечник")
                        pc_move = event_card_check(pc_heroes, 0);
                    else if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                    else if (move_event == "Есть_Лучник")
                        pc_move = event_card_check(pc_heroes, 3);
                    else if (move_event == "Есть_Броненосец")
                        pc_move = event_card_check(pc_heroes, 1);
                }
                //если атака от мага
                else if (move_state == "Атака_от_Маг" && (player_heroes[0] == 2 && player_move == 0 ||
                                                          player_heroes[1] == 2 && player_move == 1 ||
                                                          player_heroes[2] == 2 && player_move == 2))
                {
                    if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Мечник")
                        pc_move = event_card_check(pc_heroes, 0);
                    else if (move_event == "Есть_Лучник")
                        pc_move = event_card_check(pc_heroes, 3);
                    else if (move_event == "Есть_Броненосец")
                        pc_move = event_card_check(pc_heroes, 1);
                    else if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                }
                //если атака от лучника
                else if (move_state == "Атака_от_Лучник" && (player_heroes[1] == 3 && player_move == 1 ||
                                                             player_heroes[2] == 3 && player_move == 2))
                {
                    if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                    else if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Броненосец")
                        pc_move = event_card_check(pc_heroes, 1);
                    else if (move_event == "Есть_Мечник")
                        pc_move = event_card_check(pc_heroes, 0);
                    else if (move_event == "Есть_Лучник")
                        pc_move = event_card_check(pc_heroes, 3);
                }
                //если атака от невидимка
                else if (move_state == "Атака_от_Невидимка" && player_heroes[2] == 4 && player_move == 2)
                {
                    if (move_event == "Есть_Маг")
                        pc_move = event_card_check(pc_heroes, 2);
                    else if (move_event == "Есть_Невидимка")
                        pc_move = event_card_check(pc_heroes, 4);
                    else if (move_event == "Есть_Мечник")
                        pc_move = event_card_check(pc_heroes, 0);
                    else if (move_event == "Есть_Броненосец")
                        pc_move = event_card_check(pc_heroes, 1);
                    else if (move_event == "Есть_Лучник")
                        pc_move = event_card_check(pc_heroes, 3);
                }
            }

            return pc_move;
        }

        //метод разбития инструкции на массив с состоянием, событием и действием для выбора хода
        public string
            read_one_instruction(string[] instructions, int line_number, int i) //0 - состояние, 1- событие, 2- действие
        {
            var instruction = instructions[line_number].Split(' ').ToArray();
            return instruction[i];
        }

        //НАЖАТИЯ КНОПОК:
        //выполнение хода
        private void move_Click(object sender, EventArgs e)
        {
            //сообщение об ошибке при попытке осуществления хода без выбора героя
            if (first % 2 == 0 && second % 2 == 0 && third % 2 == 0)
            {
                MessageBox.Show("Для выполнения хода необходимо выбрать героя!");
            }

            //ход
            else
            {
                pc_heroes_out(pc_heroes, 0, pc_0);
                pc_heroes_out(pc_heroes, 1, pc_1);
                pc_heroes_out(pc_heroes, 2, pc_2);
                moves--;
                move_counter.Text = "Осталось ходов:\n" + moves;
                //выбор хода
                pc_move = pc_action(pc_heroes_health, player_heroes, player_move, pc_move, instructions, pc_heroes);
                //выделение активного героя компьютера
                if (pc_move == 0)
                    pc_heroes_out_frame(pc_heroes, 0, pc_0);
                else if (pc_move == 1)
                    pc_heroes_out_frame(pc_heroes, 1, pc_1);
                else if (pc_move == 2)
                    pc_heroes_out_frame(pc_heroes, 2, pc_2);

                //ОСУЩЕСТВЛЕНИЕ ХОДА ИГРОКА
                if (player_heroes[player_move] == 0 && pc_heroes[pc_move] != 4
                ) //если ходит мечник и у компьютера выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    for (var i = 0; i < 3; i++)
                        pc_heroes_health[i] -= 3;
                }
                else if (player_heroes[player_move] == 1 && pc_heroes[pc_move] != 4
                ) //если ходит броненосец и у компьютера выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    if (pc_heroes[pc_move] == 0 || pc_heroes[pc_move] == 1 || pc_heroes[pc_move] == 3
                    ) //блокировка урона, если игрок ходит атакующим героем
                        for (var i = 0; i < 3; i++)
                            player_heroes_health[i]++;

                    for (var i = 0; i < 3; i++) //нанесение урона
                        pc_heroes_health[i]--;
                }
                else if (player_heroes[player_move] == 2) //если ходит маг
                {
                    for (var i = 0; i < 3; i++)
                        pc_heroes_health[i]++;
                }

                else if (player_heroes[player_move] == 3 && pc_heroes[pc_move] != 4
                ) //если ходит лучник и у компьютера выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    //рандомный урон (средний или высокий), т.к. есть возможность нанесения доп. урона
                    var rnd = new Random();
                    for (var i = 0; i < 3; i++)
                    {
                        var archer_damage = rnd.Next(2, 4);
                        pc_heroes_health[i] -= archer_damage;
                    }
                }
                else if (player_heroes[player_move] == 4) //если ходит невидимка
                {
                    //какие-либо дейтствия отсутствуют, т.к. невидимка полностью перекрывает ход противника
                }

                //отображение уровня здоровья и героев компьютера
                show_health(pc_health_0, pc_heroes_health, 0);
                show_health(pc_health_1, pc_heroes_health, 1);
                show_health(pc_health_2, pc_heroes_health, 2);
                hide_pc_hero(pc_heroes_health, 0, pc_0);
                hide_pc_hero(pc_heroes_health, 1, pc_1);
                hide_pc_hero(pc_heroes_health, 2, pc_2);

                //ОСУЩЕСТВЛЕНИЕ ХОДА КОМПЬЮТЕРА
                if (pc_heroes[pc_move] == 0 && player_heroes[player_move] != 4
                ) //если ходит мечник и у игрока выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    for (var i = 0; i < 3; i++)
                        player_heroes_health[i] -= 3;
                }

                else if (pc_heroes[pc_move] == 1 && player_heroes[player_move] != 4
                ) //если ходит броненосец и у игрока выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    if (player_heroes[player_move] == 0 || player_heroes[player_move] == 1 ||
                        player_heroes[player_move] == 3) //блокировка урона, если игрок ходит атакующим героем
                        for (var i = 0; i < 3; i++)
                            pc_heroes_health[i]++;
                    for (var i = 0; i < 3; i++) //нанесение урона
                        player_heroes_health[i]--;
                }

                else if (pc_heroes[pc_move] == 2) //если ходит маг
                {
                    for (var i = 0; i < 3; i++)
                        player_heroes_health[i]++;
                }

                else if (pc_heroes[pc_move] == 3 && player_heroes[player_move] != 4
                ) //если ходит лучник и у игрока выбран не невидимка (т.к. невидимка блокирует удар)
                {
                    //рандомный урон (средний или высокий), т.к. есть возможность нанесения доп. урона
                    var rnd = new Random();
                    for (var i = 0; i < 3; i++)
                    {
                        var archer_damage = rnd.Next(2, 4);
                        player_heroes_health[i] -= archer_damage;
                    }
                }
                else if (pc_heroes[pc_move] == 4) //если ходит невидимка
                {
                    //какие-либо дейтсвия отстутствуют, т.к. недидимка полностью перекрывает ход противника
                }

                //отображение уровня здоровья и героев игрока
                show_health(player_health_0, player_heroes_health, 0);
                show_health(player_health_1, player_heroes_health, 1);
                show_health(player_health_2, player_heroes_health, 2);
                hide_player_hero(player_heroes_health, 0, player_0);
                hide_player_hero(player_heroes_health, 1, player_1);
                hide_player_hero(player_heroes_health, 2, player_2);

                //проверка победителя
                //выиграл игрок
                if (winner_check(player_heroes_health, pc_heroes_health, winner) == 1)
                {
                    //запись результата в файл
                    var sr = new StreamWriter("results.txt", true);
                    sr.Write(File.ReadAllText("name.txt") + " Победа ");
                    sr.Close();

                    //вывод результата на экран
                    MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Победа");

                    //выход в главное меню
                    var b = new battle();
                    b.ShowDialog();
                    Close();
                }
                //выиграл компьютер
                else if (winner_check(player_heroes_health, pc_heroes_health, winner) == 2)
                {
                    //запись результата в файл
                    var sr = new StreamWriter("results.txt", true);
                    sr.Write(File.ReadAllText("name.txt") + " Поражение ");
                    sr.Close();

                    //вывод результата на экран
                    MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Поражение");

                    //выход в главное меню
                    var b = new battle();
                    b.ShowDialog();
                    Close();
                }

                //если закончились ходы
                if (moves == 0)
                {
                    //если суммарное здоровье героев игрока больше - победа
                    if (player_heroes_health[0] + player_heroes_health[1] + player_heroes_health[2] >
                        pc_heroes_health[0] + pc_heroes_health[1] + pc_heroes_health[2])
                    {
                        //запись результата в файл
                        var sr = new StreamWriter("results.txt", true);
                        sr.Write(File.ReadAllText("name.txt") + " Победа ");
                        sr.Close();

                        //вывод результата на экран
                        MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Победа");

                        //выход в главное меню
                        var b = new battle();
                        b.ShowDialog();
                        Close();
                    }
                    //если суммарное здоровье героев компьютера больше - поражение
                    else if (player_heroes_health[0] + player_heroes_health[1] + player_heroes_health[2] <
                             pc_heroes_health[0] + pc_heroes_health[1] + pc_heroes_health[2])
                    {
                        //запись результата в файл
                        var sr = new StreamWriter("results.txt", true);
                        sr.Write(File.ReadAllText("name.txt") + " Поражение ");
                        sr.Close();

                        //вывод результата на экран
                        MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Поражение");

                        //выход в главное меню
                        var b = new battle();
                        b.ShowDialog();
                        Close();
                    }
                    //если суммарное здоровье равно - ничья
                    else
                    {
                        //запись результата в файл
                        var sr = new StreamWriter("results.txt", true);
                        sr.Write(File.ReadAllText("name.txt") + " Ничья ");
                        sr.Close();

                        //вывод результата на экран
                        MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Ничья");

                        //выход в главное меню
                        var b = new battle();
                        b.ShowDialog();
                        Close();
                    }
                }
            }
        }

        //капитуляция игроком
        private void capitulate_Click(object sender, EventArgs e)
        {
            //запись результата в файл
            var sr = new StreamWriter("results.txt", true);
            sr.Write(File.ReadAllText("name.txt") + " Поражение ");
            sr.Close();

            //вывод результата на экран
            MessageBox.Show("Игрок: " + File.ReadAllText("name.txt") + "\n\nРезультат: Поражение");

            //выход в главное меню
            var b = new battle();
            b.ShowDialog();
            Close();
        }
    }
}