namespace FacturacionWELL
{
    partial class ConsultaUsuario
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
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // ConsultaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 466);
            this.Name = "ConsultaUsuario";
            this.Text = "ConsultaUsuario";
            this.Load += new System.EventHandler(this.ConsultaUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}