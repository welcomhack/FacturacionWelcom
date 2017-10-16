namespace FacturacionWELL
{
    partial class Facturacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtCantidad = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnFacturar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPrecio = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnNuevo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtDescrip = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnProdutos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCodPro = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnClientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnEliminar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtCodiCli = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.btnColocar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button7 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAtiende = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(939, 6);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(880, 6);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(909, 6);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(862, 533);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(40, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 57;
            this.label1.Text = "Le atiende:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(40, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "Codigo:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(40, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 59;
            this.label3.Text = "Cliente:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkOrange;
            this.label4.Location = new System.Drawing.Point(45, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 60;
            this.label4.Text = "Codigo";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(174, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Descripcion";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkOrange;
            this.label6.Location = new System.Drawing.Point(345, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Precio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(470, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Cantidad";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(573, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Importe";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCodigo,
            this.ColDescrip,
            this.ColPrecio,
            this.ColCantidad,
            this.ColImporte});
            this.dataGridView1.Location = new System.Drawing.Point(44, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(745, 269);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColCodigo
            // 
            this.ColCodigo.HeaderText = "Colcod";
            this.ColCodigo.Name = "ColCodigo";
            this.ColCodigo.ReadOnly = true;
            this.ColCodigo.Width = 110;
            // 
            // ColDescrip
            // 
            this.ColDescrip.HeaderText = "ColDes";
            this.ColDescrip.Name = "ColDescrip";
            this.ColDescrip.ReadOnly = true;
            this.ColDescrip.Width = 200;
            // 
            // ColPrecio
            // 
            this.ColPrecio.HeaderText = "Colprec";
            this.ColPrecio.Name = "ColPrecio";
            this.ColPrecio.ReadOnly = true;
            // 
            // ColCantidad
            // 
            this.ColCantidad.HeaderText = "ColCantid";
            this.ColCantidad.Name = "ColCantidad";
            this.ColCantidad.ReadOnly = true;
            this.ColCantidad.Width = 140;
            // 
            // ColImporte
            // 
            this.ColImporte.HeaderText = "ColImport";
            this.ColImporte.Name = "ColImporte";
            this.ColImporte.ReadOnly = true;
            this.ColImporte.Width = 192;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FacturacionWELL.Properties.Resources.tek;
            this.pictureBox1.Location = new System.Drawing.Point(577, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(493, 533);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 19);
            this.label9.TabIndex = 74;
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.DarkGray;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(564, 523);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(225, 26);
            this.lblTotal.TabIndex = 75;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCantidad.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCantidad.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCantidad.BorderThickness = 2;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCantidad.ForeColor = System.Drawing.Color.White;
            this.txtCantidad.isPassword = false;
            this.txtCantidad.Location = new System.Drawing.Point(474, 196);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(99, 27);
            this.txtCantidad.TabIndex = 78;
            this.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCantidad.OnValueChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // btnFacturar
            // 
            this.btnFacturar.ActiveBorderThickness = 1;
            this.btnFacturar.ActiveCornerRadius = 30;
            this.btnFacturar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFacturar.ActiveForecolor = System.Drawing.Color.White;
            this.btnFacturar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnFacturar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacturar.BackgroundImage")));
            this.btnFacturar.ButtonText = "Facturar";
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnFacturar.IdleBorderThickness = 1;
            this.btnFacturar.IdleCornerRadius = 30;
            this.btnFacturar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnFacturar.IdleForecolor = System.Drawing.Color.White;
            this.btnFacturar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFacturar.Location = new System.Drawing.Point(345, 523);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(5);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(106, 38);
            this.btnFacturar.TabIndex = 77;
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
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
            this.txtPrecio.Location = new System.Drawing.Point(349, 196);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(102, 27);
            this.txtPrecio.TabIndex = 80;
            this.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecio.OnValueChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.ActiveBorderThickness = 1;
            this.btnNuevo.ActiveCornerRadius = 30;
            this.btnNuevo.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.ButtonText = "Nuevo";
            this.btnNuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleBorderThickness = 1;
            this.btnNuevo.IdleCornerRadius = 30;
            this.btnNuevo.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnNuevo.IdleForecolor = System.Drawing.Color.White;
            this.btnNuevo.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnNuevo.Location = new System.Drawing.Point(845, 440);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(106, 38);
            this.btnNuevo.TabIndex = 79;
            this.btnNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtDescrip
            // 
            this.txtDescrip.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtDescrip.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescrip.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtDescrip.BorderThickness = 2;
            this.txtDescrip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescrip.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtDescrip.ForeColor = System.Drawing.Color.White;
            this.txtDescrip.isPassword = false;
            this.txtDescrip.Location = new System.Drawing.Point(178, 196);
            this.txtDescrip.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescrip.Name = "txtDescrip";
            this.txtDescrip.Size = new System.Drawing.Size(148, 27);
            this.txtDescrip.TabIndex = 82;
            this.txtDescrip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescrip.OnValueChanged += new System.EventHandler(this.txtDescrip_TextChanged);
            // 
            // btnProdutos
            // 
            this.btnProdutos.ActiveBorderThickness = 1;
            this.btnProdutos.ActiveCornerRadius = 30;
            this.btnProdutos.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProdutos.ActiveForecolor = System.Drawing.Color.White;
            this.btnProdutos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnProdutos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProdutos.BackgroundImage")));
            this.btnProdutos.ButtonText = "Productos";
            this.btnProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProdutos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProdutos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnProdutos.IdleBorderThickness = 1;
            this.btnProdutos.IdleCornerRadius = 30;
            this.btnProdutos.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnProdutos.IdleForecolor = System.Drawing.Color.White;
            this.btnProdutos.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnProdutos.Location = new System.Drawing.Point(845, 403);
            this.btnProdutos.Margin = new System.Windows.Forms.Padding(5);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(106, 38);
            this.btnProdutos.TabIndex = 81;
            this.btnProdutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // txtCodPro
            // 
            this.txtCodPro.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCodPro.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodPro.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCodPro.BorderThickness = 2;
            this.txtCodPro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodPro.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodPro.ForeColor = System.Drawing.Color.White;
            this.txtCodPro.isPassword = false;
            this.txtCodPro.Location = new System.Drawing.Point(44, 196);
            this.txtCodPro.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodPro.Name = "txtCodPro";
            this.txtCodPro.Size = new System.Drawing.Size(104, 27);
            this.txtCodPro.TabIndex = 84;
            this.txtCodPro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodPro.OnValueChanged += new System.EventHandler(this.txtCodPro_TextChanged);
            // 
            // btnClientes
            // 
            this.btnClientes.ActiveBorderThickness = 1;
            this.btnClientes.ActiveCornerRadius = 30;
            this.btnClientes.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClientes.ActiveForecolor = System.Drawing.Color.White;
            this.btnClientes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClientes.BackgroundImage")));
            this.btnClientes.ButtonText = "Clientes";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClientes.IdleBorderThickness = 1;
            this.btnClientes.IdleCornerRadius = 30;
            this.btnClientes.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnClientes.IdleForecolor = System.Drawing.Color.White;
            this.btnClientes.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnClientes.Location = new System.Drawing.Point(845, 366);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(5);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(106, 38);
            this.btnClientes.TabIndex = 83;
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // txtCli
            // 
            this.txtCli.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCli.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCli.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCli.BorderThickness = 2;
            this.txtCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCli.ForeColor = System.Drawing.Color.White;
            this.txtCli.isPassword = false;
            this.txtCli.Location = new System.Drawing.Point(141, 154);
            this.txtCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCli.Name = "txtCli";
            this.txtCli.Size = new System.Drawing.Size(190, 27);
            this.txtCli.TabIndex = 86;
            this.txtCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCli.OnValueChanged += new System.EventHandler(this.txtCli_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ActiveBorderThickness = 1;
            this.btnEliminar.ActiveCornerRadius = 30;
            this.btnEliminar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.ActiveForecolor = System.Drawing.Color.White;
            this.btnEliminar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.ButtonText = "Eliminar";
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleBorderThickness = 1;
            this.btnEliminar.IdleCornerRadius = 30;
            this.btnEliminar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnEliminar.IdleForecolor = System.Drawing.Color.White;
            this.btnEliminar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEliminar.Location = new System.Drawing.Point(845, 329);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 38);
            this.btnEliminar.TabIndex = 85;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtCodiCli
            // 
            this.txtCodiCli.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCodiCli.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodiCli.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.txtCodiCli.BorderThickness = 2;
            this.txtCodiCli.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodiCli.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCodiCli.ForeColor = System.Drawing.Color.White;
            this.txtCodiCli.isPassword = false;
            this.txtCodiCli.Location = new System.Drawing.Point(141, 115);
            this.txtCodiCli.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodiCli.Name = "txtCodiCli";
            this.txtCodiCli.Size = new System.Drawing.Size(190, 27);
            this.txtCodiCli.TabIndex = 88;
            this.txtCodiCli.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodiCli.OnValueChanged += new System.EventHandler(this.txtCodiCli_TextChanged);
            // 
            // btnColocar
            // 
            this.btnColocar.ActiveBorderThickness = 1;
            this.btnColocar.ActiveCornerRadius = 30;
            this.btnColocar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnColocar.ActiveForecolor = System.Drawing.Color.White;
            this.btnColocar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnColocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnColocar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColocar.BackgroundImage")));
            this.btnColocar.ButtonText = "Colocar";
            this.btnColocar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColocar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColocar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnColocar.IdleBorderThickness = 1;
            this.btnColocar.IdleCornerRadius = 30;
            this.btnColocar.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.btnColocar.IdleForecolor = System.Drawing.Color.White;
            this.btnColocar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnColocar.Location = new System.Drawing.Point(843, 251);
            this.btnColocar.Margin = new System.Windows.Forms.Padding(5);
            this.btnColocar.Name = "btnColocar";
            this.btnColocar.Size = new System.Drawing.Size(108, 45);
            this.btnColocar.TabIndex = 87;
            this.btnColocar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnColocar.Click += new System.EventHandler(this.btnColocar_Click);
            // 
            // button7
            // 
            this.button7.ActiveBorderThickness = 1;
            this.button7.ActiveCornerRadius = 30;
            this.button7.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.ActiveForecolor = System.Drawing.Color.White;
            this.button7.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.ButtonText = "Buscar";
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.SeaGreen;
            this.button7.IdleBorderThickness = 1;
            this.button7.IdleCornerRadius = 30;
            this.button7.IdleFillColor = System.Drawing.Color.SeaGreen;
            this.button7.IdleForecolor = System.Drawing.Color.White;
            this.button7.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(436, 149);
            this.button7.Margin = new System.Windows.Forms.Padding(5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(106, 38);
            this.button7.TabIndex = 89;
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtAtiende
            // 
            this.txtAtiende.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAtiende.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtiende.ForeColor = System.Drawing.Color.White;
            this.txtAtiende.Location = new System.Drawing.Point(141, 72);
            this.txtAtiende.Name = "txtAtiende";
            this.txtAtiende.Size = new System.Drawing.Size(190, 25);
            this.txtAtiende.TabIndex = 90;
            this.txtAtiende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 611);
            this.Controls.Add(this.txtAtiende);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtCodiCli);
            this.Controls.Add(this.btnColocar);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCodPro);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.txtDescrip);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Facturacion";
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton2, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton3, 0);
            this.Controls.SetChildIndex(this.bunifuFlatButton1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.btnFacturar, 0);
            this.Controls.SetChildIndex(this.txtCantidad, 0);
            this.Controls.SetChildIndex(this.btnNuevo, 0);
            this.Controls.SetChildIndex(this.txtPrecio, 0);
            this.Controls.SetChildIndex(this.btnProdutos, 0);
            this.Controls.SetChildIndex(this.txtDescrip, 0);
            this.Controls.SetChildIndex(this.btnClientes, 0);
            this.Controls.SetChildIndex(this.txtCodPro, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.txtCli, 0);
            this.Controls.SetChildIndex(this.btnColocar, 0);
            this.Controls.SetChildIndex(this.txtCodiCli, 0);
            this.Controls.SetChildIndex(this.button7, 0);
            this.Controls.SetChildIndex(this.txtAtiende, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImporte;
        public Bunifu.Framework.UI.BunifuThinButton2 button7;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCodiCli;
        public Bunifu.Framework.UI.BunifuThinButton2 btnColocar;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCli;
        public Bunifu.Framework.UI.BunifuThinButton2 btnEliminar;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCodPro;
        public Bunifu.Framework.UI.BunifuThinButton2 btnClientes;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtDescrip;
        public Bunifu.Framework.UI.BunifuThinButton2 btnProdutos;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtPrecio;
        public Bunifu.Framework.UI.BunifuThinButton2 btnNuevo;
        public Bunifu.Framework.UI.BunifuMetroTextbox txtCantidad;
        public Bunifu.Framework.UI.BunifuThinButton2 btnFacturar;
        private Bunifu.Framework.UI.BunifuCustomLabel txtAtiende;
    }
}