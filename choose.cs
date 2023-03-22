using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using battle.Properties;

namespace battle
{
    //ФОРМА ВЫБОРА ГЕРОЕВ ИГРОКОМ
    public partial class choose : Form
    {
        Random rnd = new Random();
        int[] chooses = new int[5]; //swordsman, armored, magicianm archer, invisible
        private int[] hero_choose = new int[5];
       // int swordsman_choose = 0, armored_choose = 0, magician_choose = 0, archer_choose = 0, invisible_choose = 0; //, choosen_heroes = 0;
        bool[] choosen = new bool[5] { false, false, false, false, false }; 
        //трекер выбора героя (0 - мечник, 1 - броненосец, 2 - маг, 3 - лучник, 4 - невидимка)
        public choose()
        {
            InitializeComponent();

            //случайный выбор героев для компьютера
            int[] pc_heroes = new int[3];
            for (int i = 0; i < 3; i++)
            {
                random_choose(pc_heroes, i);
            }

            //запись героев компьютера в файл
            StreamWriter sr = new StreamWriter("pc_heroes.txt");
            for (int i = 0; i < 3; i++)
                sr.WriteLine(pc_heroes[i]);
            sr.Close();
        }
        //метод подсчёта выбранных героев
        public int mass_count(bool[] a)
        {
            int v = 0;
            foreach (var VARIABLE in a)
            {
                if (VARIABLE)
                    v++;
            }
            return v;
        }

        //МЕТОДЫ СЛУЧАЙНОГО ВЫБОРА:
        //случайный выбор героев для игрока
        private void random_heroes_Click(object sender, System.EventArgs e)
        {
            int[] random_heroes = new int[3]; //массив, содержащий случайно сгенерированные карты игрока
            for (int i = 0; i < 3; i++)
            {
                random_choose(random_heroes, i);
            }

            //запись в файл
            StreamWriter st = new StreamWriter("player_heroes.txt");
            for (int i = 0; i < 3; i++)
                st.WriteLine(random_heroes[i]);
            st.Close();

            //переход к форме игрового процесса
            game g = new game();
            g.ShowDialog();
            this.Close();
        }

        public void random_choose(int[] heroes, int index)
        {
            switch (index)
            {
                case 0: //первый герой
                    heroes[0] = rnd.Next(0, 5);
                    break;
                case 1: //второй герой
                    heroes[1] = rnd.Next(0, 5);
                    while (heroes[1] == heroes[0])
                        heroes[1] = rnd.Next(0, 5);
                    break;
                case 2: //третий герой
                    heroes[2] = rnd.Next(0, 5);
                    while (heroes[2] == heroes[0] || heroes[2] == heroes[1])
                        heroes[2] = rnd.Next(0, 5);
                    break;
            }
        }

