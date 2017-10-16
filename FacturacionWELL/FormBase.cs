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

        

        private void FormBase_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            //DialogResult = DialogResult.OK;
           // Close();
            //dialogo de confirmasion
            /* if (MessageBox.Show("Desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
             {

                  Application.Exit();
             }*/
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
                
           
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;

            }else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //dialogo de confirmasion
            if (MessageBox.Show("Desea salir?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
