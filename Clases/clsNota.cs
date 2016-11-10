/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:37 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Facturas_TPFinal_C
{
	public class clsNota
	{
		//NATIVE
		
		private int idNota;
		private String tipo;
		private float monto;
		private DateTime fecha;
		
		//CONSTRUCTOR
		
		public clsNota(int id, String tip, float mon, DateTime fec)
		{
			this.IdNota=id;
			this.Tipo=tip;
			this.Monto=mon;
			this.Fecha=fec;
		}
		
		//PROPERTIES
		
		public int IdNota{
			set{this.idNota=value;}
			get{return this.idNota;}
		}
		
		public String Tipo{
			set{this.tipo=value;}
			get{return this.tipo;}
		}
		
		public float Monto{
			set{this.monto=value;}
			get{return this.monto;}
		}
		
		public DateTime Fecha{
			set{this.fecha=value;}
			get{return this.fecha;}
		}
		
		/*
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + FechaEmision.Length*2 + FechaCobro.Length*2 + Tipo.Length*2 + Modo.Length*2 ; }
  		}
  		*/
		
	}
}
