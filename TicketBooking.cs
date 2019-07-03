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
    public partial class TicketBooking : Form
    {
        DBConnect Connect = new DBConnect();
        public TicketBooking()
        {
            InitializeComponent();
        }


        private void TicketBooking_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text=="")
            {
                comboBox2.Items.Clear();
                comboTrainname.Items.Clear();
                comboTrainname.Text = "";
                txtfarerateEconomy.Text = "";
                txtfarerateBuss.Text = "";
                txttraindid.Text = "";
                comboTrainname.Items.Clear();
            }
            else
            {
                comboBox2.Items.Clear();
                if (comboBox1.Text == "Lahore")
                {
                    comboBox2.Items.Add("Karachi");
                    comboBox2.Items.Add("Rawalpindi");
                }
                else if (comboBox1.Text == "Karachi")
                {
                    comboBox2.Items.Add("Lahore");
                    comboBox2.Items.Add("Rawalpindi");

                
                }
                else if (comboBox1.Text == "Rawalpindi")
                {
                    comboBox2.Items.Add("Lahore");
                    comboBox2.Items.Add("Karachi");    
                }
                                                                             
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboTrainname.Text = "";
            comboTrainname.Items.Clear();
            if (comboBox2.Text=="")
            {
                comboTrainname.Enabled = false;
                txttraindid.Text = "";
  
                return;
            }
            try {
                Connect.OpenConnection();
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select traintracks.trainid,traininfo.name from traintracks join traininfo on traininfo.id= traintracks.trainid where traintracks.trackid in ( select trackid from tracks where routefrom in (select id from routes where name ='"+comboBox1.Text+"') and routeto in(select id from routes where name = '"+comboBox2.Text+"'));";
                Connect.reader= Connect.command.ExecuteReader();
                string trainname = "";
                
                while (Connect.reader.Read())
                {
                    trainname = Connect.reader["name"].ToString();
                    comboTrainname.Items.Add(trainname);       
                }
                
                Connect.CloseConnection();
                
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

        private void txttraindid_TextChanged(object sender, EventArgs e)
        {
            
        }

      

        private void comboTrainname_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboTrainname.Text=="")
            {
                txttraindid.Text = "";
            }
            try
            {
                Connect.OpenConnection();
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select id from traininfo where name ='" + comboTrainname.Text + "'";
                Connect.reader = Connect.command.ExecuteReader();
                string trainid = "";
                
                while (Connect.reader.Read())
                {
                    trainid = Connect.reader["id"].ToString();
                }
                txttraindid.Text = trainid;

                Connect.CloseConnection();

                Connect.OpenConnection();

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select farerate from fares where  trainid=" + trainid + " and class=1  and trackid in (select trackid from tracks where routefrom in (select id from routes where name ='" + comboBox1.Text + "') and routeto in(select id from routes where name = '" + comboBox2.Text + "'));";
                Connect.reader = Connect.command.ExecuteReader();  
                Connect.reader.Read();
                txtfarerateEconomy.Text = Connect.reader["farerate"].ToString(); 
                Connect.CloseConnection();

                Connect.OpenConnection();

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select farerate from fares where  trainid=" + trainid + " and class=2  and trackid in (select trackid from tracks where routefrom in (select id from routes where name ='" + comboBox1.Text + "') and routeto in(select id from routes where name = '" + comboBox2.Text + "'));";
                Connect.reader = Connect.command.ExecuteReader();
                Connect.reader.Read();
                txtfarerateBuss.Text= Connect.reader["farerate"].ToString();
                Connect.CloseConnection();


                
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

        private void button1_Click(object sender, EventArgs e)
        {

            Booking Form3 = new Booking();
            if (rbtnbsclass.Checked==false && rbtnecoclass.Checked==false)
            {
                MessageBox.Show("Kindly Select Ticket Type");
                return;
            }

            Form3.txtdestination.Text = comboBox2.Text;
            Form3.txtsource.Text = comboBox1.Text;
            Form3.txttraindid.Text = txttraindid.Text;
            Form3.txttrainname.Text = comboTrainname.Text;

            Form3.txtfarerate.Text = txtfarerateEconomy.Text;
            if (rbtnbsclass.Checked==true)
            {
                Form3.lblclass.Text = "Bussniess Class";
                Form3.txtfarerate.Text = txtfarerateBuss.Text;
                Form3.travelclass = "Busniess";
            }
            else
            {
                Form3.lblclass.Text = "Economy Class";
                Form3.txtfarerate.Text = txtfarerateEconomy.Text;
                Form3.travelclass = "Economy";
            }          



            try
            {
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select max(ticketnumber) as max from ticket";     

                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader(); 
                Connect.reader.Read();

                string trf = Connect.reader["max"].ToString();
                int refe;
                if (trf=="")
                {
                    refe = 1;
                }
                else
                {
                    refe = Int32.Parse(trf);
                    refe++;
                }                   
                Form3.txtref.Text = refe.ToString();
                Connect.CloseConnection();


                Connect.OpenConnection();

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select trackid from tracks where routefrom in (select id from routes where name ='" + comboBox1.Text + "') and routeto in(select id from routes where name = '" + comboBox2.Text + "')";
                Connect.reader = Connect.command.ExecuteReader();
                Connect.reader.Read();
                Form3.trackid=Connect.reader["trackid"].ToString();
                

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
         
            this.Hide();
              Form3.Show();
        }

        private void txtfarerate_TextChanged(object sender, EventArgs e)
        {
            if (txtfarerateEconomy.Text=="")
            {
                button1.Visible = false;

            }
            else
            {
                button1.Visible = true;
            }
        }

        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}
