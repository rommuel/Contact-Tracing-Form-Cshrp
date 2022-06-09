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

            
            StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt");
            file.WriteLine("Name: " + SN + ", " + FN + " " + MN);
            file.WriteLine("Time: " + Time_in + am_pm);
            file.WriteLine("Email: " + Email + " | " + "Contact Number: " + ConNum);
            file.WriteLine("Address: " + Address + " | " + "City: " + City);
            file.Close();   
                
        }
    }
}