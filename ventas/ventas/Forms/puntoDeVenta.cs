﻿/*
 * Creado por SharpDevelop.
 * Usuario: jldg0
 * Fecha: 08/05/2018
 * Hora: 03:46 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{
	/// <summary>
	/// Description of puntoDeVenta.
	/// </summary>
	public partial class puntoDeVenta : Form
	{
		public puntoDeVenta()
		{
			InitializeComponent();
		
		}
		void ButtonBuscaProductoClick(object sender, EventArgs e)
		{	
			
			
			buscarProductoUserMod busca = new buscarProductoUserMod();
			busca.Show();
			this.Hide();
		}
		
	}
}
