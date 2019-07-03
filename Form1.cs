using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RailwayReservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTickting_Click(object sender, EventArgs e)
        {
            TicketBooking Form2 = new TicketBooking();
          //  this.Hide();
            Form2.Show();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text==""||txtpassword.Text=="")
            {
                MessageBox.Show("Please Fill all Fields!!");
                return;
            }


            DBConnect Connect = new DBConnect();

            string passcord = "";
            Connect.command = Connect.connection.CreateCommand();

            Connect.command.CommandText = "select password from user where userid = '"+txtusername.Text+" '";
            Connect.OpenConnection();
            Connect.reader = Connect.command.ExecuteReader();
            while (Connect.reader.Read())
            {

              passcord=Connect.reader["password"].ToString();
            }
            Connect.CloseConnection();

            if (passcord==txtpassword.Text)
            {
                MessageBox.Show("Welcome");
                Admin Form4 = new Admin();
                Form4.Show();
                //this.Hide();

            }
            else
            {
                MessageBox.Show("Incoreect Password!!");
                txtpassword.Text = "";
            }





        }
    }
}
