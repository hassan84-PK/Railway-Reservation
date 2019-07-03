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
    public partial class CustomerDetails : Form
    {
       public string Date="";
       public string ticketnumber = "";
       public string bookedby = "";
       public string trackid = "";
       public string trainid = "";
       public string farerate = "";
       public string travelclass = "";


       DBConnect Connect = new DBConnect();
        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text=="" ||txtcontactnumber.Text=="" ||txtAge.Text=="")
            {
                MessageBox.Show("Kindly Fill all boxes");
                return;
            }
            else
            {
                if (comboseatsno.Text=="")
                {
                    MessageBox.Show("Kindly Select A seat first");
                    return;
                }
                try
                {

                    Connect.OpenConnection();

                    Connect.command = Connect.connection.CreateCommand();

                    Connect.command.CommandText = "insert into ticket values (" + txtref.Text + ", 'Confirm', "+Date+" ) ";
                    Connect.command.ExecuteNonQuery();
                    Connect.CloseConnection();

                    Connect.OpenConnection();

                    Connect.command = Connect.connection.CreateCommand();

                    Connect.command.CommandText = "insert into ticketdetails values (" + txtref.Text + "," + trainid + "," + trackid + ",(select id from classes where name='" + travelclass + "'),"+farerate+" ) ";
                    Connect.command.ExecuteNonQuery();
                    Connect.CloseConnection();


                    Connect.OpenConnection();

                    Connect.command = Connect.connection.CreateCommand();
                  
                    Connect.command.CommandText = "insert into seats values ("+txtref.Text+","+comboseatsno.Text+",(select id from classes where name='"+travelclass+"'),"+farerate+" ) ";
                    Connect.command.ExecuteNonQuery();
                    Connect.CloseConnection();          

                    Connect.OpenConnection();
                    Connect.command = Connect.connection.CreateCommand();
                    Connect.command.CommandText = "insert into passangerdetails values ( "+ticketnumber+","+ comboseatsno.Text + ",'"+txtname.Text+"','"+txtcontactnumber.Text+"',"+txtAge.Text+") ";
                    Connect.command.ExecuteNonQuery();
                    Connect.CloseConnection();



                    Connect.OpenConnection();
                    Connect.command = Connect.connection.CreateCommand();
                    Connect.command.CommandText = "select max(id) as max from customer";
                    Connect.reader = Connect.command.ExecuteReader();
                    Connect.reader.Read();
                    string id=Connect.reader["max"].ToString();
                    Connect.CloseConnection();



                    Connect.OpenConnection();

                    Connect.command = Connect.connection.CreateCommand();
                    Connect.command.CommandText = "insert into bookedby values ( " + ticketnumber + ","+id+" ) ";
                    Connect.command.ExecuteNonQuery();
                    Connect.CloseConnection();    


                    MessageBox.Show("Booked you Ticket Number id "+ticketnumber);
                    this.Enabled=false;
                    this.Hide();
                   


                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
