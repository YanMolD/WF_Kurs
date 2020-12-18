using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Kurs
{
    public partial class Form1 : Form
    {
        private ListOfContacts Contacts;

        public Form1()
        {
            InitializeComponent();
            Contacts = new ListOfContacts();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox6_MouseClick(object sender, MouseEventArgs e)
        {
            textBox6.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                textBox6.Text = "Добавить номер...";
                textBox6.Top += 11;
            }
        }

        private void textBox7_MouseClick(object sender, MouseEventArgs e)
        {
            textBox7.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                textBox7.Text = "Добавить Email...";
                textBox7.Top += 11;
            }
        }
    }
}