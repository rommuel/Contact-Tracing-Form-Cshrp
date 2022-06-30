namespace Contact_Tracing_Form
{
    using QRCoder;
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
                file.WriteLine("Name: " + SN + ", " + FN + " " + MN + " " + "Email: " + Email + " | " + "Contact Number: " + ConNum + "Address: " + Address + " | " + "City: " + City + " " + "Date: " + Month + "/" + Day + "/" + Year + " " + "Time: " + Time_in + " " + am_pm);

                file.Close();

                MessageBox.Show("Data has been saved! You may now proceed.");
                Application.Restart();
                Environment.Exit(0);

            }    
        }

        private void SortAccbtn_Click(object sender, EventArgs e)
        {
            //Admin Password checker
            string password = SortAcctxtbx_psw.Text;

            //Password
            if (password == "moriveraaa")
            {
                //Opens Admin Window
                Form2 info = new Form2();
                info.ShowDialog();
            }
            else
            {
            MessageBox.Show("Wrong Password.");
            } 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Qrgenbtn_Click(object sender, EventArgs e)
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

            if (counter != 7)
            {
                MessageBox.Show("A detail was left unfilled. Please complete all the blanks. If no answer for the given, please input n/a.");
            }
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();

                // QR Information
                string QRinfo = "Name: " + SN + ", " + FN + " " + MN + " " + "Email: " + Email + " | " + "Contact Number: " + ConNum + "Address: " + Address + " | " + "City: " + City;
                // QR Code Creator
                QRCodeData data = qr.CreateQrCode(QRinfo, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                QRgenpb.SizeMode = PictureBoxSizeMode.StretchImage;
                QRgenpb.Image = code.GetGraphic(5);

            }
                
            
        }
    }
}
// Folder Path: "C:\Users\PC\source\repos\Contact Tracing Form"