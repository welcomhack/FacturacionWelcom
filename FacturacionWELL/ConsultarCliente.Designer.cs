namespace FacturacionWELL
{
    partial class ConsultarCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 465);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(163, 465);
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(611, 463);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(758, 3);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMini
            // 
            this.btnMini.Location = new System.Drawing.Point(700, 3);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Location = new System.Drawing.Point(729, 3);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 537);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}