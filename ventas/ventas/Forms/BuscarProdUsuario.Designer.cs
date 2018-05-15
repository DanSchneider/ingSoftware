/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 08:30 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class buscarProductoUserMod
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxProducto;
		private System.Windows.Forms.TextBox textBoxCantidadDisponible;
		private System.Windows.Forms.TextBox textBoxBusqueda;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonBusca;
		private System.Windows.Forms.Button buttonSeleccionar;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxProducto = new System.Windows.Forms.TextBox();
			this.textBoxCantidadDisponible = new System.Windows.Forms.TextBox();
			this.textBoxBusqueda = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonBusca = new System.Windows.Forms.Button();
			this.buttonSeleccionar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(405, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cantidad disponible";
			// 
			// textBoxProducto
			// 
			this.textBoxProducto.Location = new System.Drawing.Point(12, 112);
			this.textBoxProducto.Name = "textBoxProducto";
			this.textBoxProducto.Size = new System.Drawing.Size(385, 20);
			this.textBoxProducto.TabIndex = 2;
			// 
			// textBoxCantidadDisponible
			// 
			this.textBoxCantidadDisponible.Location = new System.Drawing.Point(405, 112);
			this.textBoxCantidadDisponible.Name = "textBoxCantidadDisponible";
			this.textBoxCantidadDisponible.Size = new System.Drawing.Size(100, 20);
			this.textBoxCantidadDisponible.TabIndex = 3;
			// 
			// textBoxBusqueda
			// 
			this.textBoxBusqueda.Location = new System.Drawing.Point(12, 35);
			this.textBoxBusqueda.Name = "textBoxBusqueda";
			this.textBoxBusqueda.Size = new System.Drawing.Size(317, 20);
			this.textBoxBusqueda.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 5;
			this.label3.Text = "Buscar Producto";
			// 
			// buttonBusca
			// 
			this.buttonBusca.Location = new System.Drawing.Point(361, 32);
			this.buttonBusca.Name = "buttonBusca";
			this.buttonBusca.Size = new System.Drawing.Size(75, 23);
			this.buttonBusca.TabIndex = 6;
			this.buttonBusca.Text = "Buscar";
			this.buttonBusca.UseVisualStyleBackColor = true;
			this.buttonBusca.Click += new System.EventHandler(this.ButtonBuscaClick);
			// 
			// buttonSeleccionar
			// 
			this.buttonSeleccionar.Location = new System.Drawing.Point(528, 86);
			this.buttonSeleccionar.Name = "buttonSeleccionar";
			this.buttonSeleccionar.Size = new System.Drawing.Size(75, 46);
			this.buttonSeleccionar.TabIndex = 8;
			this.buttonSeleccionar.Text = "Seleccionar";
			this.buttonSeleccionar.UseVisualStyleBackColor = true;
			this.buttonSeleccionar.Click += new System.EventHandler(this.ButtonSeleccionarClick);
			// 
			// buscarProductoUserMod
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 171);
			this.Controls.Add(this.buttonSeleccionar);
			this.Controls.Add(this.buttonBusca);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxBusqueda);
			this.Controls.Add(this.textBoxCantidadDisponible);
			this.Controls.Add(this.textBoxProducto);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "buscarProductoUserMod";
			this.Text = "Buscar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
