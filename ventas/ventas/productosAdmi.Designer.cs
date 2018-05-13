/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 01:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class productosAdmi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button buttonVerTodo;
		private System.Windows.Forms.Button buttonSurtir;
		private System.Windows.Forms.Button button3;
		
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
			this.buttonVerTodo = new System.Windows.Forms.Button();
			this.buttonSurtir = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonVerTodo
			// 
			this.buttonVerTodo.Location = new System.Drawing.Point(12, 28);
			this.buttonVerTodo.Name = "buttonVerTodo";
			this.buttonVerTodo.Size = new System.Drawing.Size(93, 49);
			this.buttonVerTodo.TabIndex = 0;
			this.buttonVerTodo.Text = "Ver todos los productos";
			this.buttonVerTodo.UseVisualStyleBackColor = true;
			// 
			// buttonSurtir
			// 
			this.buttonSurtir.Location = new System.Drawing.Point(12, 99);
			this.buttonSurtir.Name = "buttonSurtir";
			this.buttonSurtir.Size = new System.Drawing.Size(93, 49);
			this.buttonSurtir.TabIndex = 1;
			this.buttonSurtir.Text = "Surtir";
			this.buttonSurtir.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(189, 99);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(85, 49);
			this.button3.TabIndex = 2;
			this.button3.Text = "Menú Administrador";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// productosAdmi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(295, 178);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.buttonSurtir);
			this.Controls.Add(this.buttonVerTodo);
			this.Name = "productosAdmi";
			this.Text = "Productos";
			this.ResumeLayout(false);

		}
	}
}
