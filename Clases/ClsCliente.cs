/*
 * Created by SharpDevelop.
 * User: Juan Morales
 * Date: 3/11/2016
 * Time: 10:41 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace proyFinal
{
	/// <summary>
	/// Description of clsCliente.
	/// </summary>
	public class clsCliente
	{
		
		private String nombre;
		private String apellido;
		private long dni;
		private String domicilio;
		private long telefono;
		private String cuenta;
		private String email;
		
		public clsCliente(String nom, String ape, long doc, String dom, long tel, String cuen, String mail)
		{
			this.Nombre=nom;
			this.Apellido=ape;
			this.Dni=doc;
			this.Domicilio=dom;
			this.Telefono=tel;
			this.Cuenta=cuen;
			this.Email=mail;
		}
		
		public String Nombre{
			set{this.nombre=value;}
			get{return this.nombre;}
		}
		
		public String Apellido{
			set{this.apellido=value;}
			get{return this.apellido;}
		}
		
		public long Dni{
			set{this.dni=value;}
			get{return this.dni;}
		}
		
		public String Domicilio{
			set{this.domicilio=value;}
			get{return this.domicilio;}
		}
		
		public long Telefono{
			set{this.telefono=value;}
			get{return this.telefono;}
		}
		
		public String Cuenta{
			set{this.cuenta=value;}
			get{return this.cuenta;}
		}
		
		public String Email{
			set{this.email=value;}
			get{return this.email;}
		}
		
		
	}
}
