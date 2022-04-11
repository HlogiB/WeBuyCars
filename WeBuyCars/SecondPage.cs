using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeBuyCars
{
    public partial class SecondPage : Form
    {
        
        public SecondPage(String carDetails,double price,String nameOfPic)//the form allows three paramters 
            //this parameters include all the details of the car as well as the name of the picture of the car
            //the image is loaded by using the location that is stored at. 
        {
            InitializeComponent();
            CarDetailsLabel.Text=carDetails;
            normalPriceLabel.Text = "R"+price.ToString();
            pictureBox1.ImageLocation = "C:\\Users\\BaleL\\source\\repos\\WeBuyCars\\WeBuyCars\\images\\"+ nameOfPic+".jpg";
            pictureBox1.SizeMode=PictureBoxSizeMode.Zoom;             
           
        }

        private void SecondPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void depTxtBox_TextChanged(object sender, EventArgs e)
        {
            
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (depTxtBox.Text.Length != 0)
            {
                try
                {
                    string price = normalPriceLabel.Text.Remove(0,1).Trim();                   
                    Int64 normalPrice = Int64.Parse(price);
                    Int64 depositPrice = Int64.Parse(depTxtBox.Text);

                    if (depositPrice > normalPrice)
                    {
                        MessageBox.Show("The deposit can not be greater than the selling price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        depTxtBox.Clear();
                        depTxtBox.Focus();
                    }
                    else
                    {
                        decimal totalPrice = performCalculations(depositPrice, normalPrice);
                        label11.Text = "R" + (totalPrice).ToString();
                        getMonthlyRates(totalPrice);

                    }
                }
                catch (FormatException)//the exception will raise if the user enters non numeric data in the deposit box
                {
                    MessageBox.Show("Please ensure you have entered numbers only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    depTxtBox.Clear();
                    depTxtBox.Focus();
                }
            }
            else//this will display if the user does not insert any data in the deposit textbox
            {
                MessageBox.Show("Please enter the deposit", "Deposit", MessageBoxButtons.OK, MessageBoxIcon.Information);
                depTxtBox.Focus();
            }
           

        }

        private void getMonthlyRates(decimal totalPrice)
        {
            //the function will return the monthly payment that the user will pay
            
            if (rdBtn36.Checked)
                totalPrice = totalPrice / 36;
            else if (rdBtn72.Checked)
                totalPrice = totalPrice / 72;
            else if (rdBtn48.Checked)
                totalPrice = totalPrice / 48;
            else
                totalPrice = totalPrice / 60;
            label10.Text = "R" + totalPrice.ToString("n2");

        }

        private decimal performCalculations(Int64 depositPrice, Int64 normalPrice)
        {  
            //the fucntion will calculate the total Price of the car with the interest rate included 
            
            decimal percentage = percNum.Value / 100;
            decimal totalPrice = (normalPrice - depositPrice);
            totalPrice = totalPrice + (totalPrice * percentage);
            return totalPrice;
        }


        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void label5_Click(object sender, EventArgs e)
        {
            //when the label is clicked the user will be redirected to the main page 
            new MainPage().Show();
            this.Close();
        }

        private void normalPriceLabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
