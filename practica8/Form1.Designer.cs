
namespace practica8
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
            this.bottonMensaje1 = new System.Windows.Forms.Button();
            this.bottonMensaje2 = new System.Windows.Forms.Button();
            this.textmensaje1 = new System.Windows.Forms.TextBox();
            this.textmensaje2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bottonMensaje1
            // 
            this.bottonMensaje1.Location = new System.Drawing.Point(40, 98);
            this.bottonMensaje1.Name = "bottonMensaje1";
            this.bottonMensaje1.Size = new System.Drawing.Size(166, 31);
            this.bottonMensaje1.TabIndex = 0;
            this.bottonMensaje1.Text = "Enviar mensaje 1";
            this.bottonMensaje1.UseVisualStyleBackColor = true;
            this.bottonMensaje1.Click += new System.EventHandler(this.bottonMensaje1_Click);
            // 
            // bottonMensaje2
            // 
            this.bottonMensaje2.Location = new System.Drawing.Point(324, 98);
            this.bottonMensaje2.Name = "bottonMensaje2";
            this.bottonMensaje2.Size = new System.Drawing.Size(166, 30);
            this.bottonMensaje2.TabIndex = 1;
            this.bottonMensaje2.Text = "Enviar mensaje 2";
            this.bottonMensaje2.UseVisualStyleBackColor = true;
            this.bottonMensaje2.Click += new System.EventHandler(this.bottonMensaje2_Click);
            // 
            // textmensaje1
            // 
            this.textmensaje1.Location = new System.Drawing.Point(40, 29);
            this.textmensaje1.Name = "textmensaje1";
            this.textmensaje1.Size = new System.Drawing.Size(166, 20);
            this.textmensaje1.TabIndex = 2;
            // 
            // textmensaje2
            // 
            this.textmensaje2.Location = new System.Drawing.Point(324, 29);
            this.textmensaje2.Name = "textmensaje2";
            this.textmensaje2.Size = new System.Drawing.Size(166, 20);
            this.textmensaje2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 248);
            this.Controls.Add(this.textmensaje2);
            this.Controls.Add(this.textmensaje1);
            this.Controls.Add(this.bottonMensaje2);
            this.Controls.Add(this.bottonMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bottonMensaje1;
        private System.Windows.Forms.Button bottonMensaje2;
        private System.Windows.Forms.TextBox textmensaje1;
        private System.Windows.Forms.TextBox textmensaje2;
    }
}

