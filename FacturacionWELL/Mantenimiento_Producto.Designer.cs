namespace FacturacionWELL
{
    partial class Mantenimiento_Producto
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNompro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtIdpro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(343, 181);
            this.button4.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 134);
            this.button3.TabIndex = 5;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(343, 85);
            this.button2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(343, 38);
            this.button1.TabIndex = 3;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconVisible = true;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconVisible = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(379, 239);
            this.btnSalir.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 58;
            this.label1.Text = "ID_Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 19);
            this.label2.TabIndex = 59;
            this.label2.Text = "Nom_Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 60;
            this.label3.Text = "Precio:";
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // txtPrecio
            // 
            this.txtPrecio.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtPrecio.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecio.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtPrecio.BorderThickness = 2;
            this.txtPrecio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrecio.ForeColor = System.Drawing.Color.White;
            this.txtPrecio.isPassword = false;
            this.txtPrecio.Location = new System.Drawing.Point(148, 138);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(164, 27);
            this.txtPrecio.TabIndex = 2;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.OnValueChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            this.txtPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecio_KeyPress);
            // 
            // txtNompro
            // 
            this.txtNompro.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtNompro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNompro.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtNompro.BorderThickness = 2;
            this.txtNompro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNompro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNompro.ForeColor = System.Drawing.Color.White;
            this.txtNompro.isPassword = false;
            this.txtNompro.Location = new System.Drawing.Point(148, 93);
            this.txtNompro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNompro.Name = "txtNompro";
            this.txtNompro.Size = new System.Drawing.Size(164, 27);
            this.txtNompro.TabIndex = 1;
            this.txtNompro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNompro.OnValueChanged += new System.EventHandler(this.txtNompro_TextChanged_1);
            this.txtNompro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNompro_KeyPress);
            // 
            // txtIdpro
            // 
            this.txtIdpro.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtIdpro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdpro.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtIdpro.BorderThickness = 2;
            this.txtIdpro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdpro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtIdpro.ForeColor = System.Drawing.Color.White;
            this.txtIdpro.isPassword = false;
            this.txtIdpro.Location = new System.Drawing.Point(148, 48);
            this.txtIdpro.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdpro.Name = "txtIdpro";
            this.txtIdpro.Size = new System.Drawing.Size(164, 27);
            this.txtIdpro.TabIndex = 0;
            this.txtIdpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIdpro.OnValueChanged += new System.EventHandler(this.txtIdpro_TextChanged);
            this.txtIdpro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdpro_KeyPress);
            // 
            // Mantenimiento_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 300);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtNompro);
            this.Controls.Add(this.txtIdpro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(540, 300);
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "Mantenimiento_Producto";
            this.Text = "Mantenimiento_Producto";
            this.Load += new System.EventHandler(this.Mantenimiento_Producto_Load);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton2, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton3, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtIdpro, 0);
            this.Controls.SetChildIndex(this.txtNompro, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
#pragma warning disable CS0169 // El campo 'Mantenimiento_Producto.errorProvider1' nunca se usa
        private System.Windows.Forms.ErrorProvider errorProvider1;
#pragma warning restore CS0169 // El campo 'Mantenimiento_Producto.errorProvider1' nunca se usa
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPrecio;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNompro;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtIdpro;
    }
}