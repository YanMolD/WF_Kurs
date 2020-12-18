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

        private void textBoxNewNum_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNewNum.Text = "";
        }

        private void textBoxNewNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewNum.Text != "")
            {
                textBoxNewNum.Text = "Добавить номер...";
                textBoxNewNum.Top += 11;
            }
        }

        private void textBoxNewEmail_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNewEmail.Text = "";
        }

        private void textBoxNewEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewEmail.Text != "")
            {
                textBoxNewEmail.Text = "Добавить номер...";
                textBoxNewEmail.Top += 11;
            }
        }
    }
}