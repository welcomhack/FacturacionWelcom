using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Milibreria
{
    public class Utilidades
    {
        public static DataSet Ejecutar(string cmd)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            Con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);
            DP.Fill(DS);

            Con.Close();
            return DS;
           
        }


        public void SoloLetras(KeyPressEventArgs Event)
        {
            try
            {
                if (char.IsLetter(Event.KeyChar))
                {
                    Event.Handled = false;
                }
                else if (char.IsControl(Event.KeyChar))
                {
                    Event.Handled = false;
                }
                else if (char.IsSeparator(Event.KeyChar))
                {
                    Event.Handled = false;
                }
                else
                {
                    Event.Handled = true;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("error" + error);
            }
        }
        public void SoloNumeros(KeyPressEventArgs Event)
        {
            try
            {
                if (char.IsNumber(Event.KeyChar))
                {
                    Event.Handled = false;
                }
                else if (char.IsControl(Event.KeyChar))
                {
                    Event.Handled = false;
                }
                else
                {
                    Event.Handled = true;
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("error" + error);
            }
        }

    }
    
}
