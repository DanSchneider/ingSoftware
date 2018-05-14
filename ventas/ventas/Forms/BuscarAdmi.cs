/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 09/05/2018
 * Hora: 11:48 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class BuscarAdmi : Form
	{
		public BuscarAdmi()
		{
			InitializeComponent();
		}
		void ButtonRegresarClick(object sender, EventArgs e)
		{
			MenuAdmi back2 = new MenuAdmi();
			back2.Show();
			this.Hide();
			
			
		}
	}
}
