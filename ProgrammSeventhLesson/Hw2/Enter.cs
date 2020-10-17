using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw2
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            counter.Text = "0";

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEqual_Click(object sender, EventArgs e)
        {
            counter.Text = (int.Parse(counter.Text)+1).ToString();
            if (int.Parse(txtEnter.Text) == Class1.answ) MessageBox.Show("Ура! Вы угадали всего лишь за "+ counter.Text + " попыток!");
            else if (int.Parse(txtEnter.Text) > Class1.answ) MessageBox.Show("Загаданное число меньше!");
            else MessageBox.Show("Загаданное число больше!");
        }

        private void counter_Click(object sender, EventArgs e)
        {

        }
    }
}
