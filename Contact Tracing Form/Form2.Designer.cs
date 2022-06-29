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
            this.Loclbl = new System.Windows.Forms.Label();
            this.ShowDatabtn = new System.Windows.Forms.Button();
            this.SNtxtbx = new System.Windows.Forms.TextBox();
            this.FNtxtbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mmlbl = new System.Windows.Forms.Label();
            this.mmtxtbx = new System.Windows.Forms.TextBox();
            this.ddtxtbx = new System.Windows.Forms.TextBox();
            this.Yeartxtbx = new System.Windows.Forms.TextBox();
            this.ddlbl = new System.Windows.Forms.Label();
            this.yearlbl = new System.Windows.Forms.Label();
            this.citytxtbx = new System.Windows.Forms.TextBox();
            this.citylbl = new System.Windows.Forms.Label();
            this.Allrecbtn = new System.Windows.Forms.Button();
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
            // Loclbl
            // 
            this.Loclbl.AutoSize = true;
            this.Loclbl.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Loclbl.Location = new System.Drawing.Point(12, 276);
            this.Loclbl.Name = "Loclbl";
            this.Loclbl.Size = new System.Drawing.Size(92, 25);
            this.Loclbl.TabIndex = 7;
            this.Loclbl.Text = "Location:";
            this.Loclbl.Click += new System.EventHandler(this.Timelbl_Click);
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
            // mmlbl
            // 
            this.mmlbl.AutoSize = true;
            this.mmlbl.Location = new System.Drawing.Point(462, 237);
            this.mmlbl.Name = "mmlbl";
            this.mmlbl.Size = new System.Drawing.Size(38, 20);
            this.mmlbl.TabIndex = 13;
            this.mmlbl.Text = "mm:";
            this.mmlbl.Click += new System.EventHandler(this.mmlbl_Click);
            // 
            // mmtxtbx
            // 
            this.mmtxtbx.Location = new System.Drawing.Point(462, 207);
            this.mmtxtbx.Name = "mmtxtbx";
            this.mmtxtbx.Size = new System.Drawing.Size(35, 27);
            this.mmtxtbx.TabIndex = 15;
            // 
            // ddtxtbx
            // 
            this.ddtxtbx.Location = new System.Drawing.Point(514, 207);
            this.ddtxtbx.Name = "ddtxtbx";
            this.ddtxtbx.Size = new System.Drawing.Size(35, 27);
            this.ddtxtbx.TabIndex = 16;
            // 
            // Yeartxtbx
            // 
            this.Yeartxtbx.Location = new System.Drawing.Point(566, 207);
            this.Yeartxtbx.Name = "Yeartxtbx";
            this.Yeartxtbx.Size = new System.Drawing.Size(58, 27);
            this.Yeartxtbx.TabIndex = 17;
            // 
            // ddlbl
            // 
            this.ddlbl.AutoSize = true;
            this.ddlbl.Location = new System.Drawing.Point(514, 236);
            this.ddlbl.Name = "ddlbl";
            this.ddlbl.Size = new System.Drawing.Size(30, 20);
            this.ddlbl.TabIndex = 18;
            this.ddlbl.Text = "dd:";
            // 
            // yearlbl
            // 
            this.yearlbl.AutoSize = true;
            this.yearlbl.Location = new System.Drawing.Point(575, 236);
            this.yearlbl.Name = "yearlbl";
            this.yearlbl.Size = new System.Drawing.Size(40, 20);
            this.yearlbl.TabIndex = 19;
            this.yearlbl.Text = "yyyy:";
            // 
            // citytxtbx
            // 
            this.citytxtbx.Location = new System.Drawing.Point(55, 320);
            this.citytxtbx.Name = "citytxtbx";
            this.citytxtbx.Size = new System.Drawing.Size(212, 27);
            this.citytxtbx.TabIndex = 20;
            // 
            // citylbl
            // 
            this.citylbl.AutoSize = true;
            this.citylbl.Location = new System.Drawing.Point(12, 320);
            this.citylbl.Name = "citylbl";
            this.citylbl.Size = new System.Drawing.Size(37, 20);
            this.citylbl.TabIndex = 21;
            this.citylbl.Text = "City:";
            // 
            // Allrecbtn
            // 
            this.Allrecbtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.Allrecbtn.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Allrecbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Allrecbtn.Location = new System.Drawing.Point(629, 93);
            this.Allrecbtn.Name = "Allrecbtn";
            this.Allrecbtn.Size = new System.Drawing.Size(159, 38);
            this.Allrecbtn.TabIndex = 22;
            this.Allrecbtn.Text = "Show All Records";
            this.Allrecbtn.UseVisualStyleBackColor = false;
            this.Allrecbtn.Click += new System.EventHandler(this.Allrecbtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Allrecbtn);
            this.Controls.Add(this.citylbl);
            this.Controls.Add(this.citytxtbx);
            this.Controls.Add(this.yearlbl);
            this.Controls.Add(this.ddlbl);
            this.Controls.Add(this.Yeartxtbx);
            this.Controls.Add(this.ddtxtbx);
            this.Controls.Add(this.mmtxtbx);
            this.Controls.Add(this.mmlbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FNtxtbx);
            this.Controls.Add(this.SNtxtbx);
            this.Controls.Add(this.ShowDatabtn);
            this.Controls.Add(this.Loclbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.Sortlbl);
            this.Controls.Add(this.AdminFormlbl);
            this.Controls.Add(this.InstlblF2);
            this.Controls.Add(this.DesPBF2b);
            this.Controls.Add(this.DesPBF2t);
            this.Name = "Form2";
            this.Text = "Admin (Form Data)";
            this.Load += new System.EventHandler(this.Form2_Load);
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
        private Label Loclbl;
        private Button ShowDatabtn;
        private TextBox SNtxtbx;
        private TextBox FNtxtbx;
        private Label label1;
        private Label label2;
        private Label mmlbl;
        private TextBox mmtxtbx;
        private TextBox ddtxtbx;
        private TextBox Yeartxtbx;
        private Label ddlbl;
        private Label yearlbl;
        private TextBox citytxtbx;
        private Label citylbl;
        private Button Allrecbtn;
    }
}