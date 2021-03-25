// L0002B Inl 1
// Mikaela Eriksson
// Username: mikerv-0

using System;
using System.Windows.Forms;

namespace WindowsFormsAppInlupp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        // When the ok button is clicked, the following code is executed
        private void okButton_Click(object sender, EventArgs e)
        {
            // Checks if the input for price and paid are valid (integer, not null and not empty)
            if (!String.IsNullOrEmpty(textBoxPris.Text) && !String.IsNullOrEmpty(textBoxBetalt.Text) &&
               int.TryParse(textBoxPris.Text, out _) && int.TryParse(textBoxBetalt.Text, out _))
            {
               
                    int pris = Int32.Parse(textBoxPris.Text);
                    int betalt = Int32.Parse(textBoxBetalt.Text);

                    int total = betalt - pris;
                    int total_vaxel = betalt - pris;

                    if (betalt < pris)
                    {
                        textBoxResult.Text = "Du har betalat för lite. Det saknas " + total * (-1) + " kr.";
                    }
                    else if (betalt == pris)
                    {
                        textBoxResult.Text = "Tack, du har betalt tillräckligt!";
                    }
                    else if (betalt > pris)
                    {

                        var femhundra_var = "";
                        var hundra_var = "";
                        var femtio_var = "";
                        var tjugo_var = "";
                        var tio_var = "";
                        var fem_var = "";
                        var ett_var = "";

                        int femhundra, hundra, femtio, tjugo, tio, fem, ett;

                        while (total >= 500)
                        {
                            //Räknar antalet 500-lappar
                            femhundra = total / 500;
                            total = total % 500;
                            femhundra_var = femhundra.ToString() + " Femhundralappar\r\n";

                        }

                        while (total >= 100)
                        {
                            //Räknar antalet 100-lappar
                            hundra = total / 100;
                            total = total % 100;
                            //textBoxResult.Text = hundra + " Hundralappar\r\n";
                            hundra_var = hundra.ToString() + " Hundralappar\r\n";
                        }
                        while (total >= 50)
                        {
                            //Räknar antalet 50-lappar
                            femtio = total / 50;
                            total = total % 50;
                            femtio_var = femtio.ToString() + " Femtiolappar\r\n";
                        }
                        while (total >= 20)
                        {
                            //Räknar antalet 20-lappar
                            tjugo = total / 20;
                            total = total % 20;
                            tjugo_var = tjugo.ToString() + " Tjugolappar\r\n";
                        }
                        while (total >= 10)
                        {
                            //Räknar antalet 10-kronor
                            tio = total / 10;
                            total = total % 10;
                            tio_var = tio.ToString() + " Tiokronor\r\n";
                        }
                        while (total >= 5)
                        {
                            //Räknar antalet 5-kronor
                            fem = total / 5;
                            total = total % 5;
                            fem_var = fem.ToString() + " Femkronor\r\n";
                        }
                        while (total >= 1)
                        {
                            //Räknar antalet 1-kronor
                            ett = total / 1;
                            total = total % 1;
                            ett_var = ett.ToString() + " Enkronor\r\n";
                        }

                        // Counts the total change and which values
                        textBoxResult.Text = "Växel tillbaka: " + total_vaxel + " kr" + "\n" +
                        femhundra_var + hundra_var + femtio_var +
                        tjugo_var + tio_var + fem_var + ett_var;
                    }
                

            }
            else
                textBoxResult.Text = "Fyll i siffervärden för pris och betald summa!";
        }

        // Methods for the textbox fields
        #region Textbox Methods
        private void textBoxPris_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxBetalt_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
