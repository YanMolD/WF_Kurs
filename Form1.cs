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
        private int indexSave;

        public Form1()
        {
            InitializeComponent();
            Contacts = new ListOfContacts();
            Action = true;
            indexSave = 0;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (indexSave != listBox.SelectedIndex)
                    Contacts.GetPerson(indexSave).NumEmVisible();
                Contacts.GetPerson(listBox.SelectedIndex).NumEmVisible();
                Contacts.GetPerson(listBox.SelectedIndex).NumEmReadonlyTrue();
                if (Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails.Count != 0)
                    textBoxNewEmail.Top = Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails.Last().textBox.Top + 22;
                else
                    textBoxNewEmail.Top = textBoxDate.Top + 22;
                if (Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers.Count != 0)
                    textBoxNewNum.Top = Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers.Last().textBox.Top + 22;
                else
                    textBoxNewNum.Top = textBoxAdress.Top + 22;
                textBoxName.Text = Contacts.GetPerson(listBox.SelectedIndex).Name;
                textBoxAdress.Text = Contacts.GetPerson(listBox.SelectedIndex).Adress;
                textBoxDate.Text = Contacts.GetPerson(listBox.SelectedIndex).BDay;
                indexSave = listBox.SelectedIndex;
            }
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
            if (NewContact.Name != null)
                NewContact.NumEmUnvisible();
            Action = false;
            NewContact = new Person("");
            if (listBox.SelectedIndex != -1)
                Contacts.GetPerson(listBox.SelectedIndex).NumEmUnvisible();
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
            if (listBox.SelectedIndex != -1)
            {
                Contacts.GetPerson(listBox.SelectedIndex).NumEmUnvisible();
                Contacts.People.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
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
                buttonAcceptCh.Visible = false;
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                Contacts.GetPerson(listBox.SelectedIndex).NumEmReadonlyFalse();
                Action = true;
                textBoxName.ReadOnly = false;
                textBoxName.Text = Contacts.GetPerson(listBox.SelectedIndex).Name;
                textBoxAdress.ReadOnly = false;
                textBoxAdress.Text = Contacts.GetPerson(listBox.SelectedIndex).Adress;
                textBoxDate.ReadOnly = false;
                textBoxDate.Text = Contacts.GetPerson(listBox.SelectedIndex).BDay;
                textBoxNewEmail.ReadOnly = false;
                if (Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails.Count != 0)
                    textBoxNewEmail.Top = Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails.Last().textBox.Top + 22;
                else
                    textBoxNewEmail.Top = textBoxDate.Top + 22;
                if (Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers.Count != 0)
                    textBoxNewNum.Top = Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers.Last().textBox.Top + 22;
                else
                    textBoxNewNum.Top = textBoxAdress.Top + 22;
                textBoxNewNum.ReadOnly = false;
                buttonAcceptAdd.Visible = true;
                NewContact = new Person(Contacts.GetPerson(listBox.SelectedIndex));
            }
        }

        private void ButtonAcceptAdd_Click(object sender, EventArgs e)
        {
            if (NewContact.CheckPerson())
            {
                NewContact.NumEmUnvisible();
                Contacts.AddNewContact(NewContact);
                listBox.Items.Add(Contacts.People.Last().Name);
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
                NewContact = new Person("");
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
            if (NewContact.CheckPerson())
            {
                Contacts.People.Insert(listBox.SelectedIndex, NewContact);
                Contacts.DeletePerson(listBox.SelectedIndex + 1, this);
                textBoxName.ReadOnly = true;
                textBoxName.Text = "";
                textBoxAdress.ReadOnly = true;
                textBoxAdress.Text = "";
                textBoxDate.ReadOnly = true;
                textBoxName.Text = "";
                textBoxNewEmail.ReadOnly = true;
                textBoxNewNum.ReadOnly = true;
                buttonAcceptAdd.Visible = false;
                NewContact = new Person("");
            }
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
            NewContact.ChangeBDay(textBoxDate.Text);
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {
            NewContact.ChangeAdress(textBoxAdress.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            NewContact.ChangeName(textBoxName.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}