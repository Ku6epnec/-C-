using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region Условия задачи
/*Жирнов Олег
Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Компьютер говорит, больше или меньше загаданное число введенного.  
a) Для ввода данных от человека используется элемент TextBox;
б) **Реализовать отдельную форму c TextBox для ввода числа.
  */
#endregion
namespace Hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rnd;
            rnd = new Random();
            lblRnd.Text = (rnd.Next(1, 100)).ToString();
            Class1.answ = int.Parse(lblRnd.Text);
            Enter ent = new Enter();
            ent.Show();
        }



        private void lvlRnd_Click(object sender, EventArgs e)
        {
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEqual_Click_1(object sender, EventArgs e)
        {
            if (txtBox.Text == lblRnd.Text) MessageBox.Show("Ура! Вы угадали!");
            else if (int.Parse(txtBox.Text) > int.Parse(lblRnd.Text)) MessageBox.Show("Загаданное число меньше!");
            else MessageBox.Show("Загаданное число больше!");
        }
    }
}
