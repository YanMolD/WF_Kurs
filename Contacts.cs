using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WF_Kurs
{
    internal struct Number
    {
        public System.Windows.Forms.TextBox textBox;

        public Number(string number, Point Location, Form1 form)
        {
            textBox = new System.Windows.Forms.TextBox();
            form.Controls.Add(textBox);
            textBox.Visible = true;
            textBox.Location = Location;
            textBox.Width = 105;
            textBox.Text = number;
        }

        public bool Check_number() => Regex.IsMatch(textBox.Text, @"^[+][\d]+$") || Regex.IsMatch(textBox.Text, @"^[\d]+$");

        public void Change_number(string new_number) => textBox.Text = new_number;

        public string ForVcard() => "TEL;HOME:" + textBox.Text + "\n";

        public override string ToString() => textBox.Text;
    }

    internal struct Email
    {
        public System.Windows.Forms.TextBox textBox;

        public Email(string email, Point Location, Form1 form)
        {
            textBox = new System.Windows.Forms.TextBox();
            form.Controls.Add(textBox);
            textBox.Visible = true;
            textBox.Location = Location;
            textBox.Width = 105;
            textBox.Text = email;
        }

        public bool CheckEmail() => Regex.IsMatch(textBox.Text, @"^([\w\d\.]+)@([\w\d]+)(\.(\w))$");

        public void ChangeEmail(string newEmail) => textBox.Text = newEmail;

        public string ForVcard() => "TEL;HOME:" + textBox.Text + "\n";

        public override string ToString() => textBox.Text;
    }

    internal struct Person
    {
        public string Name;
        public List<Number> ListOfNumbers;
        public List<Email> ListOfEmails;
        public string BDay;
        public string Adress;

        public void AddNumber(Number buf) => ListOfNumbers.Add(buf);

        public void AddEmail(Email buf) => ListOfEmails.Add(buf);

        public Person(string new_name)
        {
            Name = new_name;
            BDay = "";
            Adress = "";
            ListOfNumbers = new List<Number>();
            ListOfEmails = new List<Email>();
        }

        public Person(Person person)
        {
            Name = person.Name;
            BDay = person.BDay;
            Adress = person.Adress;
            ListOfNumbers = person.ListOfNumbers;
            ListOfEmails = person.ListOfEmails;
        }

        public void DeleteNumber(int index)
        {
            ListOfNumbers.RemoveAt(index);
            for (int i = index; i < ListOfNumbers.Count; i++)
                ListOfNumbers[i].textBox.Top -= 11;
        }

        public void DeleteEmail(int index)
        {
            ListOfEmails.RemoveAt(index);
            for (int i = index; i < ListOfEmails.Count; i++)
                ListOfEmails[i].textBox.Top -= 11;
        }

        public void ChangeName(string Name) => this.Name = Name;

        public void ChangeAdress(string Adress) => this.Adress = Adress;

        public void ChangeBDay(string date)
        {
            BDay = date;
        }

        public void NumEmVisible()
        {
            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                ListOfNumbers[i].textBox.Visible = true;
            }
            for (int i = 0; i < ListOfEmails.Count; i++)
            {
                ListOfEmails[i].textBox.Visible = true;
            }
        }

        public void NumEmUnvisible()
        {
            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                ListOfNumbers[i].textBox.Visible = false;
            }
            for (int i = 0; i < ListOfEmails.Count; i++)
            {
                ListOfEmails[i].textBox.Visible = false;
            }
        }

        public void NumEmReadonlyFalse()
        {
            for (int i = 0; i < ListOfNumbers.Count; i++)
                ListOfNumbers[i].textBox.ReadOnly = false;
            for (int i = 0; i < ListOfEmails.Count; i++)
                ListOfEmails[i].textBox.ReadOnly = false;
        }

        public void NumEmReadonlyTrue()
        {
            for (int i = 0; i < ListOfNumbers.Count; i++)
                ListOfNumbers[i].textBox.ReadOnly = true;
            for (int i = 0; i < ListOfEmails.Count; i++)
                ListOfEmails[i].textBox.ReadOnly = true;
        }

        public bool CheckPerson()
        {
            if (Name == "")
                return false;
            for (int i = 0; i < ListOfEmails.Count; i++)
            {
                if (ListOfEmails[i].textBox.Text == "")
                    DeleteEmail(i);
            }
            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                if (!ListOfNumbers[i].Check_number())
                    return false;
            }

            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                if (ListOfNumbers[i].textBox.Text == "")
                    DeleteNumber(i);
                else
                {
                    if (!ListOfNumbers[i].Check_number())
                        return false;
                }
            }
            if (!CheckBDate() && BDay != "")
                return false;
            return true;
        }

        private bool CheckBDate() => Regex.IsMatch(BDay, @"^(00|0?[1-9]|[12][0-9]|3[01])[./-]([0]?[1-9]|[12][0-9]|[3][01])[./-]([0-9]{4}|[0-9]{2})$");

        public override string ToString()
        {
            string buf = Name + "\n";
            for (int i = 0; i < ListOfNumbers.Count; i++)
            {
                buf += "    " + (i + 1) + ") ";
                buf += ListOfNumbers[i];
            }
            return buf;
        }
    }

    internal class ListOfContacts
    {
        public readonly List<Person> People;

        public ListOfContacts() => People = new List<Person>();

        public void AddNewContact(Person person) => People.Add(person);

        public void AddNumber(Number number, int index) => People[index].AddNumber(number);

        public void AddEmail(Email email, int index) => People[index].AddEmail(email);

        public void DeletePerson(int index, Form1 form)
        {
            for (int i = 0; i < People[index].ListOfNumbers.Count; i++)
                form.Controls.Remove(People[index].ListOfNumbers[i].textBox);
            for (int i = 0; i < People[index].ListOfEmails.Count; i++)
                form.Controls.Remove(People[index].ListOfEmails[i].textBox);
            People.RemoveAt(index);
        }

        public Person GetPerson(int index) => People[index];

        public override string ToString()
        {
            string buf = "";
            for (int i = 0; i < People.Count; i++)
            {
                buf += i + 1 + ". ";
                buf += People[i];
            }
            return buf;
        }
    }
}