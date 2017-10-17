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
    public partial class Contenedor_Prinsipal : Form
    {
        private int childFormNumber = 0;

        public Contenedor_Prinsipal()
        {
            InitializeComponent();
        }
#pragma warning disable CS0649 // El campo 'Contenedor_Prinsipal.ManCli' nunca se asigna y siempre tendrá el valor predeterminado null
        Mantenimiento_Cliente ManCli;
#pragma warning restore CS0649 // El campo 'Contenedor_Prinsipal.ManCli' nunca se asigna y siempre tendrá el valor predeterminado null
#pragma warning disable CS0649 // El campo 'Contenedor_Prinsipal.ManPro' nunca se asigna y siempre tendrá el valor predeterminado null
        Mantenimiento_Producto ManPro;
#pragma warning restore CS0649 // El campo 'Contenedor_Prinsipal.ManPro' nunca se asigna y siempre tendrá el valor predeterminado null
#pragma warning disable CS0649 // El campo 'Contenedor_Prinsipal.ConsCli' nunca se asigna y siempre tendrá el valor predeterminado null
        ConsultarCliente ConsCli;
#pragma warning restore CS0649 // El campo 'Contenedor_Prinsipal.ConsCli' nunca se asigna y siempre tendrá el valor predeterminado null
#pragma warning disable CS0649 // El campo 'Contenedor_Prinsipal.ConsPro' nunca se asigna y siempre tendrá el valor predeterminado null
        ConsultarProductos ConsPro;
#pragma warning restore CS0649 // El campo 'Contenedor_Prinsipal.ConsPro' nunca se asigna y siempre tendrá el valor predeterminado null

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Contenedor_Prinsipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManCli==null )
            {

                Mantenimiento_Cliente ManCli = new Mantenimiento_Cliente();
                ManCli.MdiParent = this;
                ManCli.Show();
                
            }
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ManPro == null)
            {

                Mantenimiento_Producto ManPro = new Mantenimiento_Producto();
                ManPro.MdiParent = this;
                ManPro.Show();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConsCli == null)
            {

                ConsultarCliente ConsCli = new ConsultarCliente();
                ConsCli.MdiParent = this;
                ConsCli.Show();
            }

        }
        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ConsPro == null)
            {

                ConsultarProductos ConsPro = new ConsultarProductos();
                ConsPro.MdiParent = this;
                ConsPro.Show();
            }
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Contenedor_Prinsipal_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void facturasionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturacion Factu = new Facturacion();
            Factu.MdiParent = this;
            Factu.Show();
        }
    }
}
