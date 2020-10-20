using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hw3Forms
{
    public partial class Form1 : Form
    {
        TrueFalse database;
        public Form1()
        {
            InitializeComponent();
        }

        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            };
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }

        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }


        private void miExit_Click(object sender, EventArgs e)
        {
            { MessageBox.Show("Спасибо за участие в эксперименте! Уахахахахаха!"); }
            this.Close();
        }

        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {

            if (database == null) { MessageBox.Show("База пуста! Создайте новую или выберите созданную базу!");}
            else
            {
                tboxQuestion.Text = database[(int)nudNumber.Value - 1].text;
                cboxTrue.Checked = database[(int)nudNumber.Value - 1].trueFalse;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add((database.Count).ToString(), true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value);
            nudNumber.Maximum--;
            if (nudNumber.Value > 1) nudNumber.Value = nudNumber.Value;
        }

        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].trueFalse = cboxTrue.Checked;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            tboxQuestion.Text = ("Автор: Жирнов Олег. Версия: 1.0. Авторские права принадлежат вышеупомянутому Автору! Неавторские права принадлежат кому-то другому...");
        }

        private void nudNumber_MouseUp(object sender, MouseEventArgs e)
        {
            if (nudNumber.Maximum==nudNumber.Value) { MessageBox.Show("Это был последний вопрос"); }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var av = database;
            SaveFileDialog sfad = new SaveFileDialog();
            if (sfad.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfad.FileName);
                for (int i=0; i<av.Count;i++)
                database.Add(av[i].text, av[i].trueFalse);
                database.Save();
            }
        }
    }
}
