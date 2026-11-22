using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*************************
* Name: Kerem Goldagi
* Class: ITD-2343-60486
* Trimester: Fall 2026
* Due Date: 10/14/2026
*************************/  

namespace Project5Goldagi
{
    public partial class frmChoices : Form
    {
        public frmChoices()
        {
            InitializeComponent();
        }

        private void frmChoices_Load(object sender, EventArgs e)
        {


        }
          
        private void btnCheck_Click(object sender, EventArgs e)
        {


            Random number = new Random();

            txtLeftNumber.Text = number.Next(-1000, 1000).ToString();


            string sNumberToCheck = txtNumberToCheck.Text;
            string sLeftNumber = txtLeftNumber.Text;
            string sRightNumber = txtRightNumber.Text;
            int dLeftNumber = Convert.ToInt32(1000);
            int dRightNumber = Convert.ToInt32(1000);
            int dNumberToCheck;


            //
            // Check if the input is a valid decimal number
            //
            if (!int.TryParse(sNumberToCheck, out dNumberToCheck))
            {
                lblDisplayMessage.Text = "Oh, no!!! Please enter a positive number. You've got this!";
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
                return;
            }
            //
            //
            // Check if the input equal to the left number
            //
            if (dNumberToCheck == dLeftNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is equal to the left number! Make a wish!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            //
            // Check if the input equal to the right number
            //
            if (dNumberToCheck == dRightNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is equal to the right number! Make a wish!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            // Check if the input is smaller than the left number
            //
            //
            if (dNumberToCheck < dLeftNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is smaller than the left number. Go higher!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            //
            // Check if the input is larger than the right number
            //
            if (dNumberToCheck > dRightNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is larger than the right number. Go lower!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            //
            // Check if the input is within the range of the left and right numbers
            //
            if (dNumberToCheck >= dLeftNumber && dNumberToCheck <= dRightNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is within the range of the left and right numbers. Excellent job!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            //
            // Check if the input is a positive number
            //
            if (dNumberToCheck <= 0)
            {
                lblDisplayMessage.Text = "Oh, no!!! Please enter a positive number. You've got this!";
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplayMessage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
