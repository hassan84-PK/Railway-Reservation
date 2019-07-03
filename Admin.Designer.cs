namespace RailwayReservation
{
    partial class Admin
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
            this.btntrain = new System.Windows.Forms.Button();
            this.btnupdatefare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntrain
            // 
            this.btntrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrain.Location = new System.Drawing.Point(95, 51);
            this.btntrain.Name = "btntrain";
            this.btntrain.Size = new System.Drawing.Size(166, 68);
            this.btntrain.TabIndex = 0;
            this.btntrain.Text = "Add Train";
            this.btntrain.UseVisualStyleBackColor = true;
            this.btntrain.Click += new System.EventHandler(this.btntrain_Click);
            // 
            // btnupdatefare
            // 
            this.btnupdatefare.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatefare.Location = new System.Drawing.Point(95, 174);
            this.btnupdatefare.Name = "btnupdatefare";
            this.btnupdatefare.Size = new System.Drawing.Size(166, 68);
            this.btnupdatefare.TabIndex = 1;
            this.btnupdatefare.Text = "Update Fare";
            this.btnupdatefare.UseVisualStyleBackColor = true;
            this.btnupdatefare.Click += new System.EventHandler(this.btnupdatefare_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 307);
            this.Controls.Add(this.btnupdatefare);
            this.Controls.Add(this.btntrain);
            this.Name = "Admin";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntrain;
        private System.Windows.Forms.Button btnupdatefare;
    }
}