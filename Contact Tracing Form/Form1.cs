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

            // Personal Details
            string SN = SNtxtbx.Text;
            string FN = FNtxtbx.Text;
            string MN = MNtxtbx.Text;
            string Address = FAddresstxtbx.Text;
            string City = Citytxtbx.Text;
            string Email = Emailtxtbx.Text;
            string ConNum = ConNumtxtbx.Text;
            
            // date and time-in
            string Month = Monthtxtbx.Text;
            string Day = Daytxtbx.Text; 
            string Year = Yeartxtbx.Text;

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
            if (Month.Length > 0)
            {
                counter++;
            }
            if (Day.Length > 0)
            {
                counter++;
            }
            if (Year.Length > 0)
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


            //StreamWriter condition

            if (counter != 12)
            {
                MessageBox.Show("A detail was left unfilled. Please complete all the blanks. If no answer for the given, please input n/a.");
            }
            else
            {

                StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt", true);
                file.WriteLine(" ");
                file.WriteLine("New input");
                file.WriteLine("Date: " + Month + "/" + Day + "/" + Year);
                file.WriteLine("Time: " + Time_in + " " + am_pm);
                file.WriteLine("Name: " + SN + ", " + FN + " " + MN);
                file.WriteLine("Email: " + Email + " | " + "Contact Number: " + ConNum);
                file.WriteLine("Address: " + Address + " | " + "City: " + City);
                file.Close();

                MessageBox.Show("Data has been saved! You may now proceed.");
                Application.Restart();
                Environment.Exit(0);

            }    
        }
    }
}