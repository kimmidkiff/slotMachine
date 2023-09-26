using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Kimberly Midkiff
// COP2360
// SPC ID 2319889

// Pseudocode
// use an image list to hold the fruit photos 
// make a method that generates a random index in the list 
// and displays the photo with the corresponding index
// determine the dollar amount won or lost
// return the dollar amount
// add coding to the spin button to call to the method
// display the dollars won or lost

namespace Slot_Machine

{
 

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        public int FruitPictures(ref int dollars)
        {
            // create a method that generates a random index from the image list
            Random rand = new Random();

            int random1 = rand.Next(fruitImageList.Images.Count);
            int random2 = rand.Next(fruitImageList.Images.Count);
            int random3 = rand.Next(fruitImageList.Images.Count);

            // assign the corresponding photos to a picture box
            fruitPicture1.Image = fruitImageList.Images[random1];
            fruitPicture2.Image = fruitImageList.Images[random2];
            fruitPicture3.Image = fruitImageList.Images[random3];

            // determine the dollars won or lost
            if ((random1 == random2) && (random1 == random3) && (random2 == random3))
            {
                MessageBox.Show("You matched all 3! That's TRIPLE your money!");
                dollars *= 3;
            }
            else if ((random1 == random2) || (random1 == random3) || (random2 == random3))
            {
                MessageBox.Show("You matched 2! Thats double your money!");
                dollars *= 2;
            }
            else
            {
                MessageBox.Show("Bummer! Not a winner.");
                dollars -= 1;
            }

            // send the amount for dollars out of the method
            return dollars;
            
        }

        private void spinButton_Click(object sender, EventArgs e)
        {

            if (amountInsertedTextBox.Text.Equals(""))
            {
                MessageBox.Show("Enter a dollar amount to start");

            }

            else
            {
                // change the amount form string to int 
                int dollars = int.Parse(amountInsertedTextBox.Text);

                // call to the method
                FruitPictures(ref dollars);

                // display the new dollar amount
                amountInsertedTextBox.Text = dollars.ToString();
            }

            

            

        }

        private void exitButton_Click(object sender, EventArgs e) 
        {
            // close the program
            this.Close();
        }
    }
}
