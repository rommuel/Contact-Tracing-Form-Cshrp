namespace Contact_Tracing_Form
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DesPBF2t = new System.Windows.Forms.PictureBox();
            this.DesPBF2b = new System.Windows.Forms.PictureBox();
            this.InstlblF2 = new System.Windows.Forms.Label();
            this.AdminFormlbl = new System.Windows.Forms.Label();
            this.Sortlbl = new System.Windows.Forms.Label();
            this.Namelbl = new System.Windows.Forms.Label();
            this.Datelbl = new System.Windows.Forms.Label();
            this.Timelbl = new System.Windows.Forms.Label();
            this.ShowDatabtn = new System.Windows.Forms.Button();
            this.SNtxtbx = new System.Windows.Forms.TextBox();
            this.FNtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DesPBF2t)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesPBF2b)).BeginInit();
            this.SuspendLayout();
            // 
            // DesPBF2t
            // 
            this.DesPBF2t.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DesPBF2t.Location = new System.Drawing.Point(-5, 56);
            this.DesPBF2t.Name = "DesPBF2t";
            this.DesPBF2t.Size = new System.Drawing.Size(809, 21);
            this.DesPBF2t.TabIndex = 0;
            this.DesPBF2t.TabStop = false;
            // 
            // DesPBF2b
            // 
            this.DesPBF2b.BackColor = System.Drawing.Color.MediumAquamarine;
            this.DesPBF2b.Location = new System.Drawing.Point(-5, 402);
            this.DesPBF2b.Name = "DesPBF2b";
            this.DesPBF2b.Size = new System.Drawing.Size(809, 21);
            this.DesPBF2b.TabIndex = 1;
            this.DesPBF2b.TabStop = false;
            // 
            // InstlblF2
            // 
            this.InstlblF2.AutoSize = true;
            this.InstlblF2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.InstlblF2.Location = new System.Drawing.Point(12, 93);
            this.InstlblF2.Name = "InstlblF2";
            this.InstlblF2.Size = new System.Drawing.Size(196, 20);
            this.InstlblF2.TabIndex = 2;
            this.InstlblF2.Text = "Access Form Information";
            // 
            // AdminFormlbl
            // 
            this.AdminFormlbl.AutoSize = true;
            this.AdminFormlbl.Font = new System.Drawing.Font("Segoe UI Symbol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AdminFormlbl.Location = new System.Drawing.Point(12, 9);
            this.AdminFormlbl.Name = "AdminFormlbl";
            this.AdminFormlbl.Size = new System.Drawing.Size(164, 38);
            this.AdminFormlbl.TabIndex = 3;
            this.AdminFormlbl.Text = "Form Data ";
            // 
            // Sortlbl
            // 
            this.Sortlbl.AutoSize = true;
            this.Sortlbl.Location = new System.Drawing.Point(12, 127);
            this.Sortlbl.Name = "Sortlbl";
            this.Sortlbl.Size = new System.Drawing.Size(59, 20);
            this.Sortlbl.TabIndex = 4;
            this.Sortlbl.Text = "Sort by:";
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Namelbl.Location = new System.Drawing.Point(12, 175);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(68, 25);
            this.Namelbl.TabIndex = 5;
            this.Namelbl.Text = "Name:";
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Datelbl.Location = new System.Drawing.Point(451, 175);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(58, 25);
            this.Datelbl.TabIndex = 6;
            this.Datelbl.Text = "Date:";
            // 
            // Timelbl
            // 
            this.Timelbl.AutoSize = true;
            this.Timelbl.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Timelbl.Location = new System.Drawing.Point(12, 276);
            this.Timelbl.Name = "Timelbl";
            this.Timelbl.Size = new System.Drawing.Size(59, 25);
            this.Timelbl.TabIndex = 7;
            this.Timelbl.Text = "Time:";
            this.Timelbl.Click += new System.EventHandler(this.Timelbl_Click);
            // 
            // ShowDatabtn
            // 
            this.ShowDatabtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ShowDatabtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ShowDatabtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShowDatabtn.Location = new System.Drawing.Point(688, 358);
            this.ShowDatabtn.Name = "ShowDatabtn";
            this.ShowDatabtn.Size = new System.Drawing.Size(100, 38);
            this.ShowDatabtn.TabIndex = 8;
            this.ShowDatabtn.Text = "Search";
            this.ShowDatabtn.UseVisualStyleBackColor = false;
            this.ShowDatabtn.Click += new System.EventHandler(this.ShowDatabtn_Click);
            // 
            // SNtxtbx
            // 
            this.SNtxtbx.ForeColor = System.Drawing.Color.Black;
            this.SNtxtbx.Location = new System.Drawing.Point(95, 203);
            this.SNtxtbx.Name = "SNtxtbx";
            this.SNtxtbx.Size = new System.Drawing.Size(164, 27);
            this.SNtxtbx.TabIndex = 9;
            // 
            // FNtxtbx
            // 
            this.FNtxtbx.ForeColor = System.Drawing.Color.Black;
            this.FNtxtbx.Location = new System.Drawing.Point(95, 236);
            this.FNtxtbx.Name = "FNtxtbx";
            this.FNtxtbx.Size = new System.Drawing.Size(258, 27);
            this.FNtxtbx.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Surname:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "First Name:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNtxtbx);
            this.Controls.Add(this.SNtxtbx);
            this.Controls.Add(this.ShowDatabtn);
            this.Controls.Add(this.Timelbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Sortlbl);
            this.Controls.Add(this.AdminFormlbl);
            this.Controls.Add(this.InstlblF2);
            this.Controls.Add(this.DesPBF2b);
            this.Controls.Add(this.DesPBF2t);
            this.Name = "Form2";
            this.Text = "Admin (Form Data)";
            ((System.ComponentModel.ISupportInitialize)(this.DesPBF2t)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DesPBF2b)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DesPBF2t;
        private PictureBox DesPBF2b;
        private Label InstlblF2;
        private Label AdminFormlbl;
        private Label Sortlbl;
        private Label Namelbl;
        private Label Datelbl;
        private Label Timelbl;
        private Button ShowDatabtn;
        private TextBox SNtxtbx;
        private TextBox FNtxtbx;
        private Label label1;
        private Label label2;
    }
}