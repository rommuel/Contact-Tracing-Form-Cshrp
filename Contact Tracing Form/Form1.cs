namespace Contact_Tracing_Form
{
    using QRCoder;
    using AForge.Video;
    using AForge.Video.DirectShow;
    using ZXing;
    using ZXing.Windows.Compatibility;
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        
       
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

        private void Form1_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterinfo in filterInfoCollection)
                cboDevice.Items.Add(filterinfo.Name);
            cboDevice.SelectedIndex = 0;
          
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Webcampb.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning)
                videoCaptureDevice.Stop();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Webcampb.Image != null)
            {
                // date and time-in (Manual Input Required)
                string Month = Monthtxtbx.Text;
                string Day = Daytxtbx.Text;
                string Year = Yeartxtbx.Text;

                string Time_in = Timetxtbx.Text;
                string am_pm = ampmtxtbx.Text;

                int counter = 0;


                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)Webcampb.Image);
                if (result != null)
                {
                    string confirm_msg = "The following will be inputted.";
                    string qrdataconfirm_title = "Is this correct?";
                    string qrdataconfirm = (result.ToString());
                    MessageBox.Show(confirm_msg);

                    var confirmation = MessageBox.Show(qrdataconfirm, qrdataconfirm_title, MessageBoxButtons.YesNo);
                    if (confirmation != DialogResult.Yes)
                    {
                        if (Month.Length > 1)
                        {
                            counter++;
                        }
                        if (Day.Length > 1)
                        {
                            counter++;
                        }
                        if (Year.Length > 3)
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

                        if (counter != 5)
                        {
                            MessageBox.Show("Please Manually input the date and time-in of your entry and try again.");
                        }
                        else
                        {
                            StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt", true);
                            file.WriteLine(qrdataconfirm + " " + "Date: " + Month + "/" + Day + "/" + Year + " " + "Time: " + Time_in + " " + am_pm);
                            file.Close();

                            MessageBox.Show("Data has been saved! You may now proceed.");
                        }


                    }
                    else if (confirmation != DialogResult.No)
                    {

                        MessageBox.Show("If QRcode is showing the wrong information, please proceed to manual filling for the Contact Tracing Form.");
                    }


                    timer1.Stop();

                    
                }
            }
        }
    }
}
// Folder Path: "C:\Users\PC\source\repos\Contact Tracing Form"