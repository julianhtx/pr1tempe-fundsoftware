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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace practicaTemperaturaIS
{
    public partial class frmBuscarUsuarios : Form
    {
        int fila = 0, columna = 0;
        int idUser, level;
        string userName, password, firstName, lastName;

        private void btnAgregarUsuarios_Click(object sender, EventArgs e)
        {
            frmEditUser frmEditUser = new frmEditUser();
            frmEditUser.ShowDialog();
        }

        manejadorUsers mu;

        private void txtBusquedaU_TextChanged(object sender, EventArgs e)
        {
            mu.Mostrar(dtgvBusqueda, txtBusquedaU.Text);
        }

        private void dtgvBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        idUser = int.Parse(dtgvBusqueda.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(idUser, dtgvBusqueda.Rows[fila].Cells[1].Value.ToString());
                        dtgvBusqueda.Visible = false;
                    }
                    break;
                case 7:
                    {
                        idUser = int.Parse(dtgvBusqueda.Rows[fila].Cells[0].Value.ToString());
                        userName = dtgvBusqueda.Rows[fila].Cells[1].Value.ToString();
                        password = "";
                        firstName = dtgvBusqueda.Rows[fila].Cells[3].Value.ToString();
                        lastName = dtgvBusqueda.Rows[fila].Cells[4].Value.ToString();
                        level = int.Parse(dtgvBusqueda.Rows[fila].Cells[5].Value.ToString());
                        frmEditUser Add = new frmEditUser();
                        Add.ShowDialog();
                        dtgvBusqueda.Visible = false;
                    }
                    break;
            }
        }

        public frmBuscarUsuarios()
        {
            InitializeComponent();
            mu = new manejadorUsers();
        }

    }
}
