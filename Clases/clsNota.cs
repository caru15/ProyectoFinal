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
	/// Description of clsNota.
	/// </summary>
	public class clsNota
	{
		//NATIVE
		
		private int idNota;
		private String tipo;
		private float monto;
		private DateTime fecha;
        private int IdFactura;
		
		//CONSTRUCTOR
		
		public clsNota(int id, String tip, float mon, DateTime fec,int If)
		{
			this.IdNota=id;
			this.Tipo=tip;
			this.Monto=mon;
			this.Fecha=fec;
            IdFactura = If;
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

        public int IdFactu
        {
            get { return IdFactura; }
            set { IdFactura = value; }
        }
		
	}
}
