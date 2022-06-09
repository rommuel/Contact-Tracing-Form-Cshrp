namespace Contact_Tracing_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            // Defining Inputs as variables
            string SN = SNtxtbx.Text;
            string FN = FNtxtbx.Text;
            string MN = MNtxtbx.Text;
            string Address = FAddresstxtbx.Text;
            string City = Citytxtbx.Text;
            string Email = Emailtxtbx.Text;
            string ConNum = ConNumtxtbx.Text;
            string Time_in = Timetxtbx.Text;
            string am_pm = ampmtxtbx.Text;

            // To avoid unfilled details
            byte counter = 0;

            if (SN.Length > 0)
            {
                counter++;
            }
            if (FN.Length > 0)
            {
                counter++;
            }
            if (MN.Length > 0)
            {
                counter++;
            }
            if (Address.Length > 0)
            {
                counter++;
            }
            if (City.Length > 0)
            {
                counter++;
            }
            if (Email.Length > 0)
            {
                counter++;
            }
            if (ConNum.Length > 0)
            {
                counter++;
            }
            if (Time_in.Length > 0)
            {
                counter++;
            }
            if (am_pm.Length > 0)
            {
                counter++;
            }

            if (counter != 9)
            {
                MessageBox.Show("A detail was left unfilled. Please complete all the blanks.");
                
            }









            StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt");
            file.WriteLine("Name: " + SN + ", " + FN + " " + MN);
            file.WriteLine("Time: " + Time_in + " " + am_pm);
            file.WriteLine("Email: " + Email + " | " + "Contact Number: " + ConNum);
            file.WriteLine("Address: " + Address + " | " + "City: " + City);
            file.Close();   
                
        }
    }
}