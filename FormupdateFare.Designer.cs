namespace RailwayReservation
{
    partial class FormupdateFare
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
            this.comboTrainname = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcurrentfareEco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnewfarerateEco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnypdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbussfarenew = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtbussfarecurr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboTrainname
            // 
            this.comboTrainname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainname.FormattingEnabled = true;
            this.comboTrainname.Location = new System.Drawing.Point(195, 72);
            this.comboTrainname.Name = "comboTrainname";
            this.comboTrainname.Size = new System.Drawing.Size(121, 21);
            this.comboTrainname.TabIndex = 15;
            this.comboTrainname.SelectedIndexChanged += new System.EventHandler(this.comboTrainname_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(74, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Train name";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(193, 218);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 20;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lahore",
            "Karachi",
            "Rawalpindi"});
            this.comboBox1.Location = new System.Drawing.Point(193, 175);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 19;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(38, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(38, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(38, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Select Route";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(38, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Select Train";
            // 
            // txtcurrentfareEco
            // 
            this.txtcurrentfareEco.Enabled = false;
            this.txtcurrentfareEco.Location = new System.Drawing.Point(193, 305);
            this.txtcurrentfareEco.Name = "txtcurrentfareEco";
            this.txtcurrentfareEco.ReadOnly = true;
            this.txtcurrentfareEco.Size = new System.Drawing.Size(121, 20);
            this.txtcurrentfareEco.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(38, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Current Fare";
            // 
            // txtnewfarerateEco
            // 
            this.txtnewfarerateEco.Location = new System.Drawing.Point(193, 359);
            this.txtnewfarerateEco.Name = "txtnewfarerateEco";
            this.txtnewfarerateEco.Size = new System.Drawing.Size(121, 20);
            this.txtnewfarerateEco.TabIndex = 25;
            this.txtnewfarerateEco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnewfarerate_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(38, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 24;
            this.label8.Text = "New Fare Rate";
            // 
            // btnypdate
            // 
            this.btnypdate.BackColor = System.Drawing.Color.FloralWhite;
            this.btnypdate.Location = new System.Drawing.Point(404, 501);
            this.btnypdate.Name = "btnypdate";
            this.btnypdate.Size = new System.Drawing.Size(91, 34);
            this.btnypdate.TabIndex = 26;
            this.btnypdate.Text = "Update";
            this.btnypdate.UseVisualStyleBackColor = false;
            this.btnypdate.Click += new System.EventHandler(this.btnypdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(38, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Bussniess Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(38, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "Economy Class";
            // 
            // txtbussfarenew
            // 
            this.txtbussfarenew.Location = new System.Drawing.Point(195, 519);
            this.txtbussfarenew.Name = "txtbussfarenew";
            this.txtbussfarenew.Size = new System.Drawing.Size(121, 20);
            this.txtbussfarenew.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(40, 517);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 20);
            this.label10.TabIndex = 31;
            this.label10.Text = "New Fare Rate";
            // 
            // txtbussfarecurr
            // 
            this.txtbussfarecurr.Enabled = false;
            this.txtbussfarecurr.Location = new System.Drawing.Point(195, 465);
            this.txtbussfarecurr.Name = "txtbussfarecurr";
            this.txtbussfarecurr.ReadOnly = true;
            this.txtbussfarecurr.Size = new System.Drawing.Size(121, 20);
            this.txtbussfarecurr.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(40, 465);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Current Fare";
            // 
            // FormupdateFare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 576);
            this.Controls.Add(this.txtbussfarenew);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtbussfarecurr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnypdate);
            this.Controls.Add(this.txtnewfarerateEco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcurrentfareEco);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTrainname);
            this.Controls.Add(this.label6);
            this.Name = "FormupdateFare";
            this.Text = "FormupdateFare";
            this.Load += new System.EventHandler(this.FormupdateFare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTrainname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcurrentfareEco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnewfarerateEco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnypdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbussfarenew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtbussfarecurr;
        private System.Windows.Forms.Label label11;
    }
}