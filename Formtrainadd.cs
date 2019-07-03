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
    public partial class Formtrainadd : Form
    {
        DBConnect Connect = new DBConnect();
        public Formtrainadd()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="")
            {
                return;
            }
            try
            {

                Connect.command = Connect.connection.CreateCommand();  
                Connect.command.CommandText = "select max(id) as max from traininfo";
                Connect.OpenConnection();
                Connect.reader = Connect.command.ExecuteReader();
                Connect.reader.Read();
                int id = 0;
                string idi=Connect.reader["max"].ToString();
                if (idi=="")
                {
                    id = 1;
                }
                else
                {
                    id = Int32.Parse(idi);
                    id++;
                }
                
                
                Connect.CloseConnection();                  

                Connect.command = Connect.connection.CreateCommand();
                Connect.command.CommandText = "insert into Traininfo values (" + id + ",'" + textBox1.Text + "')";
                Connect.OpenConnection();             
                Connect.command.ExecuteNonQuery();    
                Connect.CloseConnection();
                FormUpdateroutes Form3 = new FormUpdateroutes();
                Form3.trainid = id.ToString();
                Form3.Show();
                this.Hide();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                Connect.CloseConnection();
            }


        }
    }
}
