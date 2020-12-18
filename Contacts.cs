﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Kurs
{
    internal struct Number
    {
        private System.Windows.Forms.TextBox textBox;

        public Number(string number)
        {
            textBox = new System.Windows.Forms.TextBox();
            textBox.Visible = false;
            textBox.Text = number;
        }

        public bool Check_number(string data) => textBox.Text.Contains(data);

        public void Change_number(string new_number) => textBox.Text = new_number;

        public string ForVcard() => "TEL;HOME:" + textBox.Text + "\n";

        public override string ToString() => textBox.Text;
    }

    internal struct Person
    {
        public string Name;
        public List<Number> list_of_numbers;

        public void Add_number(Number buf) => list_of_numbers.Insert(list_of_numbers.Count, buf);

        public Person(string new_name)
        {
            Name = new_name;
            list_of_numbers = new List<Number>();
        }

        public void Delete_number(int index) => list_of_numbers.RemoveAt(index);

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

        public bool Check_name(string data) => Name.Contains(data);

        public bool Check_numbers(string data)
        {
            for (int i = 0; i < list_of_numbers.Count; i++)
                if (list_of_numbers[i].Check_number(data)) return true;
            return false;
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
            people.Insert(people.Count, person);
        }

        public void Add_number(Number number, int index) => people[index].Add_number(number);

        public ListOfContacts Find_contacts(string data)
        {
            List<Person> buf_list = new List<Person>();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].Check_name(data))
                    buf_list.Insert(buf_list.Count, people[i]);
                else
                if (people[i].Check_numbers(data))
                    buf_list.Insert(buf_list.Count, people[i]);
            }
            ListOfContacts return_value = new ListOfContacts(buf_list);
            return return_value;
        }

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