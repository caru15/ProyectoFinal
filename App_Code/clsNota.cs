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
	public class clsNota
	{
		//NATIVE
		
		private int idNota;
		private String tipo;
		private double monto;
		//private DateTime fecha;
		private String fecha;
		
		//CONSTRUCTOR
		
		public clsNota()
		{
		}
		
		public clsNota(int id, String tip, double mon, string fec)
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
		
		public double Monto{
			set{this.monto=value;}
			get{return this.monto;}
		}
		
		public string Fecha{
			set{this.fecha=value;}
			get{return this.fecha;}
		}
		
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + Tipo.Length*2 + 16 + Fecha.Length *2 ; }
  		}
  		
		
	}
}
