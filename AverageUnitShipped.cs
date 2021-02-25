// Author - Devanshu Dave
// Date = 22/01/2021
// Student ID - 100785733
// Description - This application will have the user to claculate the avrage of the units that were shiped in 7 days
//              This form will give the user 3 button - cancel, enter and exit. This will calculate the average.
//              The form will  increment the value of the days as per the inputs and will save that to the 
//              past entry box where user can track it. Thus, This form will let the user to calculate the average.





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageUnitShipped
{
    public partial class formAverageUnitShipped : Form
    {
        // Declared shipday value = 1
        int shipedday = 1;
        // Declared the totalUnitShiped = 0
        int totalUnitShiped = 0;
        public formAverageUnitShipped()
        {
            InitializeComponent();
            
        }

        private void AverageUnitShipped_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
            // Declaring constants for Minumum value for the form as 0
            const int MininimunUnits = 0;
            // Declaring the maximum value of maximum value of the form as 5000
            const int MaximimumUnits = 5000;
            // Declaring the maximum values of days as 7
            const int MaximumDays = 7;
            // Declaring the last entry variable
            int lastEntry;

             // If....else for an integer
            if (int.TryParse(textboxInputNumbers.Text,out lastEntry))
            {
                // If yes...then it will check the entry between MinimumUnits and MaximumUnits.
                if(lastEntry>=MininimunUnits && lastEntry<=MaximimumUnits)
                {

                    textBoxPastInputs.Text += lastEntry + "\r\n";
                    // increment
                    totalUnitShiped += lastEntry;
                    // increment by day 1
                    shipedday++;
                    // Clearing the text box input area.
                    textboxInputNumbers.Clear();

                    // if  shiped day is larger than maximum days(7)
                    if(shipedday > MaximumDays)
                    {
                        // Calculating the average.
                        double averageUnits;
                        averageUnits = (double)totalUnitShiped / (double)MaximumDays;

                        // output
                        labelOutput.Text = "Average per day : " + Math.Round(averageUnits,2);

                        // disable
                        textboxInputNumbers.Enabled = false;
                        buttonToEnter.Enabled = false;
                        // Set the focus on reset button.
                        buttontoReset.Focus();

                        
                    }
                    else
                    {
                        // printing the day  shiped day on day label.
                        labelDay.Text = "Day" + shipedday;
                        // Set the focus on the text box input area.
                        textboxInputNumbers.Focus();

                    }

                }
                else
                {
                    // The value is less than 0 or greater than 5000
                    MessageBox.Show("Enter a value between " + MininimunUnits +
                        " and " + MaximimumUnits + "." + " Invalid Entry!");
                    textboxInputNumbers.SelectAll();
                    textboxInputNumbers.Focus();
                    textboxInputNumbers.Clear();

                }


            }
            else
            {
                //number is not an integer
                MessageBox.Show("Enter a Number", "Invalid Entry");
                textboxInputNumbers.SelectAll();
                textboxInputNumbers.Focus();
                textboxInputNumbers.Clear();
            }
        }
        /// <summary>
        ///     This button resets the form when user clicks this. It resets the entry field, day label,
        ///    output box. This button makes the form as a newer piece.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButtonClick(object sender, EventArgs e)
        {
            // Clears the input area.
            textboxInputNumbers.Clear();
            // inputs the past input box
            textBoxPastInputs.Clear();
            // cleears the output field by making it empty.
            labelOutput.Text = String.Empty;
            // reseting the shiped day (Day label) to 1 (Day 1)
            shipedday = 1;
            // Making total unit shiped to 0
            totalUnitShiped = 0;

            // enabling the textbox entry for new field.
            textboxInputNumbers.Enabled = true;
            // enabling the enter button to true for new entr.
            buttonToEnter.Enabled = true;
            // To focus on entry input field
            textboxInputNumbers.Focus();
            // Making back to day1 
            labelDay.Text = "Day" + shipedday;

        }
        /// <summary>
        ///     This Button closes the form(Average Unit SHIPPED). When user clicks this then this form will
        ///     close the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitButtonClick(object sender, EventArgs e)
        {
            // Closing the form whenever the close button been clicked.
            Close();
        }
    }
}
