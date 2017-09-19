using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milibreria;

namespace FacturacionWELL
{
    public partial class Mantenimiento_Producto : Mantenimiento
    {
        public Mantenimiento_Producto()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            try
            {
                string cmd = string.Format("exec ActualizaArticulos '{0}','{1}','{2}'", txtIdpro.Text.Trim(), txtNompro.Text.Trim(), txtPrecio.Text.Trim());

                Utilidades.Ejecutar(cmd);
                MessageBox.Show("se ha guardado la infirmacion.");
                return true;

            }
            catch(Exception error)
            {
                MessageBox.Show("No se ha podido Guarda la informacion" + error.Message);
                return false;
            }
        }
    }
}
