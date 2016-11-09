using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal2;

public partial class Proveedor : Page
{
    private int proveedorId = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
     
    }

    protected void CreateProveedor_Click(object sender, EventArgs e)
    {
        int NumCuenta;
        string Nombre, Domicilio, Email;
        NumCuenta = int.Parse(Cuenta.Text);
        Nombre = Prov.Text;
        proveedorId += 1;
        Domicilio = Dom.Text;
        Email = Mail.Text;
        ClsProveedor proveedor = new ClsProveedor(proveedorId, NumCuenta, Nombre, Domicilio, Email);

    }
}