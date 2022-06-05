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
            StreamWriter file = new StreamWriter(@"C: \Users\PC\source\repos\Contact Tracing Form\Contact Tracing Form\Form Data Input.txt", true);
            file.WriteLine("Name:" + SNtxtbx + ", " + FNtxtbx + MNtxtbx);
            file.WriteLine("Email:" + Emailtxtbx);
            file.WriteLine("Contact Number:" + ConNumtxtbx);
            file.Close();
            
        }
    }
}