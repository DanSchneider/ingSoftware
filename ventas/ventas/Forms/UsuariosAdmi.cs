/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 10/05/2018
 * Hora: 01:06 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{
	/// <summary>
	/// Description of UsuariosAdmi.
	/// </summary>
	public partial class UsuariosAdmi : Form
	{
		public UsuariosAdmi()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button6Click(object sender, EventArgs e)
		{
			MenuAdmi back = new MenuAdmi();
			back.Show();
			this.Hide();
		}
		void ButtonAddUsersClick(object sender, EventArgs e)
		{
			AgregarUsuarios add = new AgregarUsuarios();
			add.Show();
			this.Hide();
		}
		void ButtonShowUsrAdmiClick(object sender, EventArgs e)
		{
			VistaUsuariosAdmi vista = new VistaUsuariosAdmi();
			vista.Show();
		
		}
		void ButtonShowUsersClick(object sender, EventArgs e)
		{
			VistaUsuarios vista2 = new VistaUsuarios();
			vista2.Show();
		}
		void ButtonDeleteUserClick(object sender, EventArgs e)
		{
			BorrarUsuario delete = new BorrarUsuario();
			delete.Show();
		}
		void ButtonModificaUserClick(object sender, EventArgs e)
		{
			ModificarUsuario modf = new ModificarUsuario();
			modf.Show();
			
		}
	}
}
