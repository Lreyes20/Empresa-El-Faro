
namespace AppInicio.Forms
{
    partial class FrmArticulo
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
            this.Producto = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.DescricionArticulo = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.Cantidad = new System.Windows.Forms.Label();
            this.textID = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Producto
            // 
            this.Producto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Producto.AutoSize = true;
            this.Producto.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Producto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Producto.Location = new System.Drawing.Point(271, 8);
            this.Producto.Name = "Producto";
            this.Producto.Size = new System.Drawing.Size(107, 28);
            this.Producto.TabIndex = 0;
            this.Producto.Text = "Producto";
            // 
            // ID
            // 
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ID.Location = new System.Drawing.Point(123, 55);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(150, 25);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID del Artículo:";
            // 
            // DescricionArticulo
            // 
            this.DescricionArticulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescricionArticulo.AutoSize = true;
            this.DescricionArticulo.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescricionArticulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DescricionArticulo.Location = new System.Drawing.Point(148, 88);
            this.DescricionArticulo.Name = "DescricionArticulo";
            this.DescricionArticulo.Size = new System.Drawing.Size(125, 25);
            this.DescricionArticulo.TabIndex = 2;
            this.DescricionArticulo.Text = "Descripción:";
            // 
            // Precio
            // 
            this.Precio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Precio.Location = new System.Drawing.Point(198, 118);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(75, 25);
            this.Precio.TabIndex = 3;
            this.Precio.Text = "Precio:";
            // 
            // Cantidad
            // 
            this.Cantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cantidad.Location = new System.Drawing.Point(71, 152);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(202, 25);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.Text = "Cantidad Disponible:";
            // 
            // textID
            // 
            this.textID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textID.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.Location = new System.Drawing.Point(273, 55);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(154, 26);
            this.textID.TabIndex = 5;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textDescripcion.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textDescripcion.Location = new System.Drawing.Point(273, 87);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(154, 26);
            this.textDescripcion.TabIndex = 6;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrecio.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecio.Location = new System.Drawing.Point(273, 119);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(154, 26);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCantidad.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(273, 151);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(154, 26);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(115)))), ((int)(((byte)(232)))));
            this.btnIngresar.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(273, 183);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(102, 34);
            this.btnIngresar.TabIndex = 10;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 522);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.DescricionArticulo);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Producto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticulo";
            this.Text = "FrmArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Producto;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label DescricionArticulo;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnIngresar;
    }
}