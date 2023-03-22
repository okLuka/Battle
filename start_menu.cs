using System;
using System.Windows.Forms;
using System.IO;
namespace battle
{
    //ФОРМА ГЛАВНОГО МЕНЮ
    public partial class battle : Form
    {
        bool set_name = false;
        public battle()
        {
            InitializeComponent();
        }
       //кнопка начать
        private void start_Click(object sender, EventArgs e)
        {
            //если игрок не выбрал имя
            if (set_name == false)
                MessageBox.Show("Сначала необходимо ввести имя!");
            //если имя выбрано
            else
            {
                choose ch = new choose();
                ch.ShowDialog();
                this.Close();
            }
        }
        //ввод имени
        private void name_TextChanged(object sender, EventArgs e)
        {
            //проверка на длину
            if (name.Text.Length > 15)
            {
                MessageBox.Show("Длина вашего имени слишком большая!");
                set_name = false;
            }
            else
            {
                //запись имени игрока в файл
                StreamWriter sr = new StreamWriter("name.txt");
                sr.Write(name.Text);
                sr.Close();

                set_name = true;
            }
        }
        //кнопка последние результаты
        private void results_Click(object sender, EventArgs e)
        {
            results r = new results();
            r.ShowDialog();
            this.Close();
        }
    }
}
