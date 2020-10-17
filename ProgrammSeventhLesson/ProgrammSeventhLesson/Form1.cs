using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#region Условия задачи
/*Жирнов Олег
а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен получить это число за минимальное количество ходов.
в) *Добавить кнопку «Отменить», которая отменяет последние ходы. Используйте обобщенный класс Stack.
Вся логика игры должна быть реализована в классе с удвоителем.

  */
#endregion
namespace ProgrammSeventhLesson
{

    public partial class Doubler : Form
    {
        public Doubler()
        {
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
            lblCounter.Text = "0";
            Number nm = new Number();
        }

        private void Counter_Click(object sender, EventArgs e)
        {   
            
        }

        public void btnCommand1_Click(object sender, EventArgs e/*, Stack<string> numbers*/)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            if (int.Parse(lblNumber.Text) == Class.answ) MessageBox.Show("Вы получили верное число за: " + lblCounter.Text + " ходов!");
            Class.numbers.Push(lblNumber.Text);
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
        }

        public void btnCommand2_Click(object sender, EventArgs e/*, Stack<string> numbers*/)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            if (int.Parse(lblNumber.Text) == Class.answ) MessageBox.Show("Вы получили верное число за: " + lblCounter.Text + " ходов!");
            Class.numbers.Push(lblNumber.Text);
            lblCounter.Text = (int.Parse(lblCounter.Text) + 1).ToString();
        }
        

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Number nm = new Number();
            nm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Class.numbers.Pop();
            lblNumber.Text = Class.numbers.Peek();
            if (int.Parse(lblNumber.Text) == Class.answ) MessageBox.Show("Вы получили верное число за: " + lblCounter.Text + " ходов!");
        }
        
    }
    class Class
    {
        static public Stack<string> numbers = new Stack<string>();
        static public int answ;
    }
}
