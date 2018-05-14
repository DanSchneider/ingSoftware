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

namespace ventas
{
	/// <summary>
	/// Description of buscarUsuario.
	/// </summary>
	public partial class buscarUsuario : Form
	{
		public buscarUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
			MenuUsuario menu = new MenuUsuario();
			menu.Show();
			this.Hide();
		}
	}
}
