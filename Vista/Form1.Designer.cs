namespace Vista
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.userControl11 = new Componente.UserControl1();
            this.userControl12 = new Componente.UserControl1();
            this.userControl13 = new Componente.UserControl1();
            this.userControl14 = new Componente.UserControl1();
            this.userControl15 = new Componente.UserControl1();
            this.userControl16 = new Componente.UserControl1();
            this.SuspendLayout();
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(12, 12);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(313, 383);
            this.userControl11.TabIndex = 0;
            this.userControl11.Load += new System.EventHandler(this.userControl11_Load);
            // 
            // userControl12
            // 
            this.userControl12.Location = new System.Drawing.Point(351, 12);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(313, 383);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.Location = new System.Drawing.Point(670, 12);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(313, 383);
            this.userControl13.TabIndex = 2;
            // 
            // userControl14
            // 
            this.userControl14.Location = new System.Drawing.Point(0, 401);
            this.userControl14.Name = "userControl14";
            this.userControl14.Size = new System.Drawing.Size(313, 383);
            this.userControl14.TabIndex = 3;
            // 
            // userControl15
            // 
            this.userControl15.Location = new System.Drawing.Point(351, 401);
            this.userControl15.Name = "userControl15";
            this.userControl15.Size = new System.Drawing.Size(313, 383);
            this.userControl15.TabIndex = 4;
            // 
            // userControl16
            // 
            this.userControl16.Location = new System.Drawing.Point(670, 401);
            this.userControl16.Name = "userControl16";
            this.userControl16.Size = new System.Drawing.Size(313, 383);
            this.userControl16.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 749);
            this.Controls.Add(this.userControl16);
            this.Controls.Add(this.userControl15);
            this.Controls.Add(this.userControl14);
            this.Controls.Add(this.userControl13);
            this.Controls.Add(this.userControl12);
            this.Controls.Add(this.userControl11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Componente.UserControl1 userControl11;
        private Componente.UserControl1 userControl12;
        private Componente.UserControl1 userControl13;
        private Componente.UserControl1 userControl14;
        private Componente.UserControl1 userControl15;
        private Componente.UserControl1 userControl16;
    }
}

