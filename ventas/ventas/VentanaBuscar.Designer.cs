/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 09/05/2018
 * Hora: 12:49 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class VentanaBuscar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TextBox textBoxDescribeProduct;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button buttonBuscaProducto;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPrecioProducto;
		private System.Windows.Forms.Button buttonAgregarAPedido;
		private System.Windows.Forms.DataGrid dataGrid1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxDescribeProduct = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.buttonBuscaProducto = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPrecioProducto = new System.Windows.Forms.TextBox();
			this.buttonAgregarAPedido = new System.Windows.Forms.Button();
			this.dataGrid1 = new System.Windows.Forms.DataGrid();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxDescribeProduct
			// 
			this.textBoxDescribeProduct.Location = new System.Drawing.Point(32, 263);
			this.textBoxDescribeProduct.Name = "textBoxDescribeProduct";
			this.textBoxDescribeProduct.Size = new System.Drawing.Size(448, 20);
			this.textBoxDescribeProduct.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(145, 237);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Descripsión";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(32, 29);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(174, 20);
			this.textBox2.TabIndex = 2;
			// 
			// buttonBuscaProducto
			// 
			this.buttonBuscaProducto.Location = new System.Drawing.Point(236, 19);
			this.buttonBuscaProducto.Name = "buttonBuscaProducto";
			this.buttonBuscaProducto.Size = new System.Drawing.Size(75, 39);
			this.buttonBuscaProducto.TabIndex = 3;
			this.buttonBuscaProducto.Text = "Buscar Producto";
			this.buttonBuscaProducto.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(486, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Precio";
			// 
			// textBoxPrecioProducto
			// 
			this.textBoxPrecioProducto.Location = new System.Drawing.Point(486, 261);
			this.textBoxPrecioProducto.Name = "textBoxPrecioProducto";
			this.textBoxPrecioProducto.Size = new System.Drawing.Size(100, 20);
			this.textBoxPrecioProducto.TabIndex = 5;
			// 
			// buttonAgregarAPedido
			// 
			this.buttonAgregarAPedido.Location = new System.Drawing.Point(606, 248);
			this.buttonAgregarAPedido.Name = "buttonAgregarAPedido";
			this.buttonAgregarAPedido.Size = new System.Drawing.Size(75, 45);
			this.buttonAgregarAPedido.TabIndex = 6;
			this.buttonAgregarAPedido.Text = "Agregar a pedido";
			this.buttonAgregarAPedido.UseVisualStyleBackColor = true;
			// 
			// dataGrid1
			// 
			this.dataGrid1.DataMember = "";
			this.dataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGrid1.Location = new System.Drawing.Point(32, 64);
			this.dataGrid1.Name = "dataGrid1";
			this.dataGrid1.Size = new System.Drawing.Size(649, 156);
			this.dataGrid1.TabIndex = 7;
			// 
			// VentanaBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(693, 305);
			this.Controls.Add(this.dataGrid1);
			this.Controls.Add(this.buttonAgregarAPedido);
			this.Controls.Add(this.textBoxPrecioProducto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.buttonBuscaProducto);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxDescribeProduct);
			this.Name = "VentanaBuscar";
			this.Text = "VentanaBuscar";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
