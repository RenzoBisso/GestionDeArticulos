namespace Gestion_de_articulos
{
    partial class Modificar
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
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.cboBoxMarca = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxUrlImagen = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxDescripcion = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.txtBoxCodigo = new System.Windows.Forms.TextBox();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblIdValor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(417, 63);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(292, 242);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 33;
            this.pbxArticulo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(302, 370);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(187, 370);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 31;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboBoxCategoria
            // 
            this.cboBoxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCategoria.FormattingEnabled = true;
            this.cboBoxCategoria.Location = new System.Drawing.Point(197, 297);
            this.cboBoxCategoria.Name = "cboBoxCategoria";
            this.cboBoxCategoria.Size = new System.Drawing.Size(180, 21);
            this.cboBoxCategoria.TabIndex = 30;
            // 
            // cboBoxMarca
            // 
            this.cboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxMarca.FormattingEnabled = true;
            this.cboBoxMarca.Location = new System.Drawing.Point(197, 269);
            this.cboBoxMarca.Name = "cboBoxMarca";
            this.cboBoxMarca.Size = new System.Drawing.Size(180, 21);
            this.cboBoxMarca.TabIndex = 29;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(136, 300);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(55, 13);
            this.lblCategoria.TabIndex = 28;
            this.lblCategoria.Text = "Categoria:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(151, 272);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 27;
            this.lblMarca.Text = "Marca:";
            // 
            // txtBoxUrlImagen
            // 
            this.txtBoxUrlImagen.Location = new System.Drawing.Point(197, 231);
            this.txtBoxUrlImagen.Name = "txtBoxUrlImagen";
            this.txtBoxUrlImagen.Size = new System.Drawing.Size(180, 20);
            this.txtBoxUrlImagen.TabIndex = 26;
            this.txtBoxUrlImagen.Leave += new System.EventHandler(this.txtBoxUrlImagen_Leave);
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(197, 198);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(180, 20);
            this.txtBoxPrecio.TabIndex = 25;
            // 
            // txtBoxDescripcion
            // 
            this.txtBoxDescripcion.Location = new System.Drawing.Point(197, 103);
            this.txtBoxDescripcion.Multiline = true;
            this.txtBoxDescripcion.Name = "txtBoxDescripcion";
            this.txtBoxDescripcion.Size = new System.Drawing.Size(180, 71);
            this.txtBoxDescripcion.TabIndex = 24;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(197, 63);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(185, 20);
            this.txtBoxNombre.TabIndex = 23;
            // 
            // txtBoxCodigo
            // 
            this.txtBoxCodigo.Location = new System.Drawing.Point(197, 31);
            this.txtBoxCodigo.Name = "txtBoxCodigo";
            this.txtBoxCodigo.Size = new System.Drawing.Size(185, 20);
            this.txtBoxCodigo.TabIndex = 22;
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(134, 234);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImagen.TabIndex = 21;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(155, 198);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 20;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(129, 103);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(66, 13);
            this.lblDescripcion.TabIndex = 19;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(148, 66);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 18;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(148, 34);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Codigo:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(155, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 13);
            this.lblId.TabIndex = 34;
            this.lblId.Text = "Id:";
            // 
            // lblIdValor
            // 
            this.lblIdValor.AutoSize = true;
            this.lblIdValor.Location = new System.Drawing.Point(197, 13);
            this.lblIdValor.Name = "lblIdValor";
            this.lblIdValor.Size = new System.Drawing.Size(0, 13);
            this.lblIdValor.TabIndex = 35;
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIdValor);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
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
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboBoxCategoria;
        private System.Windows.Forms.ComboBox cboBoxMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxUrlImagen;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxDescripcion;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.TextBox txtBoxCodigo;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblIdValor;
    }
}