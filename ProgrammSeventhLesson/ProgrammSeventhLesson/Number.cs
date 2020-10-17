using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammSeventhLesson
{
    public partial class Number : Form
    {
        public Number()
        {

            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {
            Random rnd;
            rnd = new Random();
            rnd1.Text = (rnd.Next(1,100)).ToString();
            Class.answ = int.Parse(rnd1.Text);
        }
    }
}
