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

        public Email(string email, Point Location)
        {
            textBox = new System.Windows.Forms.TextBox();
            textBox.Visible = true;
            textBox.Location = Location;
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
        public List<Number> list_of_numbers;
        public List<Email> list_of_emails;

        public void Add_number(Number buf)
        {
            list_of_numbers.Add(buf);
        }

        public void Add_email(Email buf)
        {
            list_of_emails.Add(buf);
        }

        public Person(string new_name)
        {
            Name = new_name;
            list_of_numbers = new List<Number>();
            list_of_emails = new List<Email>();
        }

        public void Delete_number(int index)
        {
            list_of_numbers.RemoveAt(index);
            for (int i = index; i < list_of_numbers.Count; i++)
                list_of_numbers[i].textBox.Top -= 11;
        }

        public void Delete_email(int index)
        {
            list_of_emails.RemoveAt(index);
            for (int i = index; i < list_of_emails.Count; i++)
                list_of_emails[i].textBox.Top -= 11;
        }

        public void NumEmVisibleSwitch()
        {
            for (int i = 0; i < list_of_numbers.Count; i++)
            {
                list_of_numbers[i].textBox.Visible = !list_of_numbers[i].textBox.Visible;
            }
            for (int i = 0; i < list_of_emails.Count; i++)
            {
                list_of_emails[i].textBox.Visible = !list_of_emails[i].textBox.Visible;
            }
        }

        public override string ToString()
        {
            string buf = Name + "\n";
            for (int i = 0; i < list_of_numbers.Count; i++)
            {
                buf += "    " + (i + 1) + ") ";
                buf += list_of_numbers[i];
            }
            return buf;
        }
    }

    internal class ListOfContacts
    {
        public List<Person> people;

        public ListOfContacts() => people = new List<Person>();

        public ListOfContacts(List<Person> buf) => people = buf;

        public void Add_new_contact(string name)
        {
            Person person = new Person(name);
            people.Add(person);
        }

        public void Add_number(Number number, int index) => people[index].Add_number(number);

        public void Add_Email(Email email, int index) => people[index].Add_email(email);

        public override string ToString()
        {
            string buf = "";
            for (int i = 0; i < people.Count; i++)
            {
                buf += i + 1 + ". ";
                buf += people[i];
            }
            return buf;
        }
    }
}
