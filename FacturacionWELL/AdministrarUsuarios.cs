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
    public partial class AdministrarUsuarios : FormBase
    {
        public AdministrarUsuarios()
        {
            InitializeComponent();
        }
        public Boolean ValidarDatos()
        {
            bool OK = false;
            if (txtIdUsu.Text=="")
            {
                OK = true;
                errorProvider4.SetError(txtIdUsu, "Ingrese una ID ");
            }
            if (txtNomUsu.Text == "")
            {
                OK = true;
                errorProvider4.SetError(txtNomUsu, "Ingrese un Nombre ");
            }
            if (txtCuenta.Text == "")
            {
                OK = true;
                errorProvider4.SetError(txtCuenta, "Ingrese un Nombre de Cuenta ");
            }
            if (txtPass.Text == "")
            {
                OK = true;
                errorProvider4.SetError(txtPass, "Ingrese una Contraseña ");
            }
            if (txtPermiso.Text == "")
            {
                OK = true;
                errorProvider4.SetError(txtPermiso, "Ingrese permiso 0 Ó 1 ");
            }
            if (txtFoto.Text == "")
            {
                OK = true;
                errorProvider4.SetError(txtFoto, "Ingrese una ID ");
            }
            
            return OK;
        }
        private void AdministrarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ValidarDatos() == false)
            {
                try
                {
                    string cmd = string.Format("exec Administracion.dbo.ActualizaUsuario '{0}','{1}','{2}','{3}','{4}','{5}'", txtIdUsu.Text.Trim(), txtNomUsu.Text.Trim(), txtCuenta.Text.Trim(), txtPass.Text.Trim(), txtPermiso.Text.Trim(), txtFoto.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se ha guardado la informacion del Usuario:  " + txtNomUsu.Text);

                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrio un enrror " + error.Message);
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Seguro que desea eliminar el Usuario  " + txtIdUsu.Text, "Aviso! ", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {



                    string cmd = string.Format(" exec Administracion.dbo.EliminarUsuario '{0}'", txtIdUsu.Text.Trim());
                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("Se eliminó el usuario");
                }
            }catch(Exception error)
            {
                MessageBox.Show("Ocurrió un error  " + error.Message);
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ConsultaUsuario ConUsu = new ConsultaUsuario();
            ConUsu.ShowDialog();
            if (ConUsu.DialogResult == DialogResult.OK)
            {
                txtIdUsu.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtNomUsu.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtCuenta.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtPass.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
                txtPermiso.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
                txtFoto.Text = ConUsu.dataGridView1.Rows[ConUsu.dataGridView1.CurrentRow.Index].Cells[5].Value.ToString();
            }
        }
    }
}
