using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class Menu : Form
	{
		public Menu()
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
			UsuariosAdmi au = new UsuariosAdmi();
			au.Show();
			this.Hide();
			
		}
		void BtnVnetaClick(object sender, EventArgs e)
		{
			ventasAdmi venta =new ventasAdmi();
			venta.Show();
			this.Hide();
	
		}
		void BtnBuscarClick(object sender, EventArgs e)
		{
			BuscarAdmi busca = new BuscarAdmi();
			busca.Show();
			this.Hide();
		}
		void BtnProductosClick(object sender, EventArgs e)
		{
			productosAdmi produc = new productosAdmi();
			produc.Show();
			this.Hide();
		}
	}
}
