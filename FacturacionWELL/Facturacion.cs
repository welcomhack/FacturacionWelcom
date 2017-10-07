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

        private void txtAtiende_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public static int ContFilas = 0;
        public static double Total;

        private void btnColocar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == false)
            {
                bool Existe = false;
                int Num_fila = 0;
                if (ContFilas == 0)
                {
                    dataGridView1.Rows.Add(txtCodPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                    double Importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                    dataGridView1.Rows[ContFilas].Cells[4].Value = Importe;
                    ContFilas ++;
                }
                else
                {

                    foreach(DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == txtCodPro.Text)
                        {
                            Existe = true;
                            Num_fila = fila.Index;
                        }
                    }
                    if (Existe == true)
                    {
                        dataGridView1.Rows[Num_fila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[Num_fila].Cells[3].Value)).ToString();
                        double Importe= Convert.ToDouble(dataGridView1.Rows[Num_fila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Num_fila].Cells[3].Value);
                        dataGridView1.Rows[Num_fila].Cells[4].Value = Importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodPro.Text, txtDescrip.Text, txtPrecio.Text, txtCantidad.Text);
                        double Importe = Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[ContFilas].Cells[3].Value);
                        dataGridView1.Rows[ContFilas].Cells[4].Value = Importe;
                        ContFilas++;
                    }
                }
                Total = 0;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Total += Convert.ToDouble(fila.Cells[4].Value);

                }
                lblTotal.Text = "COP.$: " + Total.ToString();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (ContFilas > 0)
            {
                Total = Total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "COP.$: " + Total.ToString();
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                ContFilas--;
            }
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente Concli = new ConsultarCliente();
            Concli.ShowDialog();
            if (Concli.DialogResult == DialogResult.OK)
            {
                txtCodiCli.Text = Concli.dataGridView1.Rows[Concli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCli.Text=Concli.dataGridView1.Rows[Concli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCodPro.Focus();

            }

        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();
            ConPro.ShowDialog();
            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtCodPro.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescrip.Text= ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text= ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCantidad.Focus();

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }
        public override void Nuevo()
        {
            txtCodiCli.Text = "";
            txtCli.Text = "";
            txtCodPro.Text = "";
            txtDescrip.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";
            lblTotal.Text = "COP.$: 0";
            dataGridView1.Rows.Clear();
            ContFilas = 0;
            Total = 0;
            txtCodiCli.Focus();

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if(ContFilas != 0)
            {

                try
                {
                    string cmd = string.Format("exec Administracion.dbo.ActualizaFacturas '{0}'", txtCodiCli.Text.Trim());
                    DataSet ds = Utilidades.Ejecutar(cmd);
                    string Numfac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();
                    foreach(DataGridViewRow fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("Administracion.dbo.ActualizaDetalles '{0}','{1}','{2}','{3}'", Numfac, fila.Cells[0].Value.ToString(), fila.Cells[2].Value.ToString(), fila.Cells[3].Value.ToString());
                        ds = Utilidades.Ejecutar(cmd);
                    }
                    cmd = "exec Administracion.dbo.DatosFactura " + Numfac;
                    ds = Utilidades.Ejecutar(cmd);

                    //Vetana Reporte
                    Reporte rp = new Reporte();
                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();
                    Nuevo();

                }catch(Exception error)
                {
                    MessageBox.Show("Ocurrio un error " + error.Message);
                }
            }
        }
    }
}
