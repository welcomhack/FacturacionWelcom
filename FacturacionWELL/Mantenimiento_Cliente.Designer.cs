﻿namespace FacturacionWELL
{
    partial class Mantenimiento_Cliente
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApecli = new System.Windows.Forms.TextBox();
            this.txtNomcli = new System.Windows.Forms.TextBox();
            this.txtIdcli = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(431, 219);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label3.Location = new System.Drawing.Point(27, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 66;
            this.label3.Text = "Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 65;
            this.label2.Text = "Nom_Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 64;
            this.label1.Text = "ID_Cliente:";
            // 
            // txtApecli
            // 
            this.txtApecli.Location = new System.Drawing.Point(187, 129);
            this.txtApecli.Name = "txtApecli";
            this.txtApecli.Size = new System.Drawing.Size(156, 20);
            this.txtApecli.TabIndex = 63;
            this.txtApecli.TextChanged += new System.EventHandler(this.txtApecli_TextChanged);
            this.txtApecli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApecli_KeyPress);
            // 
            // txtNomcli
            // 
            this.txtNomcli.Location = new System.Drawing.Point(187, 93);
            this.txtNomcli.Name = "txtNomcli";
            this.txtNomcli.Size = new System.Drawing.Size(156, 20);
            this.txtNomcli.TabIndex = 62;
            this.txtNomcli.TextChanged += new System.EventHandler(this.txtNomcli_TextChanged);
            this.txtNomcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomcli_KeyPress);
            // 
            // txtIdcli
            // 
            this.txtIdcli.Location = new System.Drawing.Point(187, 57);
            this.txtIdcli.Name = "txtIdcli";
            this.txtIdcli.Size = new System.Drawing.Size(156, 20);
            this.txtIdcli.TabIndex = 61;
            this.txtIdcli.TextChanged += new System.EventHandler(this.txtIdcli_TextChanged);
            this.txtIdcli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdcli_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Mantenimiento_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApecli);
            this.Controls.Add(this.txtNomcli);
            this.Controls.Add(this.txtIdcli);
            this.MaximumSize = new System.Drawing.Size(540, 300);
            this.MinimumSize = new System.Drawing.Size(540, 300);
            this.Name = "Mantenimiento_Cliente";
            this.Text = "Mantenimiento_Cliente";
            this.Load += new System.EventHandler(this.Mantenimiento_Cliente_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.txtIdcli, 0);
            this.Controls.SetChildIndex(this.txtNomcli, 0);
            this.Controls.SetChildIndex(this.txtApecli, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApecli;
        private System.Windows.Forms.TextBox txtNomcli;
        private System.Windows.Forms.TextBox txtIdcli;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}