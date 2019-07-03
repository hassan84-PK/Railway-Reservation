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
    public partial class FormupdateFare : Form
    {
        DBConnect Connect = new DBConnect();
        public FormupdateFare()
        {
            InitializeComponent();
            try
            {
                btnypdate.Enabled = false;
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select name from traininfo";
                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader();
                while(Connect.reader.Read())
                { 
                    comboTrainname.Items.Add(Connect.reader["name"].ToString());
                }
                Connect.CloseConnection(); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtnewfarerate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) == true && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void FormupdateFare_Load(object sender, EventArgs e)
        {

        }

        private void comboTrainname_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            try
            {
                if (comboBox1.Text=="" || comboTrainname.Text=="")
                {
                    comboBox2.Items.Clear();
                    comboTrainname.Items.Clear();
                    return;
                }
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
             catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select fares.farerate  from fares where trainid in ( select id from traininfo where name = '" + comboTrainname.Text + "' ) and trackid in (select trackid from tracks where Routefrom = (select id from routes where name = '" + comboBox1.Text + "')  and Routeto = (select id from routes where name = '" + comboBox2.Text + "') ) and class = 1";
                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader();
                while (Connect.reader.Read())
                {
                    txtcurrentfareEco.Text = Connect.reader["farerate"].ToString();
                }
                Connect.CloseConnection();

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "select fares.farerate  from fares where trainid in ( select id from traininfo where name = " + comboTrainname.Text + " ) and trackid in (select trackid from tracks where Routefrom = (select id from routes where name = '" + comboBox1.Text + "')  and Routeto = (select id from routes where name = '" + comboBox2.Text + "') ) and class = 2";
                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader();
                while (Connect.reader.Read())
                {
                    txtbussfarecurr.Text = Connect.reader["farerate"].ToString();
                }
                btnypdate.Enabled = true;
                Connect.CloseConnection();      

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnypdate_Click(object sender, EventArgs e)
        {
            if (txtbussfarenew.Text=="" || txtnewfarerateEco.Text=="")
            {
                MessageBox.Show("Kindly Fill the Boxes");
                return;
            }
            try
            {
                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "update fares set farerate = " + txtnewfarerateEco.Text + " where trainid in ( select id from traininfo where name = " + comboTrainname.Text + " ) and trackid in (select trackid from tracks where Routefrom = (select id from routes where name = '" + comboBox1.Text + "')  and Routeto = (select id from routes where name = '" + comboBox2.Text + "')) and class =1";
                Connect.OpenConnection();
                Connect.command.ExecuteNonQuery();                
                Connect.CloseConnection();


                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "update fares set farerate = " + txtbussfarenew.Text + " where trainid in ( select id from traininfo where name = " + comboTrainname.Text + " ) and trackid in (select trackid from tracks where Routefrom = (select id from routes where name = '" + comboBox1.Text + "')  and Routeto = (select id from routes where name = '" + comboBox2.Text + "')) and class =2";
                Connect.OpenConnection();
                Connect.command.ExecuteNonQuery();
                Connect.CloseConnection();
                MessageBox.Show("Fare Updates!!!");
                txtbussfarenew.Text = txtbussfarecurr.Text = txtcurrentfareEco.Text = txtnewfarerateEco.Text = "";
                comboBox2.Items.Clear();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
