using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TextFileDataAccessDemoGUI
{
    public partial class Form1 : Form
    {
        List<Person> people = new List<Person>();

        public Form1()
        {
            InitializeComponent();
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            peopleListBox.DataSource = null; // Clear the current data source binding
            peopleListBox.DataSource = people;
            peopleListBox.DisplayMember = "DisplayInfo";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Person newPerson = new Person
            {
                firstName = firstName.Text,
                lastName = lastName.Text,
                url = URL.Text
            };
            people.Add(newPerson);
            UpdateListBox();
        }

        private void save_Click(object sender, EventArgs e)
        {
            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{person.firstName},{person.lastName},{person.url}");
            }

            string outPath = @"C:\Users\Shadow\Documents\peopleOut.txt";
            File.WriteAllLines(outPath, output);
        }

        private void load_Click(object sender, EventArgs e)
        {
            string filepath = @"C:\Users\Shadow\Documents\test.txt";
            List<string> lines = File.ReadAllLines(filepath).ToList();

            int lineNumber = 0;
            foreach (string line in lines)
            {
                lineNumber++;
                string[] entries = line.Split(',');

                //error handling for incorrect number of entries per line
                if (entries.Length != 3)
                {
                    Console.WriteLine($"Error: Expected 3 entries on line: {lineNumber}, but found {entries.Length}");
                    continue;
                }

                Person p = new Person();
                p.firstName = entries[0];
                p.lastName = entries[1];
                p.url = entries[2];

                people.Add(p);
                UpdateListBox();
            }
        }
    }
}
