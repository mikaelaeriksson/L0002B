using System;
using System.Windows.Forms;

// Mikaela Eriksson mikerv-0 9410122163 L0002B task 3

namespace Inlupp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     
        private void submitButton_Click(object sender, EventArgs e)
        {
            Person person;
            // Create a Person with the given input if personal number is valid 
            try
            {
                person = new Person(firstNameTextBox.Text, LastNameTextBox.Text, pNumberTextBox.Text);
                showNameLabel.Text = $"{person.firstName} {person.lastName}";
                showPNoLabel.Text = person.pNumber;
                showGenderLabel.Text = Person.CheckGender(person.pNumber);
            }
            // If personal number is invalid
            catch (Exception)
            {
                showNameLabel.Text = "";
                showPNoLabel.Text = "";
                showGenderLabel.Text = "Invalid personal number";
            }
        }

        // Clear all fields when clearButton is pressed
        private void clearButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            pNumberTextBox.Text = "";
            showNameLabel.Text = "";
            showPNoLabel.Text = "";
            showGenderLabel.Text = "";
        }

    }
}
