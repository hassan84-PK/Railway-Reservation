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
    public partial class FormUpdateroutes : Form
    {
        public string trainid;
        DBConnect Connect = new DBConnect();
        public FormUpdateroutes()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox2.Items.Clear();   
                txtfarerateEconomy.Text = "";

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

        private void txtfarerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="" || comboBox2.Text=="" )
            {
                MessageBox.Show("Please Fill all Fields");
                return;
            }
            else
            {
                try
                {                        
                    Connect.command = Connect.connection.CreateCommand();
                    Connect.command.CommandText = "insert into TrainTracks values ("+trainid+",(select trackid from tracks where tracks.routefrom in (select id from routes where name='"+comboBox1.Text+"') and tracks.routeto in (select id from routes where name = '"+comboBox2.Text+"')));";
                    Connect.OpenConnection();
                    Connect.command.ExecuteNonQuery();
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;                                                                              
                    Connect.CloseConnection();              


                 
                    Connect.CloseConnection();  

                }   catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void FormUpdateroutes_Load(object sender, EventArgs e)
        {

        }

        private void btnaddfare_Click(object sender, EventArgs e)
        {
            try
            {

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "insert into Fares values (" + trainid + ",(select trackid from tracks where tracks.routefrom in (select id from routes where name='" + comboBox1.Text + "') and tracks.routeto in (select id from routes where name = '" + comboBox2.Text + "')),1,"+txtfarerateEconomy.Text+");";
                Connect.OpenConnection();
                Connect.command.ExecuteNonQuery();
                Connect.CloseConnection();

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "insert into Fares values (" + trainid + ",(select trackid from tracks where tracks.routefrom in (select id from routes where name='" + comboBox1.Text + "') and tracks.routeto in (select id from routes where name = '" + comboBox2.Text + "')),2," + txtfarerateBsns.Text + ");";
                Connect.OpenConnection(); 
                Connect.command.ExecuteNonQuery();
                Connect.CloseConnection();

                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox2.Items.Clear();
                comboBox1.Text = "";
                comboBox2.Text = "";
                txtfarerateBsns.Text = "";
                txtfarerateEconomy.Text = "";


            }
            catch(Exception ex)
            {

                Connect.CloseConnection();
                MessageBox.Show(ex.Message);
            
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
    }
}
