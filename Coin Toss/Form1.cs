using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowCoinStatus(Coin coin)
        {
            MessageBox.Show("This side of the coin is up: " +
                coin.GetSideUp());
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //create a new Coin() object.
            Coin myCoin = new Coin();

            //Clear the ListBox
            outputListBox.Items.Clear();

            //Toss the coin 5 times.
            for (int count = 0; count < 5; count++)
            {
                //Toss the coin.
                myCoin.Toss();

                //messagebox to show the side of the coin that it landed on.
                ShowCoinStatus(myCoin);

                //Display the side that is up.
                outputListBox.Items.Add(myCoin.GetSideUp());

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form.
            this.Close();
        }
    }
}
