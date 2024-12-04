namespace Gestion_de_articulos
{
    partial class formDetalle
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
            this.pbxProductosDetalles = new System.Windows.Forms.PictureBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductosDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxProductosDetalles
            // 
            this.pbxProductosDetalles.Location = new System.Drawing.Point(103, 12);
            this.pbxProductosDetalles.Name = "pbxProductosDetalles";
            this.pbxProductosDetalles.Size = new System.Drawing.Size(240, 227);
            this.pbxProductosDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProductosDetalles.TabIndex = 0;
            this.pbxProductosDetalles.TabStop = false;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Location = new System.Drawing.Point(152, 226);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(0, 13);
            this.lblDetalle.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(186, 305);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // formDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 340);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.pbxProductosDetalles);
            this.Name = "formDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ver Detalle";
            this.Shown += new System.EventHandler(this.formDetalle_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductosDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxProductosDetalles;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Button btnCerrar;
    }
}