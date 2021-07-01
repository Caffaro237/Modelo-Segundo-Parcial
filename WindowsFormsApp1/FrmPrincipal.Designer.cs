
namespace WindowsFormsApp1
{
    partial class FrmPrincipal
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
            this.btnLanzar = new System.Windows.Forms.Button();
            this.btnBitacora = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(12, 12);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(385, 133);
            this.btnLanzar.TabIndex = 0;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
            // 
            // btnBitacora
            // 
            this.btnBitacora.Location = new System.Drawing.Point(12, 151);
            this.btnBitacora.Name = "btnBitacora";
            this.btnBitacora.Size = new System.Drawing.Size(385, 75);
            this.btnBitacora.TabIndex = 1;
            this.btnBitacora.Text = "Bitacora";
            this.btnBitacora.UseVisualStyleBackColor = true;
            this.btnBitacora.Click += new System.EventHandler(this.btnBitacora_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 238);
            this.Controls.Add(this.btnBitacora);
            this.Controls.Add(this.btnLanzar);
            this.Name = "FrmPrincipal";
            this.Text = "Segundo Parcial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Button btnBitacora;
    }
}

