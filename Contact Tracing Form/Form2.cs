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
            StreamReader reader = new StreamReader(@"C: \Users\PC\source\repos\Contact Tracing Form\Data Input.txt");
            reader.ReadToEnd();

            List<string> Names = new List<string>();

            //Sort by Name
            string Surname = SNtxtbx.Text;
            string FirstName = FNtxtbx.Text;
            while (!reader.EndOfStream)
            {
                string Name_Data = reader.ReadLine();
                if (Name_Data.Contains(Surname))
                {
                    Names.Add(Name_Data);
                }
            reader.Close();
            StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Sorted Data View.txt", true);
            foreach (string item in Names)
            {
                    MessageBox.Show(Name_Data);
                    file.WriteLine(Name_Data);
                    file.Close();
                    
                
                    
                    
            }
            }
        }

        private void Timelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
