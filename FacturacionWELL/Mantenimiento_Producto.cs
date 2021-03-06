﻿using System;
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
    public partial class Mantenimiento_Producto : Mantenimiento
    {
        public Mantenimiento_Producto()
        {
            InitializeComponent();
        }
        Utilidades Valid = new Utilidades();

        public Boolean ValidarDatos()
        {
            bool Ok = false;
            if (txtIdpro.Text == "")
            {
                Ok = true;
                errorProvider2.SetError(txtIdpro, "Ingrese una ID");
            }
            if (txtNompro.Text == "")
            {
                Ok = true;
                errorProvider2.SetError(txtNompro, "Ingrese Nombre");
            }
            if (txtPrecio.Text == "")
            {
                Ok = true;
                errorProvider2.SetError(txtPrecio, "Ingrese un Precio");
            }
            

            return Ok;

        }

        public override Boolean Guardar()

        {
            if (ValidarDatos() == false)
            {


                try
                {
                    string cmd = string.Format("exec Administracion.dbo.ActualizaArticulos '{0}','{1}','{2}'", txtIdpro.Text.Trim(), txtNompro.Text.Trim(), txtPrecio.Text.Trim());

                    Utilidades.Ejecutar(cmd);
                    MessageBox.Show("se ha guardado la informacion.");
                    return true;

                }
                catch (Exception error)
                {
                    MessageBox.Show("No se ha podido Guarda la informacion" + error.Message);
                    return false;
                }

            }
            return ValidarDatos();
                
            
        }
        public override void Eliminar()
        {

            try
            {
                string cmd = string.Format("exec Administracion.dbo.EliminarArticulos '{0}'", txtIdpro.Text.Trim());
                Utilidades.Ejecutar(cmd);
                MessageBox.Show("Se eliminó el articulo.");

            }
            catch(Exception error)
            {
                MessageBox.Show("No se ha  podido eliminar el articulo." + error.Message);
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }


        private void txtNompro_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void Mantenimiento_Producto_Load(object sender, EventArgs e)
        {

        }

        private void txtIdpro_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
            
        }

        private void txtNompro_TextChanged_1(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            errorProvider2.Clear();
        }

        private void txtIdpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            Valid.SoloNumeros(e);
        }

        private void txtNompro_KeyPress(object sender, KeyPressEventArgs e)
        {
            Valid.SoloLetras(e);
        }
    }
}
