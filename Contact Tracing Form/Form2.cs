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
            while (!reader.EndOfStream)
            {
                string filteredname = reader.ReadLine();
                if (filteredname.Contains(Surname))
                { 
                    MessageBox.Show(filteredname); 
                    Names_Grouped.Add(filteredname);
                }   
            }
            reader.Close();

            StreamWriter file = new StreamWriter(@"C:\Users\PC\source\repos\Contact Tracing Form\Sorted Data Viewer.txt");
            foreach (string name in Names_Grouped)
            {
                MessageBox.Show(name);
            }   
        }

        private void Timelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
