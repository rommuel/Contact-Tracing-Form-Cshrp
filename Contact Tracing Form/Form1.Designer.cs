namespace Contact_Tracing_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Namelbl = new System.Windows.Forms.Label();
            this.SNlbl = new System.Windows.Forms.Label();
            this.FNlbl = new System.Windows.Forms.Label();
            this.MNlbl = new System.Windows.Forms.Label();
            this.SNtxtbx = new System.Windows.Forms.TextBox();
            this.FNtxtbx = new System.Windows.Forms.TextBox();
            this.MNtxtbx = new System.Windows.Forms.TextBox();
            this.Emailtxtbx = new System.Windows.Forms.TextBox();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.ConNumlbl = new System.Windows.Forms.Label();
            this.ConNumtxtbx = new System.Windows.Forms.TextBox();
            this.Citytxtbx = new System.Windows.Forms.TextBox();
            this.FAddresstxtbx = new System.Windows.Forms.TextBox();
            this.Citylbl = new System.Windows.Forms.Label();
            this.Addresslbl = new System.Windows.Forms.Label();
            this.FAddlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.Location = new System.Drawing.Point(12, 81);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(57, 20);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name:";
            // 
            // SNlbl
            // 
            this.SNlbl.AutoSize = true;
            this.SNlbl.Location = new System.Drawing.Point(34, 111);
            this.SNlbl.Name = "SNlbl";
            this.SNlbl.Size = new System.Drawing.Size(70, 20);
            this.SNlbl.TabIndex = 1;
            this.SNlbl.Text = "Surname:";
            this.SNlbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // FNlbl
            // 
            this.FNlbl.AutoSize = true;
            this.FNlbl.Location = new System.Drawing.Point(213, 111);
            this.FNlbl.Name = "FNlbl";
            this.FNlbl.Size = new System.Drawing.Size(83, 20);
            this.FNlbl.TabIndex = 2;
            this.FNlbl.Text = "First Name:";
            // 
            // MNlbl
            // 
            this.MNlbl.AutoSize = true;
            this.MNlbl.Location = new System.Drawing.Point(506, 111);
            this.MNlbl.Name = "MNlbl";
            this.MNlbl.Size = new System.Drawing.Size(103, 20);
            this.MNlbl.TabIndex = 3;
            this.MNlbl.Text = "Middle Name:";
            // 
            // SNtxtbx
            // 
            this.SNtxtbx.Location = new System.Drawing.Point(34, 134);
            this.SNtxtbx.Name = "SNtxtbx";
            this.SNtxtbx.Size = new System.Drawing.Size(153, 27);
            this.SNtxtbx.TabIndex = 4;
            // 
            // FNtxtbx
            // 
            this.FNtxtbx.Location = new System.Drawing.Point(213, 134);
            this.FNtxtbx.Name = "FNtxtbx";
            this.FNtxtbx.Size = new System.Drawing.Size(253, 27);
            this.FNtxtbx.TabIndex = 5;
            // 
            // MNtxtbx
            // 
            this.MNtxtbx.Location = new System.Drawing.Point(506, 134);
            this.MNtxtbx.Name = "MNtxtbx";
            this.MNtxtbx.Size = new System.Drawing.Size(204, 27);
            this.MNtxtbx.TabIndex = 6;
            this.MNtxtbx.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Emailtxtbx
            // 
            this.Emailtxtbx.Location = new System.Drawing.Point(34, 205);
            this.Emailtxtbx.Name = "Emailtxtbx";
            this.Emailtxtbx.Size = new System.Drawing.Size(359, 27);
            this.Emailtxtbx.TabIndex = 7;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Emaillbl.Location = new System.Drawing.Point(31, 182);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(55, 20);
            this.Emaillbl.TabIndex = 8;
            this.Emaillbl.Text = "Email:";
            // 
            // ConNumlbl
            // 
            this.ConNumlbl.AutoSize = true;
            this.ConNumlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ConNumlbl.Location = new System.Drawing.Point(449, 182);
            this.ConNumlbl.Name = "ConNumlbl";
            this.ConNumlbl.Size = new System.Drawing.Size(136, 20);
            this.ConNumlbl.TabIndex = 9;
            this.ConNumlbl.Text = "Contact Number:";
            // 
            // ConNumtxtbx
            // 
            this.ConNumtxtbx.Location = new System.Drawing.Point(449, 205);
            this.ConNumtxtbx.Name = "ConNumtxtbx";
            this.ConNumtxtbx.Size = new System.Drawing.Size(261, 27);
            this.ConNumtxtbx.TabIndex = 10;
            // 
            // Citytxtbx
            // 
            this.Citytxtbx.Location = new System.Drawing.Point(12, 334);
            this.Citytxtbx.Name = "Citytxtbx";
            this.Citytxtbx.Size = new System.Drawing.Size(208, 27);
            this.Citytxtbx.TabIndex = 11;
            // 
            // FAddresstxtbx
            // 
            this.FAddresstxtbx.Location = new System.Drawing.Point(244, 334);
            this.FAddresstxtbx.Name = "FAddresstxtbx";
            this.FAddresstxtbx.Size = new System.Drawing.Size(544, 27);
            this.FAddresstxtbx.TabIndex = 12;
            // 
            // Citylbl
            // 
            this.Citylbl.AutoSize = true;
            this.Citylbl.Location = new System.Drawing.Point(12, 311);
            this.Citylbl.Name = "Citylbl";
            this.Citylbl.Size = new System.Drawing.Size(124, 20);
            this.Citylbl.TabIndex = 13;
            this.Citylbl.Text = "City/Municipality:";
            // 
            // Addresslbl
            // 
            this.Addresslbl.AutoSize = true;
            this.Addresslbl.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Addresslbl.Location = new System.Drawing.Point(12, 282);
            this.Addresslbl.Name = "Addresslbl";
            this.Addresslbl.Size = new System.Drawing.Size(73, 20);
            this.Addresslbl.TabIndex = 14;
            this.Addresslbl.Text = "Address:";
            this.Addresslbl.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // FAddlbl
            // 
            this.FAddlbl.AutoSize = true;
            this.FAddlbl.Location = new System.Drawing.Point(244, 311);
            this.FAddlbl.Name = "FAddlbl";
            this.FAddlbl.Size = new System.Drawing.Size(65, 20);
            this.FAddlbl.TabIndex = 15;
            this.FAddlbl.Text = "Address:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.FAddlbl);
            this.Controls.Add(this.Addresslbl);
            this.Controls.Add(this.Citylbl);
            this.Controls.Add(this.FAddresstxtbx);
            this.Controls.Add(this.Citytxtbx);
            this.Controls.Add(this.ConNumtxtbx);
            this.Controls.Add(this.ConNumlbl);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.Emailtxtbx);
            this.Controls.Add(this.MNtxtbx);
            this.Controls.Add(this.FNtxtbx);
            this.Controls.Add(this.SNtxtbx);
            this.Controls.Add(this.MNlbl);
            this.Controls.Add(this.FNlbl);
            this.Controls.Add(this.SNlbl);
            this.Controls.Add(this.Namelbl);
            this.Name = "Form1";
            this.Text = "Contact Tracing Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Namelbl;
        private Label SNlbl;
        private Label FNlbl;
        private Label MNlbl;
        private TextBox SNtxtbx;
        private TextBox FNtxtbx;
        private TextBox MNtxtbx;
        private TextBox Emailtxtbx;
        private Label Emaillbl;
        private Label ConNumlbl;
        private TextBox ConNumtxtbx;
        private TextBox Citytxtbx;
        private TextBox FAddresstxtbx;
        private Label Citylbl;
        private Label Addresslbl;
        private Label FAddlbl;
    }
}