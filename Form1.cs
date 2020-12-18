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
        private bool Action; //true->изменение контакта, false-> добавление

        public Form1()
        {
            InitializeComponent();
            Contacts = new ListOfContacts();
            Action = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxNewNum_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewNum.ReadOnly)
                textBoxNewNum.Text = "";
        }

        private void textBoxNewNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewNum.Text != "")
            {
                Number number_buf = new Number(textBoxNewNum.Text.Substring(0, 1), textBoxNewNum.Location, this);
                if (Action)
                    Contacts.people[listBox1.SelectedIndex].Add_number(number_buf);
                else
                    Contacts.people[Contacts.people.Count - 1].Add_number(number_buf);
                textBoxNewNum.Text = "Добавить номер...";
                textBoxNewNum.Top += 11;
            }
        }

        private void textBoxNewEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewEmail.ReadOnly)
                textBoxNewEmail.Text = "";
        }

        private void textBoxNewEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewEmail.Text != "")
            {
                Email email_buf = new Email(textBoxNewEmail.Text.Substring(0, 1), textBoxNewEmail.Location);
                if (Action)
                    Contacts.people[listBox1.SelectedIndex].Add_email(email_buf);
                else
                    Contacts.people[Contacts.people.Count].Add_email(email_buf);
                textBoxNewEmail.Text = "Добавить Email...";
                textBoxNewEmail.Top += 11;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Action = false;
            Contacts.Add_new_contact("");
            if (listBox1.SelectedIndex != -1)
                Contacts.people[listBox1.SelectedIndex].NumEmVisibleSwitch();
            textBoxName.ReadOnly = false;
            textBoxName.Text = "";
            textBoxAdress.ReadOnly = false;
            textBoxAdress.Text = "";
            textBoxDate.ReadOnly = false;
            textBoxName.Text = "";
            textBoxNewEmail.ReadOnly = false;
            textBoxNewEmail.Top = 34;
            textBoxNewNum.ReadOnly = false;
            textBoxNewNum.Top = 65;
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
            Contacts.people[Contacts.people.Count - 1].NumEmVisibleSwitch();
        }

        private void buttonAcceptCh_Click(object sender, EventArgs e)
        {
        }
    }
}
