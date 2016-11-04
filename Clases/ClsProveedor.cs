using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

public class ClsProveedor
{
    private int IdProveedor;
    private int NroCuenta;
    private string Nombre;
    private string Domicilio;
    private string Email;

    public ClsProveedor() { }

    public ClsProveedor(int ip,int nc,string Nom,string Dom, string Em)
    {
        this.IdProveedor = ip;
        this.NroCuenta = nc;
        this.Nombre = Nom;
        this.Domicilio = Dom;
        this.Email = Em;
    }
     public int SGIdProveedor
    {
       get { return IdProveedor; }
   set  { IdProveedor = value;  }}

    public int SGNroCuenta {
    get { return NroCuenta; }
    set { NroCuenta = value; } } 

    public string SGNombre {
    get { return Nombre; }
    set { Nombre = value; } }

    public string SGDomicilio {
    get { return Domicilio; }
    set { Domicilio = value; } }

    public string SGEmail { 
        get{ return Email; }
    set { Email = value; }}

    public int TamProveedor
    {
        get { return 32 + 32 + Nombre.Length * 2 + Domicilio.Length * 2 + Email.Length * 2; }
    }
}