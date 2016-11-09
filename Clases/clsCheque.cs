/*
 * Created by SharpDevelop.
 * User: Juan Morales
 * Date: 3/11/2016
 * Time: 10:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyFinal
{
	/// <summary>
	/// Description of clsCheque.
	/// </summary>
	public class clsCheque
	{
		
		private int idCheque;
		private DateTime fechaEmision;
		private double monto;
		private String moneda;
		
		public clsCheque(int id, DateTime fEmision, double mont, String mone)
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
		
		public DateTime FechaEmision{
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
	}
}
