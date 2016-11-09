/*
 * Created by SharpDevelop.
 * User: Juan Morales
 * Date: 3/11/2016
 * Time: 10:25 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyFinal
{
	/// <summary>
	/// Description of clsFactura.
	/// </summary>
	public class clsFactura
	{
		
		//NATIVE
		
		private int idFactura;
		private DateTime fechaEmision;
    	private DateTime fechaCobro;
		public String tipo;
		private String modo;
		
		//CONSTRUCTOR
		
		public clsFactura(int idFact, DateTime fEmision, DateTime fCobro, String mod,string ti)
		{
			this.IdFactura = idFact;
			this.FechaCobro = fCobro;
			this.FechaEmision = fEmision;
			this.tipo =ti ;
		}
		
		//PROPERTIES
		
		public int IdFactura{
			get{return idFactura;}
			set{idFactura=value;}
		}
		
		public DateTime FechaEmision{
			get{return fechaEmision;}
			set{fechaEmision=value;}
		}
		
		public DateTime FechaCobro{
			get{return fechaCobro;}
			set{fechaCobro=value;}
		}
		
		public String Modo{
			get{return modo;}
			set{modo=value;}
		}
		
		
		
	}
}
