namespace Gestion_de_articulos
{
    partial class Catalogo
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
            this.gbxFiltrarPor = new System.Windows.Forms.GroupBox();
            this.cboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.txtBoxCriterio = new System.Windows.Forms.TextBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.rbtnFiltrarPorMarca = new System.Windows.Forms.RadioButton();
            this.rbtnFiltrarPorCategoria = new System.Windows.Forms.RadioButton();
            this.rbtnFiltrarPorCodigo = new System.Windows.Forms.RadioButton();
            this.rbtnFiltrarPorNombre = new System.Windows.Forms.RadioButton();
            this.gbxCatalogo = new System.Windows.Forms.GroupBox();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxProductos = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.gbxFiltrarPor.SuspendLayout();
            this.gbxCatalogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxFiltrarPor
            // 
            this.gbxFiltrarPor.Controls.Add(this.cboBoxCriterio);
            this.gbxFiltrarPor.Controls.Add(this.txtBoxCriterio);
            this.gbxFiltrarPor.Controls.Add(this.lblCriterio);
            this.gbxFiltrarPor.Controls.Add(this.rbtnFiltrarPorMarca);
            this.gbxFiltrarPor.Controls.Add(this.rbtnFiltrarPorCategoria);
            this.gbxFiltrarPor.Controls.Add(this.rbtnFiltrarPorCodigo);
            this.gbxFiltrarPor.Controls.Add(this.rbtnFiltrarPorNombre);
            this.gbxFiltrarPor.Location = new System.Drawing.Point(13, 13);
            this.gbxFiltrarPor.Name = "gbxFiltrarPor";
            this.gbxFiltrarPor.Size = new System.Drawing.Size(641, 116);
            this.gbxFiltrarPor.TabIndex = 0;
            this.gbxFiltrarPor.TabStop = false;
            this.gbxFiltrarPor.Text = "Filtrar por";
            // 
            // cboBoxCriterio
            // 
            this.cboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBoxCriterio.FormattingEnabled = true;
            this.cboBoxCriterio.Location = new System.Drawing.Point(199, 43);
            this.cboBoxCriterio.Name = "cboBoxCriterio";
            this.cboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.cboBoxCriterio.TabIndex = 6;
            // 
            // txtBoxCriterio
            // 
            this.txtBoxCriterio.Location = new System.Drawing.Point(199, 17);
            this.txtBoxCriterio.Name = "txtBoxCriterio";
            this.txtBoxCriterio.Size = new System.Drawing.Size(160, 20);
            this.txtBoxCriterio.TabIndex = 5;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(151, 20);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 4;
            this.lblCriterio.Text = "Criterio:";
            // 
            // rbtnFiltrarPorMarca
            // 
            this.rbtnFiltrarPorMarca.AutoSize = true;
            this.rbtnFiltrarPorMarca.Location = new System.Drawing.Point(7, 89);
            this.rbtnFiltrarPorMarca.Name = "rbtnFiltrarPorMarca";
            this.rbtnFiltrarPorMarca.Size = new System.Drawing.Size(55, 17);
            this.rbtnFiltrarPorMarca.TabIndex = 3;
            this.rbtnFiltrarPorMarca.TabStop = true;
            this.rbtnFiltrarPorMarca.Text = "Marca";
            this.rbtnFiltrarPorMarca.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltrarPorCategoria
            // 
            this.rbtnFiltrarPorCategoria.AutoSize = true;
            this.rbtnFiltrarPorCategoria.Location = new System.Drawing.Point(7, 66);
            this.rbtnFiltrarPorCategoria.Name = "rbtnFiltrarPorCategoria";
            this.rbtnFiltrarPorCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbtnFiltrarPorCategoria.TabIndex = 2;
            this.rbtnFiltrarPorCategoria.TabStop = true;
            this.rbtnFiltrarPorCategoria.Text = "Categoria";
            this.rbtnFiltrarPorCategoria.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltrarPorCodigo
            // 
            this.rbtnFiltrarPorCodigo.AutoSize = true;
            this.rbtnFiltrarPorCodigo.Location = new System.Drawing.Point(7, 43);
            this.rbtnFiltrarPorCodigo.Name = "rbtnFiltrarPorCodigo";
            this.rbtnFiltrarPorCodigo.Size = new System.Drawing.Size(58, 17);
            this.rbtnFiltrarPorCodigo.TabIndex = 1;
            this.rbtnFiltrarPorCodigo.TabStop = true;
            this.rbtnFiltrarPorCodigo.Text = "Codigo";
            this.rbtnFiltrarPorCodigo.UseVisualStyleBackColor = true;
            // 
            // rbtnFiltrarPorNombre
            // 
            this.rbtnFiltrarPorNombre.AutoSize = true;
            this.rbtnFiltrarPorNombre.Location = new System.Drawing.Point(7, 20);
            this.rbtnFiltrarPorNombre.Name = "rbtnFiltrarPorNombre";
            this.rbtnFiltrarPorNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtnFiltrarPorNombre.TabIndex = 0;
            this.rbtnFiltrarPorNombre.TabStop = true;
            this.rbtnFiltrarPorNombre.Text = "Nombre";
            this.rbtnFiltrarPorNombre.UseVisualStyleBackColor = true;
            // 
            // gbxCatalogo
            // 
            this.gbxCatalogo.Controls.Add(this.dgvArticulos);
            this.gbxCatalogo.Location = new System.Drawing.Point(13, 136);
            this.gbxCatalogo.Name = "gbxCatalogo";
            this.gbxCatalogo.Size = new System.Drawing.Size(641, 231);
            this.gbxCatalogo.TabIndex = 1;
            this.gbxCatalogo.TabStop = false;
            this.gbxCatalogo.Text = "Catalogo";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(7, 20);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(628, 205);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxProductos
            // 
            this.pbxProductos.Location = new System.Drawing.Point(660, 156);
            this.pbxProductos.Name = "pbxProductos";
            this.pbxProductos.Size = new System.Drawing.Size(235, 205);
            this.pbxProductos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProductos.TabIndex = 2;
            this.pbxProductos.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 374);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(101, 374);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(264, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(183, 374);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 6;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(573, 373);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 415);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxProductos);
            this.Controls.Add(this.gbxCatalogo);
            this.Controls.Add(this.gbxFiltrarPor);
            this.MaximumSize = new System.Drawing.Size(928, 454);
            this.MinimumSize = new System.Drawing.Size(928, 454);
            this.Name = "Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.gbxFiltrarPor.ResumeLayout(false);
            this.gbxFiltrarPor.PerformLayout();
            this.gbxCatalogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxFiltrarPor;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.RadioButton rbtnFiltrarPorMarca;
        private System.Windows.Forms.RadioButton rbtnFiltrarPorCategoria;
        private System.Windows.Forms.RadioButton rbtnFiltrarPorCodigo;
        private System.Windows.Forms.RadioButton rbtnFiltrarPorNombre;
        private System.Windows.Forms.TextBox txtBoxCriterio;
        private System.Windows.Forms.GroupBox gbxCatalogo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxProductos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cboBoxCriterio;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.Button btnCerrar;
    }
}

