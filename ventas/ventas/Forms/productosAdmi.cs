/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 01:03 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{
	/// <summary>
	/// Description of productosAdmi.
	/// </summary>
	public partial class productosAdmi : Form
	{
		public productosAdmi()
		{
		
			InitializeComponent();
			
			
		}
		void Button3Click(object sender, EventArgs e)
		{//ButtonBackMenuAdmi
			MenuAdmi back =new MenuAdmi();
			back.Show();
			this.Hide();
		}
		void buttonVerTodo_Click(object sender, EventArgs e)
		{
			Forms.AgregarProductos ap = new Forms.AgregarProductos();
			ap.Show();
			this.Hide();
		}
	}
}
