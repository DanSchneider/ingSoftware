/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 12/05/2018
 * Hora: 08:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class ProductosTotales
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonVerTodo;
		private System.Windows.Forms.Button buttonRegresar;
		private System.Windows.Forms.Button buttonVerProdPorCat;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonVerTodo = new System.Windows.Forms.Button();
			this.buttonRegresar = new System.Windows.Forms.Button();
			this.buttonVerProdPorCat = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(2, 13);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(457, 355);
			this.listBox1.TabIndex = 0;
			// 
			// buttonVerTodo
			// 
			this.buttonVerTodo.Location = new System.Drawing.Point(475, 25);
			this.buttonVerTodo.Name = "buttonVerTodo";
			this.buttonVerTodo.Size = new System.Drawing.Size(88, 54);
			this.buttonVerTodo.TabIndex = 1;
			this.buttonVerTodo.Text = "Ver todos los productos";
			this.buttonVerTodo.UseVisualStyleBackColor = true;
			// 
			// buttonRegresar
			// 
			this.buttonRegresar.Location = new System.Drawing.Point(475, 314);
			this.buttonRegresar.Name = "buttonRegresar";
			this.buttonRegresar.Size = new System.Drawing.Size(88, 54);
			this.buttonRegresar.TabIndex = 2;
			this.buttonRegresar.Text = "Menú Productos";
			this.buttonRegresar.UseVisualStyleBackColor = true;
			this.buttonRegresar.Click += new System.EventHandler(this.ButtonRegresarClick);
			// 
			// buttonVerProdPorCat
			// 
			this.buttonVerProdPorCat.Location = new System.Drawing.Point(475, 98);
			this.buttonVerProdPorCat.Name = "buttonVerProdPorCat";
			this.buttonVerProdPorCat.Size = new System.Drawing.Size(88, 54);
			this.buttonVerProdPorCat.TabIndex = 3;
			this.buttonVerProdPorCat.Text = "Ver productos por Categoria";
			this.buttonVerProdPorCat.UseVisualStyleBackColor = true;
			// 
			// ProductosTotales
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 387);
			this.Controls.Add(this.buttonVerProdPorCat);
			this.Controls.Add(this.buttonRegresar);
			this.Controls.Add(this.buttonVerTodo);
			this.Controls.Add(this.listBox1);
			this.Name = "ProductosTotales";
			this.Text = "ProductosTotales";
			this.ResumeLayout(false);

		}
	}
}
