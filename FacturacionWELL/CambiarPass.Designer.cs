namespace FacturacionWELL
{
    partial class CambiarPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarPass));
            this.txtRepPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNewPass = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsu = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtIdUsu = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(402, 193);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(503, 3);
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMini
            // 
            this.btnMini.Location = new System.Drawing.Point(445, 3);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Location = new System.Drawing.Point(474, 3);
            // 
            // txtRepPass
            // 
            this.txtRepPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtRepPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRepPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtRepPass.BorderThickness = 2;
            this.txtRepPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRepPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRepPass.ForeColor = System.Drawing.Color.White;
            this.txtRepPass.isPassword = false;
            this.txtRepPass.Location = new System.Drawing.Point(184, 165);
            this.txtRepPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepPass.Name = "txtRepPass";
            this.txtRepPass.Size = new System.Drawing.Size(164, 27);
            this.txtRepPass.TabIndex = 79;
            this.txtRepPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRepPass.OnValueChanged += new System.EventHandler(this.txtRepPass_OnValueChanged);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtNewPass.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtNewPass.BorderThickness = 2;
            this.txtNewPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNewPass.ForeColor = System.Drawing.Color.White;
            this.txtNewPass.isPassword = false;
            this.txtNewPass.Location = new System.Drawing.Point(184, 130);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(164, 27);
            this.txtNewPass.TabIndex = 78;
            this.txtNewPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPass.OnValueChanged += new System.EventHandler(this.txtNewPass_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(115, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 83;
            this.label2.Text = "Repetir:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 82;
            this.label1.Text = "Nueva Contraseña:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ActiveBorderThickness = 1;
            this.btnGuardar.ActiveCornerRadius = 30;
            this.btnGuardar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
            this.btnGuardar.ButtonText = "Volver";
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleBorderThickness = 1;
            this.btnGuardar.IdleCornerRadius = 30;
            this.btnGuardar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardar.IdleForecolor = System.Drawing.Color.White;
            this.btnGuardar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(386, 121);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 38);
            this.btnGuardar.TabIndex = 81;
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ActiveBorderThickness = 1;
            this.btnConsultar.ActiveCornerRadius = 30;
            this.btnConsultar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.ButtonText = "Guardar";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleBorderThickness = 1;
            this.btnConsultar.IdleCornerRadius = 30;
            this.btnConsultar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleForecolor = System.Drawing.Color.White;
            this.btnConsultar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnConsultar.Location = new System.Drawing.Point(386, 74);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 38);
            this.btnConsultar.TabIndex = 80;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(89, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "ID_Usuario:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(112, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 87;
            this.label4.Text = "Usuario:";
            // 
            // txtUsu
            // 
            this.txtUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsu.ForeColor = System.Drawing.Color.White;
            this.txtUsu.Location = new System.Drawing.Point(184, 93);
            this.txtUsu.Name = "txtUsu";
            this.txtUsu.Size = new System.Drawing.Size(164, 25);
            this.txtUsu.TabIndex = 89;
            this.txtUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIdUsu
            // 
            this.txtIdUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtIdUsu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUsu.ForeColor = System.Drawing.Color.White;
            this.txtIdUsu.Location = new System.Drawing.Point(184, 58);
            this.txtIdUsu.Name = "txtIdUsu";
            this.txtIdUsu.Size = new System.Drawing.Size(164, 25);
            this.txtIdUsu.TabIndex = 88;
            this.txtIdUsu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CambiarPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 247);
            this.Controls.Add(this.txtUsu);
            this.Controls.Add(this.txtIdUsu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRepPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnConsultar);
            this.MaximumSize = new System.Drawing.Size(541, 247);
            this.MinimumSize = new System.Drawing.Size(541, 247);
            this.Name = "CambiarPass";
            this.Text = "CambiarPass";
            this.Load += new System.EventHandler(this.CambiarPass_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnConsultar, 0);
            this.Controls.SetChildIndex(this.btnGuardar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNewPass, 0);
            this.Controls.SetChildIndex(this.txtRepPass, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtIdUsu, 0);
            this.Controls.SetChildIndex(this.txtUsu, 0);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMetroTextbox txtRepPass;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNewPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Bunifu.Framework.UI.BunifuThinButton2 btnGuardar;
        public Bunifu.Framework.UI.BunifuThinButton2 btnConsultar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuCustomLabel txtUsu;
        private Bunifu.Framework.UI.BunifuCustomLabel txtIdUsu;
    }
}