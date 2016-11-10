/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoFinal
{
	public class clsCheque
	{
		
		private int idCheque;
		//private DateTime fechaEmision;
		private String fechaEmision;
		private double monto;
		private String moneda;
		
		public clsCheque()
		{
		}
		
		public clsCheque(int id, String fEmision, double mont, String mone)
		{
			this.IdCheque=id;
			this.FechaEmision=fEmision;
			this.Monto=mont;
			this.Moneda=mone;
		}
		
		public int IdCheque{
			set{this.idCheque=value;}
			get{return this.idCheque;}
		}
		
		public String FechaEmision{
			set{this.fechaEmision=value;}
			get{return this.fechaEmision;}
		}
		
		public double Monto{
			set{this.monto=value;}
			get{return this.monto;}
		}
		
		public String Moneda{
			set{this.moneda=value;}
			get{return this.moneda;}
		}
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + FechaEmision.Length*2 + 16 + Moneda.Length*2 ; }
  		}
  		
	}
}