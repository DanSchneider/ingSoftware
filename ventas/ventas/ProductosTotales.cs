﻿/*
 * Creado por SharpDevelop.
 * Usuario: JL
 * Fecha: 12/05/2018
 * Hora: 08:43 p.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ventas
{
	/// <summary>
	/// Description of ProductosTotales.
	/// </summary>
	public partial class ProductosTotales : Form
	{
		public ProductosTotales()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void ButtonRegresarClick(object sender, EventArgs e)
		{
			productosAdmi admiprod=new productosAdmi();
			admiprod.Show();
			this.Hide();
		}
	}
}
