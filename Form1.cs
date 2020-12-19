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
        private readonly ListOfContacts Contacts;
        private bool Action; //true->изменение контакта, false-> добавление
        private Person NewContact;

        public Form1()
        {
            InitializeComponent();
            Contacts = new ListOfContacts();
            Action = true;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void TextBoxNewNum_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewNum.ReadOnly)
                textBoxNewNum.Text = "";
        }

        private void TextBoxNewNum_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewNum.Text != "")
            {
                Number number_buf = new Number(textBoxNewNum.Text.Substring(0, 1), textBoxNewNum.Location, this);
                if (Action)
                    Contacts.People[listBox1.SelectedIndex].AddNumber(number_buf);
                else
                    Contacts.People[Contacts.People.Count - 1].AddNumber(number_buf);
                textBoxNewNum.Text = "Добавить номер...";
                textBoxNewNum.Top += 11;
            }
        }

        private void TextBoxNewEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewEmail.ReadOnly)
                textBoxNewEmail.Text = "";
        }

        private void TextBoxNewEmail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNewEmail.Text != "")
            {
                Email email_buf = new Email(textBoxNewEmail.Text.Substring(0, 1), textBoxNewEmail.Location, this);
                if (Action)
                    Contacts.People[listBox1.SelectedIndex].AddEmail(email_buf);
                else
                    Contacts.People[Contacts.People.Count - 1].AddEmail(email_buf);
                textBoxNewEmail.Text = "Добавить Email...";
                textBoxNewEmail.Top += 11;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Action = false;
            NewContact = new Person();
            if (listBox1.SelectedIndex != -1)
                Contacts.People[listBox1.SelectedIndex].NumEmVisibleSwitch();
            textBoxName.ReadOnly = false;
            textBoxName.Text = "";
            textBoxAdress.ReadOnly = false;
            textBoxAdress.Text = "";
            textBoxDate.ReadOnly = false;
            textBoxName.Text = "";
            textBoxNewEmail.ReadOnly = false;
            textBoxNewEmail.Top = textBoxDate.Top + 22;
            textBoxNewNum.ReadOnly = false;
            textBoxNewNum.Top = textBoxAdress.Top + 22;
            buttonAcceptAdd.Visible = true;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
            }
        }

        private void ButtonAcceptAdd_Click(object sender, EventArgs e)
        {
            if (Contacts.People[Contacts.People.Count - 1].CheckPerson())
            {
                Contacts.People[Contacts.People.Count - 1].NumEmVisibleSwitch();
                textBoxName.ReadOnly = true;
                textBoxName.Text = "";
                textBoxAdress.ReadOnly = true;
                textBoxAdress.Text = "";
                textBoxDate.ReadOnly = true;
                textBoxName.Text = "";
                textBoxNewEmail.ReadOnly = true;
                textBoxNewEmail.Top = textBoxDate.Top + 22;
                textBoxNewNum.ReadOnly = true;
                textBoxNewNum.Top = textBoxAdress.Top + 22;
                buttonAcceptAdd.Visible = false;
                Contacts.AddNewContact(NewContact);
                listBox1.Items.Add(Contacts.People[Contacts.People.Count - 1]);
            }
            else
            {
                MessageBox.Show("Неправильные данные");
            }
        }

        private void ButtonAcceptCh_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxDate_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxDate.ReadOnly)
                textBoxDate.Text = "";
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!Action)
                NewContact.ChangeBDay(textBoxDate.Text);
            else
                Contacts.People[listBox1.SelectedIndex].ChangeBDay(textBoxDate.Text);
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (!Action)
                NewContact.ChangeAdress(textBoxDate.Text);
            else
                Contacts.People[listBox1.SelectedIndex].ChangeAdress(textBoxDate.Text);
        }
    }
}