﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProyectoFinal;

public partial class Facturas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Unnamed14_Click(object sender, EventArgs e)
    {
        ListaFacturas lista = new ListaFacturas("c://facturas.bin");
        clsFactura obj = new clsFactura(1, Convert.ToDateTime(FechaEmi.Text), Convert.ToDateTime(FechaCobro.Text), "Propia", ComboModo.Text, 1, 1,1);
        lista.EscribirRegistro(1,obj);
    }
}