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
using AccesoDatos;

namespace practicaTemperaturaIS
{
    public partial class frmMenuUser2 : Form
    {
        ManejadorTemp mt;
        Funciones f;
        public int lvlUsuarios;
        public frmMenuUser2(int lvlUsuario)
        {
            InitializeComponent();
            f = new Funciones();
            mt = new ManejadorTemp();
            this.lvlUsuarios = lvlUsuario;
            if(lvlUsuarios == 3)
            {
                lblS1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
            }
        }

        private void btnSensor1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer3.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer3.Stop();
        }

        private void btnSensor2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            timer3.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer4.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mt.MostrarTemperatura(lblS1);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            mt.MostrarTemperatura(label4);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            mt.GuardarTemperatura(label2.Text, lblS1.Text, true);
        }

        private void frmMenuUser2_Load(object sender, EventArgs e)
        {

        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            mt.GuardarTemperatura(label1.Text, label4.Text, true);
        }
    }
}
