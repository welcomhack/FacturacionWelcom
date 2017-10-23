namespace FacturacionWELL
{
    partial class ConsultarProductos
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
            this.button2.Location = new System.Drawing.Point(376, 468);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(174, 468);
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.OnValueChanged += new System.EventHandler(this.textBox1_OnValueChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(609, 468);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(755, 3);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMini
            // 
            this.btnMini.Location = new System.Drawing.Point(697, 3);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Location = new System.Drawing.Point(726, 3);
            // 
            // ConsultarProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 533);
            this.Name = "ConsultarProductos";
            this.Text = "ConsultarProductos";
            this.Load += new System.EventHandler(this.ConsultarProductos_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}