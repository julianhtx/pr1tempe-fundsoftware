using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTemperaturaIS
{
    public partial class frmAdminUser : Form
    {
        public frmAdminUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEditUser fue = new frmEditUser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmEditUser fue = new frmEditUser();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEditUser frm = new frmEditUser();
        }
    }
}
