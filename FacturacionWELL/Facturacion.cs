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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }
        public Boolean ValidarDatos()
        {
            bool Ok = false;
            if (txtCodiCli.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtCodiCli, "Ingrese un codigo");
            }
            if (txtCli.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtCli, "Ingrese Nombre");
            }
            if (txtCodPro.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtCodPro, "Ingrese un Codigo del producto");
            }
            if (txtDescrip.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtDescrip, "Ingrese una descripcion del producto");
            }
            if (txtPrecio.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtPrecio, "Ingrese un precio del producto");
            }
            if (txtCantidad.Text == "")
            {
                Ok = true;
                errorProvider1.SetError(txtCantidad, "Ingrese una Cantidad");
            }


            return Ok;

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string cmd = "select * from Administracion.dbo.Usuarios where id_usuario=" + VentanaLogin.codigo;
            DataSet ds;
            ds = Utilidades.Ejecutar(cmd);
            txtAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCodiCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCli_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCodPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtDescrip_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(txtCodiCli.Text.Trim()) == false)
                {
                    string cmd = string.Format("select * from Administracion.dbo.Cliente where id_cliente='{0}'", txtCodiCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    txtCli.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();
                    txtCodPro.Focus();
                }
            }catch(Exception error)
            {
                MessageBox.Show("error al consultarel cliente.." + error.Message);
            }
        }
    }
}
