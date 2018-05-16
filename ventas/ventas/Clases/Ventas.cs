
using System;

namespace ventas.Clases
{


	public class Ventas
	{
		public int idusuario;
		public int idproducto;
		
		public Ventas()
		{
		}
		
		public Ventas(int vIdusuario,int vIdproducto){
			this.idproducto = vIdproducto;
			this.idusuario = vIdusuario;
		}
	}
}