        //МЕТОДЫ ВЫБОРА ГЕРОЕВ ИГРОКОМ (в зависимости от клика по карте)
        //мечник
        private void swordsman_Click(object sender, EventArgs e)
        {
            if (mass_count(choosen) == 3)
            {
                if (!choosen[0])
                    MessageBox.Show("Выбрано максимальное кол-во героев! \n\n" +
                                    "Для выполнения данного действия необходимо снять выделение с одного из них.");
                else
                {
                    swordsman.BackgroundImage = new Bitmap(Properties.Resources.swordsman);
                    choosen[0] = false;
                }
            }
            else
            {
                hero_choose[0]++;
                if (hero_choose[0] % 2 == 1)
                {
                    swordsman.BackgroundImage = new Bitmap(Properties.Resources.swordsman_frame);
                    choosen[0] = true;
                }
                else
                {
                    swordsman.BackgroundImage = new Bitmap(Properties.Resources.swordsman);
                    choosen[0] = false;
                }
            }
        }
        //броненосец
        private void armored_Click(object sender, EventArgs e)
        {
            if (mass_count(choosen) == 3 && !choosen[1])
                MessageBox.Show("Выбрано максимальное кол-во героев! \n\nДля выполнения данного действия необходимо снять выделение с одного из них.");
            else if (mass_count(choosen) == 3 && choosen[1])
            {
                armored.BackgroundImage = new Bitmap(Properties.Resources.armored);
                choosen[1] = false;
            }
            else
            {
                hero_choose[1]++;
                if (hero_choose[1] % 2 == 1)
                {
                    armored.BackgroundImage = new Bitmap(Properties.Resources.armored_frame);
                    choosen[1] = true;
                }
                else if (hero_choose[1] % 2 == 0)
                {
                    armored.BackgroundImage = new Bitmap(Properties.Resources.armored);
                    choosen[1] = false;
                }
            }
        }
        //маг
        private void magician_Click(object sender, EventArgs e)
        {
            if (mass_count(choosen) == 3 && choosen[2] == false)
                MessageBox.Show("Выбрано максимальное кол-во героев! \n\nДля выполнения данного действия необходимо снять выделение с одного из них.");
            else if (mass_count(choosen) == 3 && choosen[2] == true)
            {
                magician.BackgroundImage = new Bitmap(Properties.Resources.magician);
                choosen[2] = false;
            }
            else
            {
                hero_choose[2]++;
                if (hero_choose[2] % 2 == 1)
                {
                    magician.BackgroundImage = new Bitmap(Properties.Resources.magician_frame);
                    choosen[2] = true;
                }
                else if (hero_choose[2] % 2 == 0)
                {
                    magician.BackgroundImage = new Bitmap(Properties.Resources.magician);
                    choosen[2] = false;
                }
            }
        }
        //лучник
        private void archer_Click(object sender, EventArgs e)
        {
            if (mass_count(choosen) == 3 && choosen[3] == false)
                MessageBox.Show("Выбрано максимальное кол-во героев! \n\nДля выполнения данного действия необходимо снять выделение с одного из них.");
            else if (mass_count(choosen) == 3 && choosen[3] == true)
            {
                archer.BackgroundImage = new Bitmap(Properties.Resources.archer);
                choosen[3] = false;
            }
            else
            {
                hero_choose[3]++;
                if (hero_choose[3] % 2 == 1)
                {
                    archer.BackgroundImage = new Bitmap(Properties.Resources.archer_frame);
                    choosen[3] = true;
                }
                else if (hero_choose[3] % 2 == 0)
                {
                    archer.BackgroundImage = new Bitmap(Properties.Resources.archer);
                    choosen[3] = false;
                }
            }
        }
        //невидимка
        private void invisible_Click(object sender, EventArgs e)
        {
            if (mass_count(choosen) == 3 && choosen[4] == false)
                MessageBox.Show("Выбрано максимальное кол-во героев! \n\nДля выполнения данного действия необходимо снять выделение с одного из них.");
            else if (mass_count(choosen) == 3 && choosen[4] == true)
            {
                invisible.BackgroundImage = new Bitmap(Properties.Resources.invisible);
                choosen[4] = false;
            }
            else
            {
                hero_choose[4]++;
                if (hero_choose[4] % 2 == 1)
                {
                    invisible.BackgroundImage = new Bitmap(Properties.Resources.invisible_frame);
                    choosen[4] = true;
                }
                else if (hero_choose[4] % 2 == 0)
                {
                    invisible.BackgroundImage = new Bitmap(Properties.Resources.invisible);
                    choosen[4] = false;
                }
            }
        }

        //КНОПКИ:
        //кнопка назад
        private void back_Click(object sender, EventArgs e)
        {
            battle b = new battle();
            b.ShowDialog();
            this.Close();
        }
        //кнопка начать
        private void start_Click(object sender, EventArgs e)
        {
            //запись выбранных героев в файл
            StreamWriter sr = new StreamWriter("player_heroes.txt");
            for (int i = 0; i < 5; i++)
                if (choosen[i] == true)
                    sr.WriteLine(i);
            sr.Close();
            if (mass_count(choosen) < 3)
                MessageBox.Show("Для начала игры необходимо выбрать трёх героев!");
            else if (mass_count(choosen) == 3)
            {
                game g = new game();
                g.ShowDialog();
                this.Close();
                Application.Exit();
            }
        }
    }
}
