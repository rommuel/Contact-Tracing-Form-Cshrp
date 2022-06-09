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
            
            StreamWriter writer = new(@"C:\Users\PC\Documents\CT-output.txt", true);
            {
                writer.WriteLine("New Input:");
                writer.WriteLine("Name:" + SNtxtbx + ", " + FNtxtbx + MNtxtbx);
                writer.WriteLine("Email:" + Emailtxtbx);
                writer.WriteLine("Contact Number:" + ConNumtxtbx);
                
            }

        }
    }
}