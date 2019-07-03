namespace RailwayReservation
{
    partial class CustomerDetails
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
            this.txtcontactnumber = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtref = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboseatsno = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbltyp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtcontactnumber
            // 
            this.txtcontactnumber.Location = new System.Drawing.Point(191, 191);
            this.txtcontactnumber.Name = "txtcontactnumber";
            this.txtcontactnumber.Size = new System.Drawing.Size(252, 20);
            this.txtcontactnumber.TabIndex = 11;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(191, 142);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(252, 20);
            this.txtAge.TabIndex = 10;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(191, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(252, 20);
            this.txtname.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(29, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Contact Number";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(127, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Age";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(113, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Name";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtref
            // 
            this.txtref.Enabled = false;
            this.txtref.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtref.Location = new System.Drawing.Point(191, 29);
            this.txtref.Name = "txtref";
            this.txtref.ReadOnly = true;
            this.txtref.Size = new System.Drawing.Size(293, 29);
            this.txtref.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Ticket Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 47);
            this.button1.TabIndex = 33;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboseatsno
            // 
            this.comboseatsno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboseatsno.FormattingEnabled = true;
            this.comboseatsno.Location = new System.Drawing.Point(220, 308);
            this.comboseatsno.Name = "comboseatsno";
            this.comboseatsno.Size = new System.Drawing.Size(121, 21);
            this.comboseatsno.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(123, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 20);
            this.label13.TabIndex = 35;
            this.label13.Text = "Seat no";
            // 
            // lbltyp
            // 
            this.lbltyp.AutoSize = true;
            this.lbltyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltyp.Location = new System.Drawing.Point(42, 246);
            this.lbltyp.Name = "lbltyp";
            this.lbltyp.Size = new System.Drawing.Size(76, 25);
            this.lbltyp.TabIndex = 37;
            this.lbltyp.Text = "label1";
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 496);
            this.Controls.Add(this.lbltyp);
            this.Controls.Add(this.comboseatsno);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtref);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtcontactnumber);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcontactnumber;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox comboseatsno;
        public System.Windows.Forms.Label lbltyp;
    }
}