/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:35 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProyectoFinal
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
		private clsCliente cliente =new clsCliente();
		private clsNota nota = new clsNota();
		private clsCheque cheque = new clsCheque();
		
		//CONSTRUCTOR
		
		public clsFactura(int idFact, string fEmision, string fCobro , string tip, string mod)
		{
			this.IdFactura = idFact;
			this.FechaEmision = fEmision;
			this.FechaCobro = fCobro;
			//this.tipo = new string[50];
			this.Tipo = tip;
			this.Modo = mod;
			
		}
		
		public clsFactura(int idFact, string fEmision, string fCobro , string tip, string mod ,clsCliente cli)
		{
			this.IdFactura = idFact;
			this.FechaEmision = fEmision;
			this.FechaCobro = fCobro;
			//this.tipo = new string[50];
			this.Tipo = tip;
			this.Modo = mod;
			this.Cliente= cli;
			
		}
		
		public clsFactura(int idFact, string fEmision, string fCobro , string tip, string mod ,clsCliente cli , clsNota not)
		{
			this.IdFactura = idFact;
			this.FechaEmision = fEmision;
			this.FechaCobro = fCobro;
			//this.tipo = new string[50];
			this.Tipo = tip;
			this.Modo = mod;
			this.Cliente= cli;
			this.Nota = not ;
			
		}
		
		public clsFactura(int idFact, string fEmision, string fCobro , string tip, string mod ,clsCliente cli , clsNota not , clsCheque cheq)
		{
			this.IdFactura = idFact;
			this.FechaEmision = fEmision;
			this.FechaCobro = fCobro;
			//this.tipo = new string[50];
			this.Tipo = tip;
			this.Modo = mod;
			this.Cliente= cli;
			this.Nota = not ;
			this.Cheque = cheq;
			
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
		
		public clsCliente Cliente{
        	get{return cliente;}
        	set{cliente=value;}
        }
		
		public clsNota Nota{
        	get{return nota;}
        	set{nota=value;}
        }
		
		public clsCheque Cheque{
        	get{return cheque;}
        	set{cheque=value;}
        }
		
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + FechaEmision.Length*2 + FechaCobro.Length*2 + Tipo.Length*2 + Modo.Length*2 + Cliente.Tamaño + Nota.Tamaño + Cheque.Tamaño ; }
  		}
		
	}
}
