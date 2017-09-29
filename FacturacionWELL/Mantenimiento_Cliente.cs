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
    public partial class Mantenimiento_Cliente : Mantenimiento
    {
        public Mantenimiento_Cliente()
        {
            InitializeComponent();
        }
        Utilidades Valid = new Utilidades();
        public Boolean ValidarDatos()
        {
            bool Ok = false;
            if (txtIdcli.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtIdcli, "Ingrese una ID");
            }
            if (txtNomcli.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtNomcli, "Ingrese Nombre");
            }
            if (txtApecli.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtApecli, "Ingrese un Apellido");
            }


            return Ok;

        }

        public override Boolean Guardar()
        {
            if (ValidarDatos() == false)
            {

                try
                {
                    string cmd = string.Format("exec Administracion.dbo.ActualizaClientes '{0}','{1}','{2}'", txtIdcli.Text.Trim(), txtNomcli.Text.Trim(), txtApecli.Text.Trim());

                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado la informacion del cliente.  " + txtNomcli.Text.Trim(), "Aviso!!");
                    return true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("No se ha podido Guarda la informacion del cliente." + error.Message);
                    return false;
                }
            }
            return ValidarDatos();
        }
        public override void Eliminar()
        {

            try
            {
                string cmd = string.Format("exec Administracion.dbo.EliminarClientes '{0}'", txtIdcli.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se eliminó el Cliente.");

            }
            catch (Exception error)
            {
                MessageBox.Show("No se ha  podido eliminar el Cliente." + error.Message);
            }
        }

        private void Mantenimiento_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNomcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.SoloLetras(e);
        }

        private void txtApecli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.SoloLetras(e);
        }

        private void txtIdcli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtNomcli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtApecli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtIdcli_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.SoloNumeros(e);
        }
    }
    
}
