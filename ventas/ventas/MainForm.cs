using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{

	public partial class MainForm : Form
	{
		public MainForm()
		{

			InitializeComponent();
			
		}
		void BtnAceptarClick(object sender, EventArgs e)
		{
			//accción tempotal para probar conexion
			conexion.ObtenerConexion();
			MessageBox.Show("conectado!");
			
		}
		
	}
}
