
namespace ejercicio_1
{
    partial class Form2
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
            this.textId = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.bottonAgregar = new System.Windows.Forms.Button();
            this.bottonCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(165, 56);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(237, 20);
            this.textId.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(165, 124);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(237, 20);
            this.textNombre.TabIndex = 6;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(165, 203);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(237, 20);
            this.textApellido.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre";
            // 
            // Datos
            // 
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(83, 270);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(439, 150);
            this.Datos.TabIndex = 11;
            this.Datos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellContentClick);
            // 
            // bottonAgregar
            // 
            this.bottonAgregar.Location = new System.Drawing.Point(140, 442);
            this.bottonAgregar.Name = "bottonAgregar";
            this.bottonAgregar.Size = new System.Drawing.Size(108, 31);
            this.bottonAgregar.TabIndex = 12;
            this.bottonAgregar.Text = "Cargar datos";
            this.bottonAgregar.UseVisualStyleBackColor = true;
            this.bottonAgregar.Click += new System.EventHandler(this.bottonAgregar_Click);
            // 
            // bottonCerrar
            // 
            this.bottonCerrar.Location = new System.Drawing.Point(327, 442);
            this.bottonCerrar.Name = "bottonCerrar";
            this.bottonCerrar.Size = new System.Drawing.Size(108, 31);
            this.bottonCerrar.TabIndex = 13;
            this.bottonCerrar.Text = "Cerrar";
            this.bottonCerrar.UseVisualStyleBackColor = true;
            this.bottonCerrar.Click += new System.EventHandler(this.bottonCerrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 501);
            this.Controls.Add(this.bottonCerrar);
            this.Controls.Add(this.bottonAgregar);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Button bottonAgregar;
        private System.Windows.Forms.Button bottonCerrar;
    }
}