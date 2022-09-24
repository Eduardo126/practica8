
namespace ejercicio_1
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
            this.labelMensaje1 = new System.Windows.Forms.Label();
            this.bottonDatos = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.bottonRegistro = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMensaje1
            // 
            this.labelMensaje1.AutoSize = true;
            this.labelMensaje1.Location = new System.Drawing.Point(52, 36);
            this.labelMensaje1.Name = "labelMensaje1";
            this.labelMensaje1.Size = new System.Drawing.Size(16, 13);
            this.labelMensaje1.TabIndex = 1;
            this.labelMensaje1.Text = "Id";
            // 
            // bottonDatos
            // 
            this.bottonDatos.Location = new System.Drawing.Point(264, 227);
            this.bottonDatos.Name = "bottonDatos";
            this.bottonDatos.Size = new System.Drawing.Size(106, 31);
            this.bottonDatos.TabIndex = 2;
            this.bottonDatos.Text = "Enviar Datos";
            this.bottonDatos.UseVisualStyleBackColor = true;
            this.bottonDatos.Click += new System.EventHandler(this.bottonDatos_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(133, 36);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(237, 20);
            this.textId.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Apellido";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(133, 100);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(237, 20);
            this.textNombre.TabIndex = 7;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(133, 157);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(237, 20);
            this.textApellido.TabIndex = 8;
            // 
            // bottonRegistro
            // 
            this.bottonRegistro.Location = new System.Drawing.Point(99, 227);
            this.bottonRegistro.Name = "bottonRegistro";
            this.bottonRegistro.Size = new System.Drawing.Size(108, 31);
            this.bottonRegistro.TabIndex = 9;
            this.bottonRegistro.Text = "Agregar Registro";
            this.bottonRegistro.UseVisualStyleBackColor = true;
            this.bottonRegistro.Click += new System.EventHandler(this.bottonRegistro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 286);
            this.Controls.Add(this.bottonRegistro);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.bottonDatos);
            this.Controls.Add(this.labelMensaje1);
            this.Name = "Form1";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje1;
        private System.Windows.Forms.Button bottonDatos;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button bottonRegistro;
    }
}

