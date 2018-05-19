
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas.Forms
{

	public partial class Cobrar : Form
	{
		public Cobrar()
		{

			InitializeComponent();
			

		}
		puntoDeVenta pv = new puntoDeVenta();
		void button1_Click(object sender, EventArgs e)
		{


			MessageBox.Show("Venta registrada.", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			this.Dispose();
		}
	
	
	void textBox4_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
		{
			MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			e.Handled = true;
			return;
		}
	}

}
}
