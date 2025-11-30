using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kOZLOVA_PR07_GIT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fio = "Козлова Мария Дмитриевна";
            MessageBox.Show($"Студентка группы ИС-23А:{fio}","Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
