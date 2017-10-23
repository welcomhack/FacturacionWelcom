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
    public partial class CambiarPass : FormBase
    {
        public CambiarPass()
        {
            InitializeComponent();
        }
        public Boolean ValidarDats()
        {
            bool OK = false;
            if (txtNewPass.Text == "")
            {
                OK = true;
                errorProvider1.SetError(txtNewPass, "Ingrese una contraseña");
            }
            if (txtRepPass.Text == "")
            {
                OK = true;
                errorProvider1.SetError(txtRepPass, "Repita la nueva contraseña");
            }

            return OK;
        }
        private void CambiarPass_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM Administracion.dbo.Usuarios WHERE id_usuario= " + VentanaLogin.codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);
            txtIdUsu.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();
            txtUsu.Text = DS.Tables[0].Rows[0]["account"].ToString();
            txtNewPass.Text = DS.Tables[0].Rows[0]["Password"].ToString();
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir de la Aplicacion?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (ValidarDats() == true && txtNewPass.Text == txtRepPass.Text)
            {
                try
                {
                    string cmd = string.Format("exec Administracion.dbo.ActualizaUsuario '{0}','{3}'", txtIdUsu.Text.Trim(), txtNewPass.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado la informacion del Usuario:  " + txtUsu.Text);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error  " + error.Message);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarDats() == false && txtNewPass.Text == txtRepPass.Text)
            {
                try
                {
                    string cmd = string.Format("exec Administracion.dbo.CambiarPass '{0}','{1}'", txtIdUsu.Text.Trim(), txtNewPass.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado la informacion del Usuario:  " + txtUsu.Text);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error  " + error.Message);
                }
            }
        }

        private void txtNewPass_OnValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void txtRepPass_OnValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            VentanaLogin VentLog = new VentanaLogin();
            VentLog.Show();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
