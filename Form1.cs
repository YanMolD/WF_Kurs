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
                Number number_buf = new Number(textBoxNewEmail.Text, textBoxNewEmail.Location);
                Contacts.people[listBox1.SelectedIndex].Add_number(number_buf);
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
                Contacts.people[listBox1.SelectedIndex].NumbersVisibleSwitch();
            textBoxName.ReadOnly = false;
            textBoxName.Text = "";
            textBoxAdress.ReadOnly = false;
            textBoxAdress.Text = "";
            textBoxDate.ReadOnly = false;
            textBoxName.Text = "";
            textBoxNewEmail.ReadOnly = false;
            textBoxNewEmail.Top = 45;
            textBoxNewEmail.Text = "";
            textBoxNewNum.ReadOnly = false;
            textBoxNewNum.Top = 76;
            textBoxNewNum.Text = "";
            buttonAcceptAdd.Visible = true;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
        }

        private void buttonAcceptAdd_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonAcceptCh_Click(object sender, EventArgs e)
        {
        }
    }
}
