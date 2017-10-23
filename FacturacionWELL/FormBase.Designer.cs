namespace FacturacionWELL
{
    partial class FormBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.btnSalir = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMini = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnMaxi = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.ActiveBorderThickness = 1;
            this.btnSalir.ActiveCornerRadius = 30;
            this.btnSalir.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btnSalir.ActiveForecolor = System.Drawing.Color.White;
            this.btnSalir.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.IdleBorderThickness = 1;
            this.btnSalir.IdleCornerRadius = 30;
            this.btnSalir.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.IdleForecolor = System.Drawing.Color.White;
            this.btnSalir.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(89)))), ((int)(((byte)(67)))));
            this.btnSalir.Location = new System.Drawing.Point(387, 161);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 40);
            this.btnSalir.TabIndex = 57;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnMini);
            this.panel1.Controls.Add(this.btnMaxi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 36);
            this.panel1.TabIndex = 58;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(469, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(28, 28);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 64;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMini.Image = ((System.Drawing.Image)(resources.GetObject("btnMini.Image")));
            this.btnMini.ImageActive = null;
            this.btnMini.Location = new System.Drawing.Point(411, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(28, 28);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMini.TabIndex = 62;
            this.btnMini.TabStop = false;
            this.btnMini.Zoom = 10;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnMaxi
            // 
            this.btnMaxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.btnMaxi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaxi.Image = ((System.Drawing.Image)(resources.GetObject("btnMaxi.Image")));
            this.btnMaxi.ImageActive = null;
            this.btnMaxi.Location = new System.Drawing.Point(440, 3);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(28, 28);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaxi.TabIndex = 63;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Zoom = 10;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 336);
            this.panel2.TabIndex = 59;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 10);
            this.panel3.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(112)))), ((int)(((byte)(0)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(497, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 326);
            this.panel4.TabIndex = 61;
            // 
            // FormBase
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBase";
            this.Load += new System.EventHandler(this.FormBase_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormBase_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormBase_MouseUp);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.Framework.UI.BunifuThinButton2 btnSalir;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        public Bunifu.Framework.UI.BunifuImageButton btnMini;
        public Bunifu.Framework.UI.BunifuImageButton btnMaxi;
    }
}