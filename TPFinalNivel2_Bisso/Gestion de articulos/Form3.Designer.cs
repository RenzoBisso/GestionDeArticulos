namespace Gestion_de_articulos
{
    partial class Agregar
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
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cboBoxMarca = new System.Windows.Forms.ComboBox();
            this.cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(165, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(165, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(146, 82);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(172, 177);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(151, 213);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImagen.TabIndex = 4;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(214, 10);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtBoxCodigo.TabIndex = 5;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(214, 42);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(185, 20);
            this.txtBoxNombre.TabIndex = 6;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(214, 82);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(180, 71);
            this.txtBoxDescripcion.TabIndex = 7;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(214, 177);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(180, 20);
            this.txtBoxPrecio.TabIndex = 8;
            // 
            // txtBoxUrlImagen
            // 
            this.txtBoxUrlImagen.Location = new System.Drawing.Point(214, 210);
            this.txtBoxUrlImagen.Name = "txtBoxUrlImagen";
            this.txtBoxUrlImagen.Size = new System.Drawing.Size(180, 20);
            this.txtBoxUrlImagen.TabIndex = 9;
            this.txtBoxUrlImagen.Leave += new System.EventHandler(this.txtBoxUrlImagen_Leave);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(168, 251);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 10;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(153, 279);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 11;
            this.lblCategoria.Text = "Categoria:";
            // 
            // cboBoxMarca
            // 
            this.cboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxMarca.FormattingEnabled = true;
            this.cboBoxMarca.Location = new System.Drawing.Point(214, 248);
            this.cboBoxMarca.Name = "cboBoxMarca";
            this.cboBoxMarca.Size = new System.Drawing.Size(180, 21);
            this.cboBoxMarca.TabIndex = 12;
            // 
            // cboBoxCategoria
            // 
            this.cboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategoria.FormattingEnabled = true;
            this.cboBoxCategoria.Location = new System.Drawing.Point(214, 276);
            this.cboBoxCategoria.Name = "cboBoxCategoria";
            this.cboBoxCategoria.Size = new System.Drawing.Size(180, 21);
            this.cboBoxCategoria.TabIndex = 13;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(204, 349);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(319, 349);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(434, 42);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(292, 242);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 16;
            this.pbxArticulo.TabStop = false;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cboBoxCategoria);
            this.Controls.Add(this.cboBoxMarca);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtBoxUrlImagen);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxDescripcion);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxCodigo);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Name = "Agregar";
            this.Text = "Agregar";
            this.Load += new System.EventHandler(this.Agregar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxUrlImagen;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cboBoxMarca;
        private System.Windows.Forms.ComboBox cboBoxCategoria;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.PictureBox pbxArticulo;
    }
}