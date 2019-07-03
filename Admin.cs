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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void btntrain_Click(object sender, EventArgs e)
        {
            Formtrainadd Form4 = new Formtrainadd();
            Form4.Show();
            
        }

        private void btnupdatefare_Click(object sender, EventArgs e)
        {
            FormupdateFare Form5 = new FormupdateFare();
            Form5.Show();


        }
    }
}
