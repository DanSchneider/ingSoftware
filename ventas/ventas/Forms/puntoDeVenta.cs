
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class puntoDeVenta : Form
	{
		public puntoDeVenta()
		{
			InitializeComponent();
			
		}
		double total =0;
		int cantidad = 0;
		Forms.BuscarProducto vb = new Forms.BuscarProducto();
		
		void ButtonBuscaProductoClick(object sender, EventArgs e)
		{
			
			
			vb.ShowDialog();
			
			if(vb.productoSeleccionado!=null){
				
				
				textBoxDescribeProducto.Text = vb.productoSeleccionado.NOMBRE;
				textBoxCantidadProduct.Text = Convert.ToString(vb.productoSeleccionado.EXISTENCIA);
				
				textBoxPrecioUnit.Text = Convert.ToString(vb.productoSeleccionado.PRECIO_V);
				
				
				
				
			}
			
		}
		void buttonAddToOrder_Click(object sender, EventArgs e)
		{
			
			
			listProductos.Items.Add(vb.productoSeleccionado.NOMBRE);
			
			cantidad=Convert.ToInt32(comboBox1.Text);
			
			total = total + (Convert.ToSingle(textBoxPrecioUnit.Text)*cantidad);
			
			
				
				
			
			textBoxTotalVenta.Text = Convert.ToString(total);
		}
		void buttonCerrarCuenta_Click(object sender, EventArgs e)
		{
			MainForm mf = new MainForm();
			this.Hide();
		}
		void buttonCobrar_Click(object sender, EventArgs e)
		{
			Productos prProductos = new Productos();
			Usuarios pUsuarios = new Usuarios();
			Clases.Ventas v = new Clases.Ventas();
			
			
			
			
			
			
		}

		
	}
}
