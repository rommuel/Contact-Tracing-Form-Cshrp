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

            //Sort by Name
            string Surname = SNtxtbx.Text;
            string FirstName = FNtxtbx.Text;
            while (!reader.EndOfStream);
        }

        private void Timelbl_Click(object sender, EventArgs e)
        {

        }
    }
}
