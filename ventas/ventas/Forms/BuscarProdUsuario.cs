/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 08:30 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ventas
{
	/// <summary>
	/// Description of buscarUsuario.
	/// </summary>
	public partial class buscarProductoUserMod : Form
	{
		public buscarProductoUserMod()
		{
			
			InitializeComponent();
		
		}
		void ButtonSeleccionarClick(object sender, EventArgs e)
		{
			
			puntoDeVenta venta = new puntoDeVenta();
			venta.Show();
			this.Hide();
			
		}
		void ButtonBuscaClick(object sender, EventArgs e)
		{  
			MySqlCommand busca = new MySqlCommand();
			busca.Connection = conexion.ObtenerConexion();
			busca.CommandText=("select* from productos where nombre= '")+
				textBoxBusqueda.Text;
			MySqlDataReader leerbusq = busca.ExecuteReader();
			if (leerbusq.Read()){
							
			
			}
			else {
			
				MessageBox.Show("Producto no encontrado, intente de nuevo!");
				textBoxBusqueda.Clear();
			}
		}
		
	}
}
