using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorTemp
    {
        Funciones f = new Funciones();
        float temperatura;

        public float GenerarTemperaturas()
        {
            Random random = new Random();

            temperatura = random.Next(-10, 100);
            return temperatura;
        }
        public void MostrarTemperatura(Label label)
        {
            float temperatura = GenerarTemperaturas();
            label.Text = temperatura.ToString("F2");
        }

        public void GuardarTemperatura(string idSensor, string temperatura, bool estado)
        {
            try
            {
                // Convertir el estado booleano a 1 o 0
                int estadoInt = estado ? 1 : 0;

                // Asegúrate de que los valores numéricos están correctamente formateados
                string query = $"INSERT INTO Sensores (idSensor, temperatura, stateSensor) VALUES ('{idSensor}', {temperatura}, {estadoInt})";

                f.Guardar(query);
            }
            catch (Exception e)
            {
                // Mostrar el error exacto para facilitar la depuración
                MessageBox.Show($"ERROR!!: {e.Message}", "!ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
