/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 09/05/2018
 * Hora: 11:48 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class BuscarAdmi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonRegresar;
		
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonRegresar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 87);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(318, 90);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Cantidad Disponible";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 113);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(283, 20);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(318, 113);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 3;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(261, 27);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(168, 20);
			this.textBox3.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(449, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// buttonRegresar
			// 
			this.buttonRegresar.Location = new System.Drawing.Point(449, 163);
			this.buttonRegresar.Name = "buttonRegresar";
			this.buttonRegresar.Size = new System.Drawing.Size(75, 23);
			this.buttonRegresar.TabIndex = 6;
			this.buttonRegresar.Text = "Ir a Menú";
			this.buttonRegresar.UseVisualStyleBackColor = true;
			this.buttonRegresar.Click += new System.EventHandler(this.ButtonRegresarClick);
			// 
			// BuscarAdmi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 198);
			this.Controls.Add(this.buttonRegresar);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "BuscarAdmi";
			this.Text = "Buscar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
