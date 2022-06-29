using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ShowDatabtn_Click(object sender, EventArgs e)
        {


            StreamReader reader = new StreamReader(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt");
            
            List<string> Names_Grouped = new List<string>();

            //Sort by Name
            string Surname = SNtxtbx.Text;
            string FirstName = FNtxtbx.Text;
            string Date = mmtxtbx.Text + "/" + ddtxtbx.Text + "/" + Yeartxtbx.Text;
            string Location = citytxtbx.Text;
            while (!reader.EndOfStream)
            {
                string filteredname = reader.ReadLine();
                if (filteredname.Contains(Surname))
                { 
                    if (filteredname.Contains(FirstName))
                    {
                       if (filteredname.Contains(Date))
                        {
                            if(filteredname.Contains(Location))
                            {
                                MessageBox.Show(filteredname);
                                Names_Grouped.Add(filteredname);
                            }
                        }
                            
                    }
  
                }   
            }
            reader.Close();
        }

        private void Timelbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void mmlbl_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Allrecbtn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\PC\source\repos\Contact Tracing Form\Data Input.txt");
            while(!reader.EndOfStream)
            {
                string Allrecords = reader.ReadLine();
                MessageBox.Show(Allrecords);
            }
                
        }
    }
}
