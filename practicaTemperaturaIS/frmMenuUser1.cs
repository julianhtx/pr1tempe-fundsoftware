using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaTemperaturaIS
{
    public partial class frmMenuUser1 : Form
    {
        manejadorUsers mu;
        ManejadorTemp mt;
        public int lvlUsuarios;
        public static int idUser = 0, level = 0;
        public static string userName, password, firstName, lastName = "";

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            frmMenuUser2 fau2 = new frmMenuUser2(lvlUsuarios);
            fau2.MdiParent = this;
            fau2.Show();
        }

        public frmMenuUser1(int lvlUsuario)
        {
            InitializeComponent();
            this.lvlUsuarios = lvlUsuario;
            mu = new manejadorUsers();
            if (lvlUsuarios == 1)
            {
                frmAdminUser fau = new frmAdminUser();
                fau.MdiParent = this;
                fau.Show();
            }
            else
            {
                toolStripLabel3.Visible = true;
                toolStripLabel1.Enabled = false;
                toolStripLabel1.Visible = false;
            }
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
                frmAdminUser fau = new frmAdminUser();
                fau.MdiParent = this;
                fau.Show();
        }

        private void frmMenuUser1_Load(object sender, EventArgs e)
        {

        }
    }
}
