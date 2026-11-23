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
* Due Date: 11/18/2026
*************************/  

namespace Project5Goldagi
{
    public partial class frmComparison : Form
    {
        public frmComparison()
        {
            InitializeComponent();
        }

        private void frmChoices_Load(object sender, EventArgs e)
        {
            txtLeftNumber.Text = "";
            txtRightNumber.Text = "";

        }

        //
        // Generate left and right numbers, validate inputs and return display message
        //
        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            Random random = new Random();
            
            int leftNumber = random.Next(1, 999);
            int rightNumber = random.Next(leftNumber + 1, 1001);

            leftNumber = Math.Min(leftNumber, rightNumber);
            rightNumber = Math.Max(leftNumber, rightNumber);
            int dLeftNumber = leftNumber;
            int dRightNumber = rightNumber;

            txtLeftNumber.Text = dLeftNumber.ToString();
            txtRightNumber.Text = dRightNumber.ToString();

            string sNumberToCheck = txtNumberToCheck.Text;
            string sLeftNumber = txtLeftNumber.Text;
            string sRightNumber = txtRightNumber.Text;
            int LeftNumber = Convert.ToInt32(sLeftNumber);
            int RightNumber = Convert.ToInt32(sRightNumber);
            int dNumberToCheck = 0;

            ComparisonClass comparison = new ComparisonClass(LeftNumber, RightNumber, dNumberToCheck);

            lblDisplayMessage.Text = comparison.GetComparison();

            txtNumberToCheck.Text = "";
            txtNumberToCheck.Focus();


           
            if (!int.TryParse(sNumberToCheck, out dNumberToCheck))
            {
                lblDisplayMessage.Text = "Oh, no!!! Please enter a positive number. You've got this!";
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
                return;
            }

            if (dNumberToCheck == dLeftNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is equal to the left number! Fantastic!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            if (dNumberToCheck == dRightNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is equal to the right number! Fantastic!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            if (dNumberToCheck > dLeftNumber && dNumberToCheck < dRightNumber)
            {
                lblDisplayMessage.Text = dNumberToCheck + " is within the range of the left and right numbers. Excellent job!";
                txtLeftNumber.Text = dLeftNumber.ToString();
                txtRightNumber.Text = dRightNumber.ToString();
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }

            if (dNumberToCheck <= 0)
            {
                lblDisplayMessage.Text = "Oh, no!!! Please enter a positive number. You've got this!";
                txtNumberToCheck.Text = "";
                txtNumberToCheck.Focus();
            }
        }

        //
        // Clear the input fields and the display message
        //
        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplayMessage.Text = "";
            txtLeftNumber.Text = "";
            txtRightNumber.Text = "";
            txtNumberToCheck.Text = "";
        }

        //
        // Exit the application
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }  
    }
}
