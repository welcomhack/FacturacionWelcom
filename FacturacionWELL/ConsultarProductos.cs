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
    public partial class ConsultarProductos : Consultas
    {
        public ConsultarProductos()
        {
            InitializeComponent();
        }
        private void ConsultarProductos_Load_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDatGV("Administracion.dbo.Articulo").Tables[0];
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                dataGridView1.DataSource = LlenarDatGV("Administracion.dbo.Articulo").Tables[0];
            }
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {

                    DataSet ds;
                    string cmd = "Select * from Administracion.dbo.Articulo where Nom_pro like ('%" + textBox1.Text.Trim() + "%')";
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error! " + error.Message);
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {

                DataSet ds;
                string cmd = "Select * from Administracion.dbo.Articulo where Nom_pro like ('%" + textBox1.Text.Trim() + "%')";
                ds = Utilidades.Ejecutar(cmd);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error! " + error.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
