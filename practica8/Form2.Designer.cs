
namespace practica8
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
            this.labelMensaje1 = new System.Windows.Forms.Label();
            this.labelMensaje2 = new System.Windows.Forms.Label();
            this.bottonMensaje3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMensaje1
            // 
            this.labelMensaje1.AutoSize = true;
            this.labelMensaje1.Location = new System.Drawing.Point(58, 69);
            this.labelMensaje1.Name = "labelMensaje1";
            this.labelMensaje1.Size = new System.Drawing.Size(35, 13);
            this.labelMensaje1.TabIndex = 0;
            this.labelMensaje1.Text = "label1";
            this.labelMensaje1.Click += new System.EventHandler(this.labelMensaje1_Click);
            // 
            // labelMensaje2
            // 
            this.labelMensaje2.AutoSize = true;
            this.labelMensaje2.Location = new System.Drawing.Point(269, 69);
            this.labelMensaje2.Name = "labelMensaje2";
            this.labelMensaje2.Size = new System.Drawing.Size(35, 13);
            this.labelMensaje2.TabIndex = 1;
            this.labelMensaje2.Text = "label2";
            // 
            // bottonMensaje3
            // 
            this.bottonMensaje3.Location = new System.Drawing.Point(103, 130);
            this.bottonMensaje3.Name = "bottonMensaje3";
            this.bottonMensaje3.Size = new System.Drawing.Size(166, 31);
            this.bottonMensaje3.TabIndex = 2;
            this.bottonMensaje3.Text = "Cerrar mensaje";
            this.bottonMensaje3.UseVisualStyleBackColor = true;
            this.bottonMensaje3.Click += new System.EventHandler(this.bottonMensaje3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 239);
            this.Controls.Add(this.bottonMensaje3);
            this.Controls.Add(this.labelMensaje2);
            this.Controls.Add(this.labelMensaje1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMensaje1;
        private System.Windows.Forms.Label labelMensaje2;
        private System.Windows.Forms.Button bottonMensaje3;
    }
}