using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsHw1
{
    public partial class MyHomeWork : Form
    {
        public MyHomeWork()
        {
            InitializeComponent();
        }
        private void MyHomeWork_Load(object sender, EventArgs e)
        {
            string name = "Name: Nurtleu";
            string surname = "Surname: Omirzhanov";
            string placeofstudy = "Place of study: Computer Academy Shag";
            string professions = "Professions: Programmer";
            string date = "Date of Birth: 28.05.2001";
            string numberofphone = "Number of phone: 87076568759";
            MessageBox.Show(name);
            MessageBox.Show(surname);
            MessageBox.Show(placeofstudy);
            MessageBox.Show(professions);
            MessageBox.Show(date);
            MessageBox.Show(numberofphone);
        }
    }
}
