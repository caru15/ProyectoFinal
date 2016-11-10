/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Facturas_TPFinal_C
{
	public class clsFactura
	{
		
		//NATIVE
		
		private int idFactura;
		//private DateTime fechaEmision;
		private string fechaEmision;
    	//private DateTime fechaCobro;
    	private string fechaCobro;
		//public String[] tipo;
		private string tipo;
		private string modo;
		private ClsCliente Cliente =new ClsCliente();
		
		//CONSTRUCTOR
		
		public ClsFactura(int idFact, string fEmision, string fCobro , string tip, string mod)
		{
			this.IdFactura = idFact;
			this.FechaEmision = fEmision;
			this.FechaCobro = fCobro;
			//this.tipo = new string[50];
			this.Tipo = tip;
			this.Modo = mod;
			
		}
		
		//PROPERTIES
		
		public int IdFactura{
			get{return idFactura;}
			set{idFactura=value;}
		}
		
		public string FechaEmision{
			get{return fechaEmision;}
			set{fechaEmision=value;}
		}
		
		public string FechaCobro{
			get{return fechaCobro;}
			set{fechaCobro=value;}
		}
		
		public string Tipo{
			get{return tipo;}
			set{tipo=value;}
		}
		
		public string Modo{
			get{return modo;}
			set{modo=value;}
		}
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + FechaEmision.Length*2 + FechaCobro.Length*2 + Tipo.Length*2 + Modo.Length*2 ; }
  		}
		
	}
}
