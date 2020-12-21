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
            if (textBoxNewNum.Text != "" && textBoxNewNum.Text != "Добавить номер...")
            {
                Number number_buf = new Number(textBoxNewNum.Text.Substring(0, 1), textBoxNewNum.Location, this);
                if (Action)
                    Contacts.AddNumber(number_buf, listBox.SelectedIndex);
                else
                    NewContact.AddNumber(number_buf);
                textBoxNewNum.Text = "Добавить номер...";
                textBoxNewNum.Top += 22;
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
                    Contacts.AddEmail(email_buf, listBox.SelectedIndex);
                else
                    NewContact.AddEmail(email_buf);
                textBoxNewEmail.Text = "Добавить Email...";
                textBoxNewEmail.Top += 11;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            Action = false;
            NewContact = new Person("");
            if (listBox.SelectedIndex != -1)
                Contacts.People[listBox.SelectedIndex].NumEmVisibleSwitch();
            textBoxName.ReadOnly = false;
            textBoxName.Text = "";
            textBoxAdress.ReadOnly = false;
            textBoxAdress.Text = "";
            textBoxDate.ReadOnly = false;
            textBoxDate.Text = "";
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
            if (listBox.SelectedIndex != -1)
            {
                Action = true;
                textBoxName.ReadOnly = false;
                textBoxName.Text = Contacts.People[listBox.SelectedIndex].Name;
                textBoxAdress.ReadOnly = false;
                textBoxAdress.Text = Contacts.People[listBox.SelectedIndex].Adress;
                textBoxDate.ReadOnly = false;
                textBoxDate.Text = Contacts.People[listBox.SelectedIndex].BDay;
                textBoxNewEmail.ReadOnly = false;
                textBoxNewEmail.Top = Contacts.People[listBox.SelectedIndex].ListOfEmails.Last().textBox.Location.Y + 22;
                textBoxNewNum.ReadOnly = false;
                textBoxNewNum.Top = Contacts.People[listBox.SelectedIndex].ListOfNumbers.Last().textBox.Location.Y + 22; ;
                buttonAcceptAdd.Visible = true;
            }
        }

        private void ButtonAcceptAdd_Click(object sender, EventArgs e)
        {
            if (NewContact.CheckPerson())
            {
                NewContact.NumEmVisibleSwitch();
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
                listBox.Items.Add(Contacts.People.Last().Name);
            }
            else
            {
                if (textBoxName.Text == "")
                    MessageBox.Show("Вы не ввели имя");
                else
                    MessageBox.Show("Неправильные данные");
            }
        }

        private void ButtonAcceptCh_Click(object sender, EventArgs e)
        {
        }

        private void TextBoxDate_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxDate.ReadOnly && textBoxDate.Text != "DD.MM.YYYY")
            {
                textBoxDate.Text = "";
                textBoxDate.ForeColor = Color.Black;
            }
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (!Action)
                NewContact.ChangeBDay(textBoxDate.Text);
            else
                Contacts.People[listBox.SelectedIndex].ChangeBDay(textBoxDate.Text);
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {
            if (!Action)
                NewContact.ChangeAdress(textBoxDate.Text);
            else
                Contacts.People[listBox.SelectedIndex].ChangeAdress(textBoxDate.Text);
        }
    }
}