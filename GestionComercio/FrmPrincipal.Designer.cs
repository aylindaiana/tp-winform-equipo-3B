namespace GestionComercio
{
    partial class FrmPrincipal
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFitro = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.LinkLabel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.ComboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.ComboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarMarcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCategoriaDeArticuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.Location = new System.Drawing.Point(12, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.Location = new System.Drawing.Point(12, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 60);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.Location = new System.Drawing.Point(12, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 60);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFitro
            // 
            this.txtFitro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFitro.Location = new System.Drawing.Point(112, 92);
            this.txtFitro.Name = "txtFitro";
            this.txtFitro.Size = new System.Drawing.Size(743, 20);
            this.txtFitro.TabIndex = 5;
            this.txtFitro.TextChanged += new System.EventHandler(this.txtFitro_TextChanged);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 27);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1085, 50);
            this.pnlTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.LinkColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(112, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = true;
            this.lblTitulo.Text = "Gestion de Comercio";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(112, 141);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(743, 369);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(743, 369);
            this.dgvArticulos.TabIndex = 9;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(861, 141);
            this.pbxArticulo.MinimumSize = new System.Drawing.Size(212, 197);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(212, 197);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 10;
            this.pbxArticulo.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(29, 90);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(63, 20);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Buscar:";
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonFiltrar.Location = new System.Drawing.Point(673, 534);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BotonFiltrar.TabIndex = 35;
            this.BotonFiltrar.Text = "Buscar";
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(558, 537);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 34;
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(517, 539);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 33;
            this.labelFiltro.Text = "Filtro";
            // 
            // ComboBoxCriterio
            // 
            this.ComboBoxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCriterio.FormattingEnabled = true;
            this.ComboBoxCriterio.Location = new System.Drawing.Point(374, 536);
            this.ComboBoxCriterio.Name = "ComboBoxCriterio";
            this.ComboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCriterio.TabIndex = 32;
            // 
            // labelCriterio
            // 
            this.labelCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(333, 539);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 31;
            this.labelCriterio.Text = "Criterio";
            // 
            // ComboBoxCampo
            // 
            this.ComboBoxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCampo.FormattingEnabled = true;
            this.ComboBoxCampo.Location = new System.Drawing.Point(203, 537);
            this.ComboBoxCampo.Name = "ComboBoxCampo";
            this.ComboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCampo.TabIndex = 30;
            this.ComboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCampo_SelectedIndexChanged);
            // 
            // labelCampo
            // 
            this.labelCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(150, 540);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 29;
            this.labelCampo.Text = "Campo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivo,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msArchivo
            // 
            this.msArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarMarcaToolStripMenuItem,
            this.agregarCategoriaDeArticuloToolStripMenuItem});
            this.msArchivo.Name = "msArchivo";
            this.msArchivo.Size = new System.Drawing.Size(60, 20);
            this.msArchivo.Text = "Archivo";
            // 
            // agregarMarcaToolStripMenuItem
            // 
            this.agregarMarcaToolStripMenuItem.Name = "agregarMarcaToolStripMenuItem";
            this.agregarMarcaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarMarcaToolStripMenuItem.Text = "Agregar marca de articulo";
            // 
            // agregarCategoriaDeArticuloToolStripMenuItem
            // 
            this.agregarCategoriaDeArticuloToolStripMenuItem.Name = "agregarCategoriaDeArticuloToolStripMenuItem";
            this.agregarCategoriaDeArticuloToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.agregarCategoriaDeArticuloToolStripMenuItem.Text = "Agregar categoria de articulo";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.aboutToolStripMenuItem.Text = "about";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1085, 581);
            this.Controls.Add(this.BotonFiltrar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.ComboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.ComboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtFitro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(1101, 620);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFitro;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.LinkLabel lblTitulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button BotonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.ComboBox ComboBoxCriterio;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox ComboBoxCampo;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msArchivo;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarMarcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaDeArticuloToolStripMenuItem;
    }
}

