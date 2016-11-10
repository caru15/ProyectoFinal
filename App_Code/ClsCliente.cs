/*
 * Created by SharpDevelop.
 * User: JORGE
 * Date: 9/11/2016
 * Time: 1:36 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

<<<<<<< HEAD:App_Code/ClsCliente.cs
namespace ProyectoFinal
=======
namespace Facturas_TPFinal_C
>>>>>>> origin/master:Clases/ClsCliente.cs
{
	public class clsCliente
	{
		
		private String nombre;
		private String apellido;
		private long dni;
		private String domicilio;
		private long telefono;
		private String cuenta;
		private String email;
		
		public clsCliente()
		{
<<<<<<< HEAD:App_Code/ClsCliente.cs
			this.Nombre="nn";
			this.Apellido="nn";
			this.Dni=0;
			this.Domicilio="nn";
			this.Telefono=0;
			this.Cuenta="nn";
			this.Email="nn";
=======
			this.Nombre=nn;
			this.Apellido=nn;
			this.Dni=0;
			this.Domicilio=nn;
			this.Telefono=0;
			this.Cuenta=nn;
			this.Email=nn;
>>>>>>> origin/master:Clases/ClsCliente.cs
		}
		
		
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
		
<<<<<<< HEAD:App_Code/ClsCliente.cs
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return Nombre.Length*2 + Apellido.Length*2 + 8 + Domicilio.Length*2 + 8 + Cuenta.Length*2 + Email.Length*2 ; }
  		}
		
=======
		/*
		public int Tamaño //tamaño del registro Persona
  		{
    		// Longitud en bytes de los atributos (un long = 8 bytes)
    		get { return 4 + FechaEmision.Length*2 + FechaCobro.Length*2 + Tipo.Length*2 + Modo.Length*2 ; }
  		}
  		*/
>>>>>>> origin/master:Clases/ClsCliente.cs
	}
}
