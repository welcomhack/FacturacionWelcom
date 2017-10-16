using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Milibreria;

namespace FacturacionWELL

   
{
    public partial class VentanaLogin : FormBase
    {
        public static String codigo = "";

        public VentanaLogin()
        {
            InitializeComponent();
        }

       

        private void butCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VentanaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            
            try
            {


                string CMD = string.Format("Select * FROM Administracion.dbo.Usuarios WHERE account='{0}' AND Password='{1}'", txtNomAcc.Text.Trim(), txtPass.Text.Trim());
                DataSet ds = Utilidades.Ejecutar(CMD);

                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == txtNomAcc.Text.Trim() && contra == txtPass.Text.Trim())
                {
                   // RecordUsu = txtNomAcc.Text.Trim();

                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        VentanaAdmin VenAd = new VentanaAdmin();
                        this.Hide();

                        VenAd.Show();

                    }
                    else if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == false)
                    {
                        VentanaUser VenUs = new VentanaUser();
                        this.Hide();
                        VenUs.Show();
                    }
                    else
                        MessageBox.Show("Usuario o contraseña incorectos ");


                }


            }
            catch (Exception error)
            {
                MessageBox.Show("error al iniciar sescion.." + error.Message);
            }
        }

        private void txtNomAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

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
