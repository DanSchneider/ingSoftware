/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 08/05/2018
 * Hora: 03:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class puntoDeVenta
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxTotalVenta;
		
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
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxTotalVenta = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cantidad";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(212, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Descripsión";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(473, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Precio Unitario";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(685, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Sub total";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(671, 333);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "Total  $";
			// 
			// textBoxTotalVenta
			// 
			this.textBoxTotalVenta.Location = new System.Drawing.Point(714, 330);
			this.textBoxTotalVenta.Name = "textBoxTotalVenta";
			this.textBoxTotalVenta.Size = new System.Drawing.Size(100, 20);
			this.textBoxTotalVenta.TabIndex = 5;
			// 
			// puntoDeVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 400);
			this.Controls.Add(this.textBoxTotalVenta);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "puntoDeVenta";
			this.Text = "Punto de venta";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
