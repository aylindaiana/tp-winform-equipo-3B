namespace GestionComercio
{
    partial class FrmAltaArticulo
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblValidacionPrecio = new System.Windows.Forms.Label();
            this.lblValidacionCodigo = new System.Windows.Forms.Label();
            this.lblValidacionNombre = new System.Windows.Forms.Label();
            this.lblValidacionDescripcion = new System.Windows.Forms.Label();
            this.pbxAgregado = new System.Windows.Forms.PictureBox();
            this.btnNuevaImagen = new System.Windows.Forms.Button();
            this.cmbImagenes = new System.Windows.Forms.ComboBox();
            this.lblcomboboxImagenes = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.gbxCargaImagen = new System.Windows.Forms.GroupBox();
            this.btnModificarUrlImagen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(13, 120);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(13, 192);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(52, 16);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(12, 235);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(77, 16);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(12, 275);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(53, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 116);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(123, 192);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(121, 21);
            this.cboMarca.TabIndex = 3;
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(123, 234);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(121, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(109, 369);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 35);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(218, 369);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(87, 35);
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTitulo.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(104, 23);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(282, 25);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Agrega tu nuevo Articulo";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(13, 83);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(60, 16);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(123, 79);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(121, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(123, 275);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(121, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(13, 155);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(94, 16);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 154);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(121, 20);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblValidacionPrecio
            // 
            this.lblValidacionPrecio.AutoSize = true;
            this.lblValidacionPrecio.Location = new System.Drawing.Point(62, 275);
            this.lblValidacionPrecio.Name = "lblValidacionPrecio";
            this.lblValidacionPrecio.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionPrecio.TabIndex = 18;
            // 
            // lblValidacionCodigo
            // 
            this.lblValidacionCodigo.AutoSize = true;
            this.lblValidacionCodigo.Location = new System.Drawing.Point(76, 79);
            this.lblValidacionCodigo.Name = "lblValidacionCodigo";
            this.lblValidacionCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionCodigo.TabIndex = 19;
            // 
            // lblValidacionNombre
            // 
            this.lblValidacionNombre.AutoSize = true;
            this.lblValidacionNombre.Location = new System.Drawing.Point(76, 119);
            this.lblValidacionNombre.Name = "lblValidacionNombre";
            this.lblValidacionNombre.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionNombre.TabIndex = 20;
            // 
            // lblValidacionDescripcion
            // 
            this.lblValidacionDescripcion.AutoSize = true;
            this.lblValidacionDescripcion.Location = new System.Drawing.Point(106, 154);
            this.lblValidacionDescripcion.Name = "lblValidacionDescripcion";
            this.lblValidacionDescripcion.Size = new System.Drawing.Size(0, 13);
            this.lblValidacionDescripcion.TabIndex = 21;
            // 
            // pbxAgregado
            // 
            this.pbxAgregado.Location = new System.Drawing.Point(332, 79);
            this.pbxAgregado.Name = "pbxAgregado";
            this.pbxAgregado.Size = new System.Drawing.Size(169, 172);
            this.pbxAgregado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAgregado.TabIndex = 16;
            this.pbxAgregado.TabStop = false;
            // 
            // btnNuevaImagen
            // 
            this.btnNuevaImagen.Location = new System.Drawing.Point(351, 306);
            this.btnNuevaImagen.Name = "btnNuevaImagen";
            this.btnNuevaImagen.Size = new System.Drawing.Size(124, 30);
            this.btnNuevaImagen.TabIndex = 22;
            this.btnNuevaImagen.Text = "Agregar nueva";
            this.btnNuevaImagen.UseVisualStyleBackColor = true;
            this.btnNuevaImagen.Click += new System.EventHandler(this.btnNuevaImagen_Click);
            // 
            // cmbImagenes
            // 
            this.cmbImagenes.FormattingEnabled = true;
            this.cmbImagenes.Location = new System.Drawing.Point(123, 312);
            this.cmbImagenes.Name = "cmbImagenes";
            this.cmbImagenes.Size = new System.Drawing.Size(121, 21);
            this.cmbImagenes.TabIndex = 23;
            this.cmbImagenes.SelectedIndexChanged += new System.EventHandler(this.cmbImagenes_SelectedIndexChanged);
            // 
            // lblcomboboxImagenes
            // 
            this.lblcomboboxImagenes.AutoSize = true;
            this.lblcomboboxImagenes.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomboboxImagenes.Location = new System.Drawing.Point(13, 312);
            this.lblcomboboxImagenes.Name = "lblcomboboxImagenes";
            this.lblcomboboxImagenes.Size = new System.Drawing.Size(84, 18);
            this.lblcomboboxImagenes.TabIndex = 25;
            this.lblcomboboxImagenes.Text = "Imagenes";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(351, 275);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(124, 20);
            this.txtUrlImagen.TabIndex = 26;
            this.txtUrlImagen.TextChanged += new System.EventHandler(this.txtUrlImagen_TextChanged);
            // 
            // gbxCargaImagen
            // 
            this.gbxCargaImagen.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbxCargaImagen.Location = new System.Drawing.Point(326, 71);
            this.gbxCargaImagen.Name = "gbxCargaImagen";
            this.gbxCargaImagen.Size = new System.Drawing.Size(181, 191);
            this.gbxCargaImagen.TabIndex = 27;
            this.gbxCargaImagen.TabStop = false;
            // 
            // btnModificarUrlImagen
            // 
            this.btnModificarUrlImagen.Location = new System.Drawing.Point(351, 342);
            this.btnModificarUrlImagen.Name = "btnModificarUrlImagen";
            this.btnModificarUrlImagen.Size = new System.Drawing.Size(124, 30);
            this.btnModificarUrlImagen.TabIndex = 28;
            this.btnModificarUrlImagen.Text = "Modificar actual";
            this.btnModificarUrlImagen.UseVisualStyleBackColor = true;
            this.btnModificarUrlImagen.Click += new System.EventHandler(this.btnModificarUrlImagen_Click);
            // 
            // FrmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(519, 416);
            this.Controls.Add(this.btnModificarUrlImagen);
            this.Controls.Add(this.pbxAgregado);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblcomboboxImagenes);
            this.Controls.Add(this.cmbImagenes);
            this.Controls.Add(this.btnNuevaImagen);
            this.Controls.Add(this.lblValidacionDescripcion);
            this.Controls.Add(this.lblValidacionNombre);
            this.Controls.Add(this.lblValidacionCodigo);
            this.Controls.Add(this.lblValidacionPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.gbxCargaImagen);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAgregado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblValidacionPrecio;
        private System.Windows.Forms.Label lblValidacionCodigo;
        private System.Windows.Forms.Label lblValidacionNombre;
        private System.Windows.Forms.Label lblValidacionDescripcion;
        public System.Windows.Forms.PictureBox pbxAgregado;
        private System.Windows.Forms.Button btnNuevaImagen;
        private System.Windows.Forms.ComboBox cmbImagenes;
        private System.Windows.Forms.Label lblcomboboxImagenes;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.GroupBox gbxCargaImagen;
        private System.Windows.Forms.Button btnModificarUrlImagen;
    }
}