/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 09/05/2018
 * Hora: 01:14 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ventas
{
	partial class ventasAdmi
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button buttonIrMenu;
		
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.buttonIrMenu = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Fecha";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(130, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Productos vendidos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(396, 33);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Total";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(574, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Usuario";
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(19, 85);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(720, 303);
			this.listBox1.TabIndex = 4;
			// 
			// buttonIrMenu
			// 
			this.buttonIrMenu.Location = new System.Drawing.Point(753, 400);
			this.buttonIrMenu.Name = "buttonIrMenu";
			this.buttonIrMenu.Size = new System.Drawing.Size(75, 23);
			this.buttonIrMenu.TabIndex = 5;
			this.buttonIrMenu.Text = "Ir a Menú";
			this.buttonIrMenu.UseVisualStyleBackColor = true;
			// 
			// ventasAdmi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(840, 435);
			this.Controls.Add(this.buttonIrMenu);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "ventasAdmi";
			this.Text = "ventasAdmi";
			this.ResumeLayout(false);

		}
	}
}
