using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacturacionWELL
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //dialogo de confirmasion
            if(MessageBox.Show("Desea salir?","Aviso!",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1)== DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public virtual void Eliminar()
        {

        }
        public virtual void Nuevo()
        {


        }
        public virtual void Consultar()
        {


        }
        public virtual Boolean Guardar()
        {
            return false;

        }

        private void FormBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormBase_Load(object sender, EventArgs e)
        {

        }
    }
}
