using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace battle
{
    //ФОРМА С ПОСЛЕДНИМИ РЕЗУЛЬТАТАМИ ИГР
    public partial class results : Form
    {
        public results()
        {
            InitializeComponent();

            //считывание результатов игрока из файла
            string text = File.ReadAllText("results.txt");
            if (text.Length == 0)
            {
                return;
            }
            string[] player_results = text.Split(' ').ToArray();

            //вывод последних пяти результатов
            if (player_results.Length >= 10) //если в файле 5 и больше результатов
            {
                results_out(player_results, player_results.Length, name_1, result_1);
                results_out(player_results, player_results.Length - 2, name_2, result_2);
                results_out(player_results, player_results.Length - 4, name_3, result_3);
                results_out(player_results, player_results.Length - 6, name_4, result_4);
                results_out(player_results, player_results.Length - 8, name_5, result_5);
            }
            else if (player_results.Length == 9) //если в файле 4 результата
            {
                results_out(player_results, player_results.Length, name_1, result_1);
                results_out(player_results, player_results.Length - 2, name_2, result_2);
                results_out(player_results, player_results.Length - 4, name_3, result_3);
                results_out(player_results, player_results.Length - 6, name_4, result_4);
            }
            else if (player_results.Length == 7) //если в файле 3 результата
            {
                results_out(player_results, player_results.Length, name_1, result_1);
                results_out(player_results, player_results.Length - 2, name_2, result_2);
                results_out(player_results, player_results.Length - 4, name_3, result_3);
            }
            else if (player_results.Length == 5) //если в файле 2 результата
            {
                results_out(player_results, player_results.Length, name_1, result_1);
                results_out(player_results, player_results.Length - 2, name_2, result_2);
            }
            else //если в файле 1 результат
                results_out(player_results, player_results.Length, name_1, result_1);
        }
        //метод вывода одного результата
        public void results_out(string[] results, int i, Label label_1, Label label_2)
        {
            label_1.Text = results[i - 3]; //имя
            label_2.Text = results[i - 2]; //результат
        }
        //выход в главное меню
        private void back_Click(object sender, System.EventArgs e)
        {
            battle b = new battle();
            b.ShowDialog();
            this.Close();
        }
    }
}
