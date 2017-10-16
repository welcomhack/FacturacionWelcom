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
    public partial class ConsultaUsuario : Consultas
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LlenarDatGV("Administracion.dbo.Usuarios").Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                dataGridView1.DataSource = LlenarDatGV("Administracion.dbo.Usuarios").Tables[0];
            }
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {

                    DataSet ds;
                    string cmd = "Select * from Administracion.dbo.Usuarios where Nom_usu like ('%" + textBox1.Text.Trim() + "%')";
                    ds = Utilidades.Ejecutar(cmd);
                    dataGridView1.DataSource = ds.Tables[0];
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error! " + error.Message);
                }
            }
        }
    }
}