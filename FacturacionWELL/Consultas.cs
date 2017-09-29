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
using System.Data.SqlClient;

namespace FacturacionWELL
{
    public partial class Consultas : FormBase
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet LlenarDatGV(string Tabla)
        {
            DataSet DS;
            string cmd = string.Format("Select * from " + Tabla);
            DS = Utilidades.Ejecutar(cmd);
            return DS;
        }

        private void Consultas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }
    }
}
