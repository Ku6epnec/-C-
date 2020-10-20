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
//Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown
#endregion
namespace Hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numericUpDown.Value);
        }
    }
}
