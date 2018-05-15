using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class MenuAdmi : Form
	{
		public MenuAdmi()
		{

			InitializeComponent();
			

		}
		void Button1Click(object sender, EventArgs e)
		{
			MainForm m = new MainForm();
			m.Show();
			
			
			this.Dispose();
			
		}
		void BtnUsuariosClick(object sender, EventArgs e)
		{
			//nueva dirección a usuarios directo.
			AgregarUsuarios bu = new AgregarUsuarios();
			this.Hide();
			bu.Show();
			
		}
		void BtnVnetaClick(object sender, EventArgs e)
		{
			puntoDeVenta venta =new puntoDeVenta();
			venta.Show();
			this.Hide();
			
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			//poner la dirección de busqueda de productos
		}
		void BtnProductosClick(object sender, EventArgs e)
		{
			productosAdmi produc = new productosAdmi();
			produc.Show();
			this.Hide();
		}
	}
}
