namespace presentacion
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnPapelera = new FontAwesome.Sharp.IconButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.groupFiltarMarcaCategoria = new System.Windows.Forms.GroupBox();
            this.btnQuitarCriterios = new FontAwesome.Sharp.IconButton();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.cBxMarca = new System.Windows.Forms.ComboBox();
            this.lblMostrarCategoria = new System.Windows.Forms.Label();
            this.lblMostrarMarca = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.cBxCategoria = new System.Windows.Forms.ComboBox();
            this.panelArtInfo = new System.Windows.Forms.Panel();
            this.btnEliminarBusqueda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMarcaInfo = new System.Windows.Forms.Label();
            this.lblCategoriaInfo = new System.Windows.Forms.Label();
            this.pBxInfo = new System.Windows.Forms.PictureBox();
            this.lblPrecioInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCodigoInfo = new System.Windows.Forms.Label();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.btnVerDetalle = new FontAwesome.Sharp.IconButton();
            this.toolTipPapelera = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVerDetalles = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipModificar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipQuitarCriterios = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.groupFiltarMarcaCategoria.SuspendLayout();
            this.panelArtInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxInfo)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAgregar.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAgregar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAgregar.IconSize = 22;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(1165, 651);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnAgregar.MinimumSize = new System.Drawing.Size(125, 43);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 43);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.lblArticulos);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1752, 55);
            this.panel1.TabIndex = 12;
            // 
            // lblArticulos
            // 
            this.lblArticulos.AutoSize = true;
            this.lblArticulos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticulos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblArticulos.Location = new System.Drawing.Point(32, 11);
            this.lblArticulos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArticulos.Name = "lblArticulos";
            this.lblArticulos.Size = new System.Drawing.Size(132, 29);
            this.lblArticulos.TabIndex = 0;
            this.lblArticulos.Text = "Articulos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.Location = new System.Drawing.Point(23, 27);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.MaximumSize = new System.Drawing.Size(427, 28);
            this.txtBuscar.MinimumSize = new System.Drawing.Size(197, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(250, 37);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "  Buscar";
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnPapelera
            // 
            this.btnPapelera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPapelera.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPapelera.Enabled = false;
            this.btnPapelera.FlatAppearance.BorderSize = 0;
            this.btnPapelera.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnPapelera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapelera.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapelera.ForeColor = System.Drawing.Color.SeaShell;
            this.btnPapelera.IconChar = FontAwesome.Sharp.IconChar.Recycle;
            this.btnPapelera.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnPapelera.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPapelera.IconSize = 22;
            this.btnPapelera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPapelera.Location = new System.Drawing.Point(1298, 651);
            this.btnPapelera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPapelera.MaximumSize = new System.Drawing.Size(130, 43);
            this.btnPapelera.MinimumSize = new System.Drawing.Size(130, 43);
            this.btnPapelera.Name = "btnPapelera";
            this.btnPapelera.Size = new System.Drawing.Size(130, 43);
            this.btnPapelera.TabIndex = 18;
            this.btnPapelera.Text = "Papelera";
            this.btnPapelera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPapelera.UseVisualStyleBackColor = false;
            this.btnPapelera.Click += new System.EventHandler(this.btnPapelera_Click);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvArticulos.Location = new System.Drawing.Point(334, 75);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(1138, 580);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(960, 540);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1094, 540);
            this.dgvArticulos.TabIndex = 19;
            this.dgvArticulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticulos_CellMouseDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // groupFiltarMarcaCategoria
            // 
            this.groupFiltarMarcaCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupFiltarMarcaCategoria.Controls.Add(this.btnQuitarCriterios);
            this.groupFiltarMarcaCategoria.Controls.Add(this.btnFiltrar);
            this.groupFiltarMarcaCategoria.Controls.Add(this.cBxMarca);
            this.groupFiltarMarcaCategoria.Controls.Add(this.lblMostrarCategoria);
            this.groupFiltarMarcaCategoria.Controls.Add(this.lblMostrarMarca);
            this.groupFiltarMarcaCategoria.Controls.Add(this.lblFiltrar);
            this.groupFiltarMarcaCategoria.Controls.Add(this.cBxCategoria);
            this.groupFiltarMarcaCategoria.Location = new System.Drawing.Point(41, 75);
            this.groupFiltarMarcaCategoria.MaximumSize = new System.Drawing.Size(1000, 1100);
            this.groupFiltarMarcaCategoria.Name = "groupFiltarMarcaCategoria";
            this.groupFiltarMarcaCategoria.Size = new System.Drawing.Size(250, 258);
            this.groupFiltarMarcaCategoria.TabIndex = 20;
            this.groupFiltarMarcaCategoria.TabStop = false;
            // 
            // btnQuitarCriterios
            // 
            this.btnQuitarCriterios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuitarCriterios.BackColor = System.Drawing.Color.DarkRed;
            this.btnQuitarCriterios.FlatAppearance.BorderSize = 0;
            this.btnQuitarCriterios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnQuitarCriterios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnQuitarCriterios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitarCriterios.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarCriterios.ForeColor = System.Drawing.Color.SeaShell;
            this.btnQuitarCriterios.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnQuitarCriterios.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnQuitarCriterios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQuitarCriterios.IconSize = 30;
            this.btnQuitarCriterios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuitarCriterios.Location = new System.Drawing.Point(194, 198);
            this.btnQuitarCriterios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnQuitarCriterios.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnQuitarCriterios.MinimumSize = new System.Drawing.Size(40, 43);
            this.btnQuitarCriterios.Name = "btnQuitarCriterios";
            this.btnQuitarCriterios.Size = new System.Drawing.Size(40, 43);
            this.btnQuitarCriterios.TabIndex = 31;
            this.btnQuitarCriterios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuitarCriterios.UseVisualStyleBackColor = false;
            this.btnQuitarCriterios.Click += new System.EventHandler(this.btnQuitarCriterios_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.btnFiltrar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltrar.IconSize = 22;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFiltrar.Location = new System.Drawing.Point(24, 198);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrar.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnFiltrar.MinimumSize = new System.Drawing.Size(100, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 43);
            this.btnFiltrar.TabIndex = 25;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // cBxMarca
            // 
            this.cBxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxMarca.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxMarca.FormattingEnabled = true;
            this.cBxMarca.Location = new System.Drawing.Point(16, 76);
            this.cBxMarca.Name = "cBxMarca";
            this.cBxMarca.Size = new System.Drawing.Size(218, 34);
            this.cBxMarca.TabIndex = 29;
            // 
            // lblMostrarCategoria
            // 
            this.lblMostrarCategoria.AutoSize = true;
            this.lblMostrarCategoria.Location = new System.Drawing.Point(16, 114);
            this.lblMostrarCategoria.Name = "lblMostrarCategoria";
            this.lblMostrarCategoria.Size = new System.Drawing.Size(112, 22);
            this.lblMostrarCategoria.TabIndex = 28;
            this.lblMostrarCategoria.Text = "Categoría: ";
            // 
            // lblMostrarMarca
            // 
            this.lblMostrarMarca.AutoSize = true;
            this.lblMostrarMarca.Location = new System.Drawing.Point(16, 51);
            this.lblMostrarMarca.Name = "lblMostrarMarca";
            this.lblMostrarMarca.Size = new System.Drawing.Size(78, 22);
            this.lblMostrarMarca.TabIndex = 27;
            this.lblMostrarMarca.Text = "Marca: ";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrar.Location = new System.Drawing.Point(16, 18);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(123, 25);
            this.lblFiltrar.TabIndex = 26;
            this.lblFiltrar.Text = "Filtrar por:";
            // 
            // cBxCategoria
            // 
            this.cBxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxCategoria.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBxCategoria.FormattingEnabled = true;
            this.cBxCategoria.Location = new System.Drawing.Point(16, 139);
            this.cBxCategoria.Name = "cBxCategoria";
            this.cBxCategoria.Size = new System.Drawing.Size(218, 34);
            this.cBxCategoria.TabIndex = 30;
            // 
            // panelArtInfo
            // 
            this.panelArtInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelArtInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelArtInfo.Controls.Add(this.btnEliminarBusqueda);
            this.panelArtInfo.Controls.Add(this.txtBuscar);
            this.panelArtInfo.Location = new System.Drawing.Point(18, 361);
            this.panelArtInfo.Name = "panelArtInfo";
            this.panelArtInfo.Size = new System.Drawing.Size(296, 121);
            this.panelArtInfo.TabIndex = 0;
            // 
            // btnEliminarBusqueda
            // 
            this.btnEliminarBusqueda.BackColor = System.Drawing.Color.Teal;
            this.btnEliminarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnEliminarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarBusqueda.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBusqueda.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarBusqueda.Location = new System.Drawing.Point(173, 71);
            this.btnEliminarBusqueda.Name = "btnEliminarBusqueda";
            this.btnEliminarBusqueda.Size = new System.Drawing.Size(100, 27);
            this.btnEliminarBusqueda.TabIndex = 7;
            this.btnEliminarBusqueda.Text = "Borrar";
            this.btnEliminarBusqueda.UseVisualStyleBackColor = false;
            this.btnEliminarBusqueda.Click += new System.EventHandler(this.btnEliminarBusqueda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(19, 142);
            this.label3.MaximumSize = new System.Drawing.Size(110, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "$";
            // 
            // lblMarcaInfo
            // 
            this.lblMarcaInfo.AutoSize = true;
            this.lblMarcaInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarcaInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMarcaInfo.Location = new System.Drawing.Point(159, 103);
            this.lblMarcaInfo.MaximumSize = new System.Drawing.Size(110, 100);
            this.lblMarcaInfo.Name = "lblMarcaInfo";
            this.lblMarcaInfo.Size = new System.Drawing.Size(69, 23);
            this.lblMarcaInfo.TabIndex = 2;
            this.lblMarcaInfo.Text = "Marca";
            // 
            // lblCategoriaInfo
            // 
            this.lblCategoriaInfo.AutoSize = true;
            this.lblCategoriaInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoriaInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCategoriaInfo.Location = new System.Drawing.Point(159, 71);
            this.lblCategoriaInfo.MaximumSize = new System.Drawing.Size(125, 100);
            this.lblCategoriaInfo.Name = "lblCategoriaInfo";
            this.lblCategoriaInfo.Size = new System.Drawing.Size(98, 23);
            this.lblCategoriaInfo.TabIndex = 1;
            this.lblCategoriaInfo.Text = "Categoria";
            // 
            // pBxInfo
            // 
            this.pBxInfo.Location = new System.Drawing.Point(19, 16);
            this.pBxInfo.Name = "pBxInfo";
            this.pBxInfo.Size = new System.Drawing.Size(125, 113);
            this.pBxInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxInfo.TabIndex = 0;
            this.pBxInfo.TabStop = false;
            // 
            // lblPrecioInfo
            // 
            this.lblPrecioInfo.AutoSize = true;
            this.lblPrecioInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPrecioInfo.Location = new System.Drawing.Point(37, 142);
            this.lblPrecioInfo.MaximumSize = new System.Drawing.Size(150, 100);
            this.lblPrecioInfo.Name = "lblPrecioInfo";
            this.lblPrecioInfo.Size = new System.Drawing.Size(114, 23);
            this.lblPrecioInfo.TabIndex = 3;
            this.lblPrecioInfo.Text = "545434.45";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pBxInfo);
            this.panel2.Controls.Add(this.lblMarcaInfo);
            this.panel2.Controls.Add(this.lblCodigoInfo);
            this.panel2.Controls.Add(this.lblPrecioInfo);
            this.panel2.Controls.Add(this.lblCategoriaInfo);
            this.panel2.Location = new System.Drawing.Point(18, 503);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 177);
            this.panel2.TabIndex = 5;
            // 
            // lblCodigoInfo
            // 
            this.lblCodigoInfo.AutoSize = true;
            this.lblCodigoInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.lblCodigoInfo.Location = new System.Drawing.Point(215, 16);
            this.lblCodigoInfo.MaximumSize = new System.Drawing.Size(110, 100);
            this.lblCodigoInfo.Name = "lblCodigoInfo";
            this.lblCodigoInfo.Size = new System.Drawing.Size(78, 23);
            this.lblCodigoInfo.TabIndex = 7;
            this.lblCodigoInfo.Text = "Codigo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEliminar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEliminar.IconSize = 28;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(345, 651);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(38, 43);
            this.btnEliminar.TabIndex = 22;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.SeaShell;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnModificar.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnModificar.IconSize = 28;
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(391, 651);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(38, 43);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerDetalle.BackColor = System.Drawing.Color.OrangeRed;
            this.btnVerDetalle.FlatAppearance.BorderSize = 0;
            this.btnVerDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnVerDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerDetalle.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDetalle.ForeColor = System.Drawing.Color.SeaShell;
            this.btnVerDetalle.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnVerDetalle.IconColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerDetalle.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnVerDetalle.IconSize = 28;
            this.btnVerDetalle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVerDetalle.Location = new System.Drawing.Point(437, 651);
            this.btnVerDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVerDetalle.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(38, 43);
            this.btnVerDetalle.TabIndex = 24;
            this.btnVerDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVerDetalle.UseVisualStyleBackColor = false;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // toolTipPapelera
            // 
            this.toolTipPapelera.BackColor = System.Drawing.SystemColors.ControlLightLight;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1451, 701);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelArtInfo);
            this.Controls.Add(this.groupFiltarMarcaCategoria);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnPapelera);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1470, 678);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Articulos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.groupFiltarMarcaCategoria.ResumeLayout(false);
            this.groupFiltarMarcaCategoria.PerformLayout();
            this.panelArtInfo.ResumeLayout(false);
            this.panelArtInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBxInfo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnAgregar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblArticulos;
        private FontAwesome.Sharp.IconButton btnPapelera;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.GroupBox groupFiltarMarcaCategoria;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private System.Windows.Forms.ComboBox cBxMarca;
        private System.Windows.Forms.Label lblMostrarCategoria;
        private System.Windows.Forms.Label lblMostrarMarca;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.ComboBox cBxCategoria;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private FontAwesome.Sharp.IconButton btnVerDetalle;
        private FontAwesome.Sharp.IconButton btnQuitarCriterios;
        private System.Windows.Forms.Panel panelArtInfo;
        private System.Windows.Forms.Label lblCategoriaInfo;
        private System.Windows.Forms.PictureBox pBxInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrecioInfo;
        private System.Windows.Forms.Label lblMarcaInfo;
        private System.Windows.Forms.Label lblCodigoInfo;
        private System.Windows.Forms.Button btnEliminarBusqueda;
        private System.Windows.Forms.ToolTip toolTipPapelera;
        private System.Windows.Forms.ToolTip toolTipEliminar;
        private System.Windows.Forms.ToolTip toolTipVerDetalles;
        private System.Windows.Forms.ToolTip toolTipModificar;
        private System.Windows.Forms.ToolTip toolTipQuitarCriterios;
    }
}

