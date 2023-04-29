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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFiltrar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnAgregar = new FontAwesome.Sharp.IconButton();
            this.btnModificar = new FontAwesome.Sharp.IconButton();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblArticulos = new System.Windows.Forms.Label();
            this.panelDetalleArticulo = new System.Windows.Forms.Panel();
            this.Precio = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnPapelera = new FontAwesome.Sharp.IconButton();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDetalleArticulo.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltrar.BackColor = System.Drawing.Color.OrangeRed;
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
            this.btnFiltrar.Location = new System.Drawing.Point(98, 560);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFiltrar.MaximumSize = new System.Drawing.Size(125, 43);
            this.btnFiltrar.MinimumSize = new System.Drawing.Size(125, 43);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(125, 43);
            this.btnFiltrar.TabIndex = 5;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.SystemColors.Menu;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.Location = new System.Drawing.Point(395, 370);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(38, 36);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnAgregar.Location = new System.Drawing.Point(25, 635);
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
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnModificar.IconColor = System.Drawing.SystemColors.Menu;
            this.btnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnModificar.IconSize = 30;
            this.btnModificar.Location = new System.Drawing.Point(396, 328);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(38, 36);
            this.btnModificar.TabIndex = 8;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(154, 64);
            this.pictureBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(243, 203);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 10;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.lblArticulos);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1435, 55);
            this.panel1.TabIndex = 12;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1316, 12);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.MaximumSize = new System.Drawing.Size(61, 31);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.BackColor = System.Drawing.SystemColors.Control;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Franklin Gothic Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtBuscar.Location = new System.Drawing.Point(942, 12);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.MaximumSize = new System.Drawing.Size(427, 28);
            this.txtBuscar.MinimumSize = new System.Drawing.Size(297, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(367, 37);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.Text = "  Buscar";
            this.txtBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBuscar_MouseClick);
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
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
            // panelDetalleArticulo
            // 
            this.panelDetalleArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDetalleArticulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelDetalleArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalleArticulo.Controls.Add(this.Precio);
            this.panelDetalleArticulo.Controls.Add(this.Categoria);
            this.panelDetalleArticulo.Controls.Add(this.lblCategoria);
            this.panelDetalleArticulo.Controls.Add(this.btnModificar);
            this.panelDetalleArticulo.Controls.Add(this.Marca);
            this.panelDetalleArticulo.Controls.Add(this.lblDescripcion);
            this.panelDetalleArticulo.Controls.Add(this.btnEliminar);
            this.panelDetalleArticulo.Controls.Add(this.Descripcion);
            this.panelDetalleArticulo.Controls.Add(this.Nombre);
            this.panelDetalleArticulo.Controls.Add(this.Codigo);
            this.panelDetalleArticulo.Controls.Add(this.pictureBoxArticulo);
            this.panelDetalleArticulo.Controls.Add(this.lblId);
            this.panelDetalleArticulo.Controls.Add(this.Id);
            this.panelDetalleArticulo.Location = new System.Drawing.Point(705, 77);
            this.panelDetalleArticulo.Name = "panelDetalleArticulo";
            this.panelDetalleArticulo.Size = new System.Drawing.Size(456, 486);
            this.panelDetalleArticulo.TabIndex = 13;
            this.panelDetalleArticulo.Visible = false;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Precio.Location = new System.Drawing.Point(111, 268);
            this.Precio.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.Precio.Name = "Precio";
            this.Precio.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Precio.Size = new System.Drawing.Size(0, 40);
            this.Precio.TabIndex = 16;
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Categoria.Location = new System.Drawing.Point(128, 328);
            this.Categoria.Name = "Categoria";
            this.Categoria.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Categoria.Size = new System.Drawing.Size(0, 31);
            this.Categoria.TabIndex = 15;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.SeaShell;
            this.lblCategoria.Location = new System.Drawing.Point(12, 328);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblCategoria.Size = new System.Drawing.Size(99, 31);
            this.lblCategoria.TabIndex = 14;
            this.lblCategoria.Text = "Categoria:";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Marca.ForeColor = System.Drawing.Color.OrangeRed;
            this.Marca.Location = new System.Drawing.Point(12, 46);
            this.Marca.Name = "Marca";
            this.Marca.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Marca.Size = new System.Drawing.Size(0, 31);
            this.Marca.TabIndex = 13;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.ForeColor = System.Drawing.Color.SeaShell;
            this.lblDescripcion.Location = new System.Drawing.Point(12, 375);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblDescripcion.Size = new System.Drawing.Size(116, 31);
            this.lblDescripcion.TabIndex = 12;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Descripcion.Location = new System.Drawing.Point(134, 377);
            this.Descripcion.MaximumSize = new System.Drawing.Size(250, 0);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Descripcion.Size = new System.Drawing.Size(0, 28);
            this.Descripcion.TabIndex = 11;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.BackColor = System.Drawing.Color.Transparent;
            this.Nombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.ForeColor = System.Drawing.Color.SeaShell;
            this.Nombre.Location = new System.Drawing.Point(12, 13);
            this.Nombre.Margin = new System.Windows.Forms.Padding(3, 0, 3, 4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(136, 29);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "Samsung";
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Codigo.Location = new System.Drawing.Point(319, 14);
            this.Codigo.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Codigo.Size = new System.Drawing.Size(0, 32);
            this.Codigo.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.SeaShell;
            this.lblId.Location = new System.Drawing.Point(18, 79);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(36, 25);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "ID:";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.ForeColor = System.Drawing.Color.SeaShell;
            this.Id.Location = new System.Drawing.Point(54, 81);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 22);
            this.Id.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel3.Location = new System.Drawing.Point(24, 855);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 0);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel4.Location = new System.Drawing.Point(337, 810);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(821, 0);
            this.panel4.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel5.Location = new System.Drawing.Point(1175, 580);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(0, 448);
            this.panel5.TabIndex = 15;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel7.Location = new System.Drawing.Point(24, 810);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(300, 39);
            this.panel7.TabIndex = 16;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel8.Controls.Add(this.btnFiltrar);
            this.panel8.Location = new System.Drawing.Point(1176, 77);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(236, 620);
            this.panel8.TabIndex = 17;
            // 
            // btnPapelera
            // 
            this.btnPapelera.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.btnPapelera.Location = new System.Drawing.Point(168, 635);
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
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvArticulos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticulos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CadetBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvArticulos.Location = new System.Drawing.Point(25, 77);
            this.dgvArticulos.MaximumSize = new System.Drawing.Size(1138, 580);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(1130, 540);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.RowTemplate.Height = 28;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(1130, 540);
            this.dgvArticulos.TabIndex = 19;
            this.dgvArticulos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvArticulos_CellMouseDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1438, 724);
            this.Controls.Add(this.panelDetalleArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnPapelera);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1460, 780);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.frmPrincipal_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDetalleArticulo.ResumeLayout(false);
            this.panelDetalleArticulo.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnFiltrar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private FontAwesome.Sharp.IconButton btnModificar;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblArticulos;
        private System.Windows.Forms.Panel panelDetalleArticulo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private FontAwesome.Sharp.IconButton btnPapelera;
        private System.Windows.Forms.DataGridView dgvArticulos;
    }
}

