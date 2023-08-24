namespace presentacion
{
    partial class frmDetalle
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
            this.panelDetalleArticulo = new System.Windows.Forms.Panel();
            this.Precio = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.Label();
            this.pictureBoxArticulo = new System.Windows.Forms.PictureBox();
            this.lblId = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            this.panelDetalleArticulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetalleArticulo
            // 
            this.panelDetalleArticulo.BackColor = System.Drawing.Color.Transparent;
            this.panelDetalleArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDetalleArticulo.Controls.Add(this.btnCancelar);
            this.panelDetalleArticulo.Controls.Add(this.Precio);
            this.panelDetalleArticulo.Controls.Add(this.Categoria);
            this.panelDetalleArticulo.Controls.Add(this.lblCategoria);
            this.panelDetalleArticulo.Controls.Add(this.Marca);
            this.panelDetalleArticulo.Controls.Add(this.lblDescripcion);
            this.panelDetalleArticulo.Controls.Add(this.Descripcion);
            this.panelDetalleArticulo.Controls.Add(this.Nombre);
            this.panelDetalleArticulo.Controls.Add(this.Codigo);
            this.panelDetalleArticulo.Controls.Add(this.pictureBoxArticulo);
            this.panelDetalleArticulo.Controls.Add(this.lblId);
            this.panelDetalleArticulo.Controls.Add(this.Id);
            this.panelDetalleArticulo.Location = new System.Drawing.Point(22, 21);
            this.panelDetalleArticulo.Name = "panelDetalleArticulo";
            this.panelDetalleArticulo.Size = new System.Drawing.Size(505, 540);
            this.panelDetalleArticulo.TabIndex = 14;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.BackColor = System.Drawing.Color.Transparent;
            this.Precio.Font = new System.Drawing.Font("Verdana", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Precio.Location = new System.Drawing.Point(117, 292);
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
            this.Categoria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Categoria.Location = new System.Drawing.Point(134, 361);
            this.Categoria.Name = "Categoria";
            this.Categoria.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Categoria.Size = new System.Drawing.Size(0, 31);
            this.Categoria.TabIndex = 15;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblCategoria.Location = new System.Drawing.Point(18, 361);
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
            this.lblDescripcion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblDescripcion.Location = new System.Drawing.Point(18, 408);
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
            this.Descripcion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion.Location = new System.Drawing.Point(140, 410);
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
            this.Nombre.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            this.Codigo.ForeColor = System.Drawing.Color.OrangeRed;
            this.Codigo.Location = new System.Drawing.Point(350, 15);
            this.Codigo.Margin = new System.Windows.Forms.Padding(3, 0, 8, 0);
            this.Codigo.Name = "Codigo";
            this.Codigo.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Codigo.Size = new System.Drawing.Size(0, 32);
            this.Codigo.TabIndex = 1;
            // 
            // pictureBoxArticulo
            // 
            this.pictureBoxArticulo.Location = new System.Drawing.Point(187, 63);
            this.pictureBoxArticulo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxArticulo.Name = "pictureBoxArticulo";
            this.pictureBoxArticulo.Size = new System.Drawing.Size(264, 214);
            this.pictureBoxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxArticulo.TabIndex = 10;
            this.pictureBoxArticulo.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.DarkSlateGray;
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
            this.Id.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.Id.Location = new System.Drawing.Point(54, 81);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(0, 22);
            this.Id.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Coral;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            this.btnCancelar.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 30;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(371, 480);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 41);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cerrar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(553, 584);
            this.Controls.Add(this.panelDetalleArticulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDetalle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetalle";
            this.Load += new System.EventHandler(this.frmDetalle_Load);
            this.panelDetalleArticulo.ResumeLayout(false);
            this.panelDetalleArticulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArticulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetalleArticulo;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.PictureBox pictureBoxArticulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label Id;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}