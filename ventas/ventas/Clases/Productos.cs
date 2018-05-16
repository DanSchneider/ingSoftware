
using System;

namespace ventas
{

	public class Productos
	{
		public int Id { get; set; }
		public string NOMBRE { get; set; }
		public int EXISTENCIA { get; set; }
		public double PRECIO_N { get; set; }
		public double PRECIO_V { get; set; }
		
		
		public Productos(){}
		
		public Productos(int prId, string prNOMBRE, int prEXISTENCIA,
		                double prPRECIO_N, double prPRECIO_V){
			this.Id = prId;
			this.NOMBRE = prNOMBRE;
			this.EXISTENCIA = prEXISTENCIA;
			this.PRECIO_N = prPRECIO_N;
			this.PRECIO_V = prPRECIO_V;
			
		
	}
		
	}
}
