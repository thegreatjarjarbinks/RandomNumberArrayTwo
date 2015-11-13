/*
 * Created by: Alex Mathias
 * Created on: 13-Nov-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 5-02
 * This program checks if the number was found or not.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNumberArray
{
    public partial class frmRandomNumberArray : Form
    {
        public bool ArrayCheck(int[] array, int chosenNumber)
        {
            bool theValueExists = false;

            foreach (int number in array)
            {
                if (number == chosenNumber)
                {
                    theValueExists = true;
                }
            }
            return theValueExists;

        }
        public frmRandomNumberArray()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            //Variables
            bool theValueExists;
            int[] numbers = new int[5];
            Random rnd = new Random();

            //Process
            for (int counter = 0; counter < 5; counter++)
            {
                numbers[counter] = rnd.Next(1, 10 + 1);
            }

            theValueExists = ArrayCheck(numbers, 4);

            if(theValueExists == true)
            {
                this.lblNumber.Text = "The number was found";
            }
            else
            {
                this.lblNumber.Text = "The number was not found";
            }
        }
    }
}
