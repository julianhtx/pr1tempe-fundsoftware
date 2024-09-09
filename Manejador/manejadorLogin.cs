using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;

namespace Manejador
{
    public class manejadorLogin
    {
        Funciones f = new Funciones();

        public string[] Validar(string _userName, string _password)
        {
            string[] resultado = new string[2];
            DataSet r = f.Mostrar($"call p_ValidarUsuario('{_userName}', '{Sha1(_password)}')", "Users");
            DataTable dt = r.Tables[0];
            resultado[0] = dt.Rows[0]["rs"].ToString();
            resultado[1] = dt.Rows[0]["Nivel"].ToString();
            return resultado;
        }

        public int ObtenerNivelUsuario(string user)
        {
            string query = $"SELECT level FROM Users WHERE userName = '{user}'";
            string lvlUsuarioStr = f.ObtenerDato(query, "Users", "Nivel");
            int lvlUsuario = 0;
            int.TryParse(lvlUsuarioStr, out lvlUsuario);
            return lvlUsuario;
        }

        public static string Sha1(string texto)
        {
            SHA1 sha1 = SHA1CryptoServiceProvider.Create();
            Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
            Byte[] hash = sha1.ComputeHash(textOriginal);
            StringBuilder cadena = new StringBuilder();
            foreach (byte i in hash)
            {
                cadena.AppendFormat("{0:x2}", i);
            }
            return cadena.ToString();
        }
    }
}
