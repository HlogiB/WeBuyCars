namespace WeBuyCars
{
    public partial class MainPage : Form
    {
        string details = " ";
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void displayform2(string car, int price,string picName)
        {
            //this function calls the second form when ever an image is clicked
            //the fucntion accepts three parameteres then later passes it to the form parameteres 
            //this function elimimantes the need to create separate forms for each car.
            Form secondPage = new SecondPage(car, price,picName);
            secondPage.Show();
            this.Hide();
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void polo_Click(object sender, EventArgs e)
        {
            
             details = "2015 Polo Trendline 70 000KM";
            displayform2(details,250000,"Polo");//implementation of the function described above 
            
        }

        private void Etios_Click(object sender, EventArgs e)
        {
            details = "2012 Toyota Etios 70 000KM ";
            displayform2(details, 150000,"Etios");
        }

        private void kwid_Click_1(object sender, EventArgs e)
        {
            details = "2018 Renault Kwid 16 000KM";
            displayform2(details, 110000,"kwid");
        }

        private void Go_Click(object sender, EventArgs e)
        {
            details = "2020 Datsun Go 20 000KM";
            displayform2(details, 105000,"Go");
        }

        private void Suzuki_Click(object sender, EventArgs e)
        {
            details = "1997 Suzuki WorkHouse 110 000KM";
            displayform2(details, 50000,"suzuki");
        }

        private void fiat_Click(object sender, EventArgs e)
        {
            details = "2017 Fiat 100C 10 000KM";
            displayform2(details, 140000,"fiat");
        }
    }
}