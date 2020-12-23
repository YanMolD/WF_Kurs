using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WF_Kurs
{
    [Serializable]
    internal struct Number
    {
        public string number;

        public Number(string number)
        {
            this.number = number;
        }

        public void Change_number(string new_number) => number = new_number;

        public string ForVcard() => "TEL;HOME;VOICE:" + number + "\n";

        public override string ToString() => number;
    }

    [Serializable]
    internal struct Email
    {
        public string email;

        public Email(string email)
        {
            this.email = email;
        }

        public void ChangeEmail(string newEmail) => email = newEmail;

        public string ForVcard() => "EMAIL;TYPE=INTERNET:" + email + "\n";

        public override string ToString() => email;
    }

    [Serializable]
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

        public void DeleteNumber(int index) => ListOfNumbers.RemoveAt(index);

        public void DeleteEmail(int index) => ListOfEmails.RemoveAt(index);

        public void ChangeName(string Name) => this.Name = Name;

        public void ChangeAdress(string Adress) => this.Adress = Adress;

        public void ChangeBDay(string date) => BDay = date;

        public bool CheckPerson()
        {
            if (Name == "")
                return false;
            if (!CheckBDate() && BDay != "")
                return false;
            return true;
        }

        private bool CheckBDate() => Regex.IsMatch(BDay, @"^([0-9]{4})[\-]([0]?[1-9]|[1][0-2])[\-](0?[1-9]|[12][0-9]|3[01])$");

        public override string ToString()
        {
            string buf = "BEGIN:VCARD\n";
            buf += "VERSION:2.1\n";
            buf += $"N:{Name}\n";
            buf += $"FN:{Name}\n";
            for (int i = 0; i < ListOfNumbers.Count; i++)
                buf += ListOfNumbers[i].ForVcard();
            if (Adress != "")
                buf += $"ADR;WORK;PREF;CHARSET=utf-8:;;{Adress};;;;Россия\nLABEL;WORK;PREF:{Adress}\n";
            if (BDay != "")
                buf += $"BDAY:{BDay.Substring(0, 4) + BDay.Substring(5, 2) + BDay.Substring(8, 2)}\n";
            for (int i = 0; i < ListOfEmails.Count; i++)
                buf += ListOfEmails[i].ForVcard();
            buf += "END:VCARD";
            return buf;
        }
    }

    [Serializable]
    internal class ListOfContacts
    {
        public readonly List<Person> People;

        public ListOfContacts() => People = new List<Person>();

        public void AddNewContact(Person person) => People.Add(person);

        public void AddNumber(Number number, int index) => People[index].AddNumber(number);

        public void AddEmail(Email email, int index) => People[index].AddEmail(email);

        public void DeletePerson(int index)
        {
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
