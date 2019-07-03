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
    public partial class Booking : Form
    {
        public string travelclass = "";
        DBConnect Connect = new DBConnect();
        List<string> Seats = new List<string> { };
        string Date = "";
        public string trackid = "";
       

        public Booking()
        {
            InitializeComponent();              

        }

        private void Booking_Load(object sender, EventArgs e)
        {
                     

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                  

            if (txtcontactnumber.Text == "" || txtname.Text == "" || txtname.Text == "" || txtcount.Text=="")
            {
                MessageBox.Show("Please Fill all Fields");
                return;
            }
            if (txtcontactnumber.Text == "" || txtname.Text == "" || txtname.Text == "" || txtcount.Text == "")
                {
                    MessageBox.Show("Please Fill all Fields");
                    return;
                }
                else
                {    int Day=monthCalendar1.SelectionEnd.Day;
                    int Month = monthCalendar1.SelectionEnd.Month;
                    int Year = monthCalendar1.SelectionEnd.Year;
                    string Date = "'" +Year.ToString()+"-"+Month.ToString()+"-"+Day.ToString()+"'"  ;


                    try
                    {
                        if (txtcount.Text == "")
                        {
                            MessageBox.Show("Please Enter the count of tickets!!");
                            return;
                        }
                        Connect.command = Connect.connection.CreateCommand();

                        Connect.command.CommandText = "select max(id) as max from customer;";
                        Connect.OpenConnection();

                        Connect.reader = Connect.command.ExecuteReader();
                        Connect.reader.Read();
                        string A = "";

                        A = Connect.reader["max"].ToString();
                        if (A == "")
                        {
                            A = "1";
                        }
                        else
                        {
                            int co = 0;
                            co = Int32.Parse(A);
                            co++;
                            A = co.ToString();
                        }

                        Connect.CloseConnection();

                        Connect.command = Connect.connection.CreateCommand();

                        Connect.command.CommandText = "insert into customer values (" + A + ",'" + txtname.Text + "','" + txtcontactnumber.Text + "');";
                        Connect.OpenConnection();

                        Connect.command.ExecuteNonQuery();
                        Connect.CloseConnection();

                        bool next = true;
                        for (int i = 0; i < Int32.Parse(txtcount.Text); i++)
                        {
                            CustomerDetails Form12 = new CustomerDetails();
                            if (next==true)
                            {
                               

                                Form12.txtref.Text = Form12.ticketnumber = (Int32.Parse(txtref.Text) + i).ToString();

                                Form12.bookedby = A;
                                Form12.lbltyp.Text = lblclass.Text;
                                Form12.Date = Date;
                                Form12.trainid = txttraindid.Text;
                                Form12.trackid = trackid;
                                Form12.travelclass = travelclass;
                                Form12.farerate = txtfarerate.Text;
                                Form12.Show();

                                for (int j = 1; j <= 20; j++)
                                {
                                    if (Seats.Contains(j.ToString()) == true)
                                    {

                                    }
                                    else
                                    {
                                        Form12.comboseatsno.Items.Add(j.ToString());

                                    }
                                }
                         //       next = false;
                               
                            }
                            
                           
                           



                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Connect.CloseConnection();
                    }
                }
        }
        private void Availableseats()
        {
     
            int Day = monthCalendar1.SelectionEnd.Day;
            int Month = monthCalendar1.SelectionEnd.Month;
            int Year = monthCalendar1.SelectionEnd.Year;
             Date = "'" + Year.ToString() + "-" + Month.ToString() + "-" + Day.ToString() + "'";
            try
            {
                Connect.command = Connect.connection.CreateCommand();

                Connect.command.CommandText = "select seatno from seats where ticketid in (select Ticketnumber from ticketdetails where trainid =" + txttraindid.Text + " and trackid=" + trackid + " and ticketnumber in ( select ticketnumber from ticket where Dates= "+Date+") )  ;";
                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader();
               
                while(Connect.reader.Read())
                {
                    Seats.Add(Connect.reader["seatno"].ToString());
                }
                txtavailableseats.Text = (20 - Seats.Count).ToString();
                Connect.CloseConnection();                      

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontactnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtcontactnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtseatno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            Availableseats();
        }

        private void txtcount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
