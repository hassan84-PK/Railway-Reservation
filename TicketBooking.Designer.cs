namespace RailwayReservation
{
    partial class TicketBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txttraindid = new System.Windows.Forms.TextBox();
            this.comboTrainname = new System.Windows.Forms.ComboBox();
            this.txtfarerateEconomy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtfarerateBuss = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rbtnecoclass = new System.Windows.Forms.RadioButton();
            this.rbtnbsclass = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            resources.GetString("comboBox1.Items"),
            resources.GetString("comboBox1.Items1"),
            resources.GetString("comboBox1.Items2")});
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox2, "comboBox2");
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // txttraindid
            // 
            resources.ApplyResources(this.txttraindid, "txttraindid");
            this.txttraindid.Name = "txttraindid";
            this.txttraindid.ReadOnly = true;
            this.txttraindid.TextChanged += new System.EventHandler(this.txttraindid_TextChanged);
            // 
            // comboTrainname
            // 
            this.comboTrainname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTrainname.FormattingEnabled = true;
            resources.ApplyResources(this.comboTrainname, "comboTrainname");
            this.comboTrainname.Name = "comboTrainname";
            this.comboTrainname.SelectedIndexChanged += new System.EventHandler(this.comboTrainname_SelectedIndexChanged);
            // 
            // txtfarerateEconomy
            // 
            resources.ApplyResources(this.txtfarerateEconomy, "txtfarerateEconomy");
            this.txtfarerateEconomy.Name = "txtfarerateEconomy";
            this.txtfarerateEconomy.ReadOnly = true;
            this.txtfarerateEconomy.TextChanged += new System.EventHandler(this.txtfarerate_TextChanged);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtfarerateBuss
            // 
            resources.ApplyResources(this.txtfarerateBuss, "txtfarerateBuss");
            this.txtfarerateBuss.Name = "txtfarerateBuss";
            this.txtfarerateBuss.ReadOnly = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // rbtnecoclass
            // 
            resources.ApplyResources(this.rbtnecoclass, "rbtnecoclass");
            this.rbtnecoclass.Name = "rbtnecoclass";
            this.rbtnecoclass.TabStop = true;
            this.rbtnecoclass.UseVisualStyleBackColor = true;
            // 
            // rbtnbsclass
            // 
            resources.ApplyResources(this.rbtnbsclass, "rbtnbsclass");
            this.rbtnbsclass.Name = "rbtnbsclass";
            this.rbtnbsclass.TabStop = true;
            this.rbtnbsclass.UseVisualStyleBackColor = true;
            // 
            // TicketBooking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.rbtnbsclass);
            this.Controls.Add(this.rbtnecoclass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtfarerateBuss);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtfarerateEconomy);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboTrainname);
            this.Controls.Add(this.txttraindid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TicketBooking";
            this.Load += new System.EventHandler(this.TicketBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txttraindid;
        private System.Windows.Forms.ComboBox comboTrainname;
        private System.Windows.Forms.TextBox txtfarerateEconomy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtfarerateBuss;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbtnecoclass;
        private System.Windows.Forms.RadioButton rbtnbsclass;
    }
}