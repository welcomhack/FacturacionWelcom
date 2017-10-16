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
    public partial class VentanaAdmin : FormBase
    {
        public VentanaAdmin()
        {
            InitializeComponent();
        }

        private void VentanaAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VentanaLogin VenLog = new VentanaLogin();
            this.Hide();
            VenLog.Show();
        }

        private void VentanaAdmin_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Administracion.dbo.Usuarios WHERE id_usuario= " + VentanaLogin.codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);
            lvlNomAdmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lvlUsAdmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lvlCodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url= DS.Tables[0].Rows[0]["Foto"].ToString();
            pictureBox1.Image = Image.FromFile(url);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Contenedor_Prinsipal Conp = new Contenedor_Prinsipal();
            this.Hide();
            Conp.Show();
        }

        private void lvlNomAdmin_Click(object sender, EventArgs e)
        {

        }

        private void lvlUsAdmin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdministrarUsuarios AdmiUs = new AdministrarUsuarios();
            AdmiUs.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la Aplicacion?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
