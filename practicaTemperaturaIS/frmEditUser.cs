using Manejador;
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
    public partial class frmEditUser : Form
    {
        manejadorUsers manejadorUsers;
        public frmEditUser()
        {
            InitializeComponent();
            manejadorUsers = new manejadorUsers();
            if(frmMenuUser1.idUser > 0)
            {
                textBox1.Text = frmMenuUser1.userName.ToString();
                textBox3.Text = frmMenuUser1.firstName.ToString();
                textBox4.Text = frmMenuUser1.lastName.ToString();
                textBox2.Text = frmMenuUser1.level.ToString();
                textBox5.Text = frmMenuUser1.password.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (frmMenuUser1.idUser > 0)
            {
                manejadorUsers.Modificar(textBox1, textBox5, textBox3, textBox4, textBox2, frmMenuUser1.idUser);
            }
            else
            {
                manejadorUsers.Guardar(textBox1, textBox5, textBox3, textBox4, textBox2);
            }
            Close();
        }
    }
}
