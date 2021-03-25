using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{

    /// <summary>
    ///  A basic calculator 
    /// </summary>
    public partial class Form1 : Form
    {

        #region Constructor 
        /// <summary>
        ///  Default Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Clearing Methods

        /// <summary>
        ///  Clears the user input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">The event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            // Clears the text from the user input text box
            this.UserInputText.Text = string.Empty;

            // Focus the user input text
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.Text.Length >= this.UserInputText.SelectionStart + 1)
                this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
            
            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Operator Methods 

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();

            // Focus the user input text
            FocusInputText();
        }

      

        private void DivButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");

            // Focus the user input text
            FocusInputText();
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("*");

            // Focus the user input text
            FocusInputText();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");

            // Focus the user input text
            FocusInputText();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        #region Number Methods

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");

            // Focus the user input text
            FocusInputText();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");

            // Focus the user input text
            FocusInputText();
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");

            // Focus the user input text
            FocusInputText();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");

            // Focus the user input text
            FocusInputText();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");

            // Focus the user input text
            FocusInputText();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");

            // Focus the user input text
            FocusInputText();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");

            // Focus the user input text
            FocusInputText();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");

            // Focus the user input text
            FocusInputText();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");

            // Focus the user input text
            FocusInputText();
        }

        /// <summary>
        ///  Assigning a 0 to the input text field value where the cursor is placed (same with all other numbers)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");

            // Focus the user input text
            FocusInputText();
        }


        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");

            // Focus the user input text
            FocusInputText();
        }

        #endregion

        /// <summary>
        ///  Calculates the given equation and outputs the answer to the user label
        /// </summary>
        private void CalculateEquation()
        {
            // TODO!!

            // Focus the user input text
            FocusInputText();
        }

        #region Private Helpers

        /// <summary>
        /// Focuses the user input text
        /// </summary>
        private void FocusInputText()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts the given text into the user input text box
        /// </summary>
        /// <param name="value">The value to insert</param>
        private void InsertTextValue(string value)
        {

            // Remember selection start
            var selectionStart = this.UserInputText.SelectionStart;

            // Set new text
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);

            // Restore the selection start
            this.UserInputText.SelectionStart = selectionStart + value.Length;

            // Set selection length to zero
            this.UserInputText.SelectionLength = 0;

        }

        #endregion 
    }
}
