using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace WF_Kurs
{
    public partial class Form1 : Form
    {
        private readonly ListOfContacts Contacts;
        private Person NewContact;

        public Form1()
        {
            InitializeComponent();
            Contacts = new ListOfContacts();
            BinaryFormatter formatter = new BinaryFormatter();
            string[] fileEntries = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.Contacts");
            foreach (string item in fileEntries)
            {
                using (FileStream fs = new FileStream(item, FileMode.OpenOrCreate))
                    Contacts = (ListOfContacts)formatter.Deserialize(fs);
            }
            for (int i = 0; i < Contacts.People.Count; i++)
                listBox.Items.Add(Contacts.People[i].Name);
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (buttonAcceptCh.Visible && buttonAcceptAdd.Visible)
                {
                    ReadOnlySwitch();
                    buttonAcceptAdd.Visible = false;
                    buttonAcceptCh.Visible = false;
                }
                textBoxName.Text = Contacts.GetPerson(listBox.SelectedIndex).Name;
                textBoxAdress.Text = Contacts.GetPerson(listBox.SelectedIndex).Adress;
                textBoxDate.Text = Contacts.GetPerson(listBox.SelectedIndex).BDay;
                listBoxNumbers.Items.Clear();
                listBoxEmails.Items.Clear();
                for (int i = 0; i < Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers.Count; i++)
                    listBoxNumbers.Items.Add(Contacts.GetPerson(listBox.SelectedIndex).ListOfNumbers[i]);
                for (int i = 0; i < Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails.Count; i++)
                    listBoxEmails.Items.Add(Contacts.GetPerson(listBox.SelectedIndex).ListOfEmails[i]);
            }
        }

        private void TextBoxNewNum_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewNum.ReadOnly && textBoxNewNum.Text == "Добавить номер...")
                textBoxNewNum.Text = "";
        }

        private void TextBoxNewEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxNewEmail.ReadOnly && textBoxNewEmail.Text == "Добавить Email...")
                textBoxNewEmail.Text = "";
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            NewContact = new Person("");
            if (textBoxName.ReadOnly)
                ReadOnlySwitch();
            ClearBoxes();
            textBoxDate.Text = "YYYY-MM-DD";
            buttonAcceptAdd.Visible = true;
            buttonAcceptCh.Visible = false;
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                Contacts.People.RemoveAt(listBox.SelectedIndex);
                listBox.Items.RemoveAt(listBox.SelectedIndex);
                ClearBoxes();
                if (!textBoxName.ReadOnly)
                    ReadOnlySwitch();
                buttonAcceptAdd.Visible = false;
                buttonAcceptCh.Visible = false;
            }
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                if (textBoxName.ReadOnly)
                    ReadOnlySwitch();
                textBoxName.Text = Contacts.GetPerson(listBox.SelectedIndex).Name;
                textBoxAdress.Text = Contacts.GetPerson(listBox.SelectedIndex).Adress;
                textBoxDate.Text = Contacts.GetPerson(listBox.SelectedIndex).BDay;
                buttonAcceptCh.Visible = true;
                NewContact = new Person(Contacts.GetPerson(listBox.SelectedIndex));
            }
        }

        private void ButtonAcceptAdd_Click(object sender, EventArgs e)
        {
            if (CheckPerson(NewContact))
            {
                for (int i = 0; i < listBoxNumbers.Items.Count; i++)
                {
                    Number buf_number = new Number(listBoxNumbers.Items[i].ToString());
                    NewContact.AddNumber(buf_number);
                }
                for (int i = 0; i < listBoxEmails.Items.Count; i++)
                {
                    Email buf_email = new Email(listBoxEmails.Items[i].ToString());
                    NewContact.AddEmail(buf_email);
                }
                Contacts.AddNewContact(NewContact);
                listBox.Items.Add(Contacts.People.Last().Name);
                ReadOnlySwitch();
                ClearBoxes();
                buttonAcceptAdd.Visible = false;
                NewContact = new Person("");
            }
            else
            {
                if (textBoxName.Text == "")
                    MessageBox.Show("Вы не ввели имя");
            }
        }

        private void ButtonAcceptCh_Click(object sender, EventArgs e)
        {
            if (CheckPerson(NewContact))
            {
                NewContact.ListOfEmails = new List<Email>();
                NewContact.ListOfNumbers = new List<Number>();
                for (int i = 0; i < listBoxNumbers.Items.Count; i++)
                {
                    Number buf_number = new Number(listBoxNumbers.Items[i].ToString());
                    NewContact.AddNumber(buf_number);
                }
                for (int i = 0; i < listBoxEmails.Items.Count; i++)
                {
                    Email buf_email = new Email(listBoxEmails.Items[i].ToString());
                    NewContact.AddEmail(buf_email);
                }
                Contacts.People.Insert(listBox.SelectedIndex, NewContact);
                Contacts.DeletePerson(listBox.SelectedIndex + 1);
                ReadOnlySwitch();
                ClearBoxes();
                buttonAcceptAdd.Visible = false;
                buttonAcceptCh.Visible = false;
                NewContact = new Person("");
            }
        }

        private void TextBoxAdress_TextChanged(object sender, EventArgs e)
        {
            NewContact.ChangeAdress(textBoxAdress.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            NewContact.ChangeName(textBoxName.Text);
        }

        private void buttonVCard_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                saveFileDialog1.ShowDialog();
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName + ".vcf");
                sw.Write(Contacts.GetPerson(listBox.SelectedIndex));
                sw.Close();
            }
        }

        private void textBoxDate_MouseClick(object sender, MouseEventArgs e)
        {
            if (!textBoxDate.ReadOnly && textBoxDate.Text == "YYYY-MM-DD")
                textBoxDate.Text = "";
        }

        private void TextBoxDate_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDate.Text != "" && textBoxDate.Text != "YYYY-MM-DD")
            {
                textBoxDate.ForeColor = Color.Black;
                NewContact.ChangeBDay(textBoxDate.Text);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            File.Delete(Directory.GetCurrentDirectory() + $"/Contacts.Contacts");
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(Directory.GetCurrentDirectory() + $"/Contacts.Contacts", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Contacts);
            }
        }

        private void buttonAddNum_Click(object sender, EventArgs e)
        {
            if (Check_number(textBoxNewNum.Text) || (textBoxNewNum.Text == "" && !listBoxNumbers.Enabled))
            {
                if (listBoxNumbers.Enabled)
                    listBoxNumbers.Items.Add(textBoxNewNum.Text);
                else
                {
                    if (textBoxNewNum.Text == "")
                        listBoxNumbers.Items.RemoveAt(listBoxNumbers.SelectedIndex);
                    else
                    {
                        listBoxNumbers.Items.Insert(listBoxNumbers.SelectedIndex, textBoxNewNum.Text);
                        listBoxNumbers.Items.RemoveAt(listBoxNumbers.SelectedIndex);
                    }
                }
                textBoxNewNum.Text = "Добавить номер...";
                buttonCancelAddNum.Visible = false;
                listBoxNumbers.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckEmail(textBoxNewEmail.Text) || (textBoxNewEmail.Text == "" && !listBoxEmails.Enabled))
            {
                if (listBoxEmails.Enabled)
                    listBoxEmails.Items.Add(textBoxNewEmail.Text);
                else
                {
                    if (textBoxNewEmail.Text == "")
                        listBoxEmails.Items.RemoveAt(listBoxEmails.SelectedIndex);
                    else
                    {
                        listBoxEmails.Items.Insert(listBoxEmails.SelectedIndex, textBoxNewEmail.Text);
                        listBoxEmails.Items.RemoveAt(listBoxEmails.SelectedIndex);
                    }
                }
                textBoxNewEmail.Text = "Добавить Email...";
                buttonCancelAddEm.Visible = false;
                listBoxEmails.Enabled = true;
            }
        }

        private void listBoxNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textBoxNewNum.ReadOnly && listBoxNumbers.SelectedIndex != -1)
            {
                textBoxNewNum.Text = listBoxNumbers.Items[listBoxNumbers.SelectedIndex].ToString();
                listBoxNumbers.Enabled = false;
                buttonCancelAddNum.Visible = true;
            }
        }

        private void listBoxEmails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!textBoxNewEmail.ReadOnly && listBoxEmails.SelectedIndex != -1)
            {
                textBoxNewEmail.Text = listBoxEmails.Items[listBoxEmails.SelectedIndex].ToString();
                listBoxEmails.Enabled = false;
                buttonCancelAddEm.Visible = true;
            }
        }

        private void buttonCancelAddNum_Click(object sender, EventArgs e)
        {
            textBoxNewNum.Text = "Добавить номер...";
            buttonCancelAddNum.Visible = false;
            listBoxNumbers.Enabled = true;
        }

        private void buttonCancelAddEm_Click(object sender, EventArgs e)
        {
            textBoxNewEmail.Text = "Добавить Email...";
            buttonCancelAddEm.Visible = false;
            listBoxEmails.Enabled = true;
        }

        private void ReadOnlySwitch()
        {
            textBoxAdress.ReadOnly = !textBoxAdress.ReadOnly;
            textBoxDate.ReadOnly = !textBoxDate.ReadOnly;
            textBoxName.ReadOnly = !textBoxName.ReadOnly;
            textBoxNewEmail.ReadOnly = !textBoxNewEmail.ReadOnly;
            textBoxNewNum.ReadOnly = !textBoxNewNum.ReadOnly;
        }

        private void ClearBoxes()
        {
            textBoxName.Text = "";
            textBoxAdress.Text = "";
            textBoxDate.Text = "";
            listBoxNumbers.Items.Clear();
            listBoxEmails.Items.Clear();
        }

        private static bool CheckPerson(Person person)
        {
            if (person.Name == "")
                return false;
            if (!CheckBDate(person.BDay) && person.BDay != "")
                return false;
            return true;
        }

        private static bool CheckBDate(string BDay) => Regex.IsMatch(BDay, @"^([0-9]{4})[\-]([0]?[1-9]|[1][0-2])[\-](0?[1-9]|[12][0-9]|3[01])$");

        private static bool CheckEmail(string email)
        {
            if (email == "")
                return false;
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        private static bool Check_number(string number) => Regex.IsMatch(number, @"^[+][\d]+$") || Regex.IsMatch(number, @"^[\d]+$");
    }
}