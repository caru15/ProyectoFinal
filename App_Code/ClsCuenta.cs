using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ClsCuenta
{
    private double FondoDolares;
    private double FondoPesos;
    private double DepBancario;
    private double ChequesCobrados;
    private double ChequesDebitados;


    public ClsCuenta() { }

    public ClsCuenta(double FD,double FP, double DB, double CC, double CD)
    {
        this.FondoDolares = FD;
        this.FondoPesos = FP;
        this.DepBancario = DB;
        this.ChequesCobrados = CC;
        this.ChequesDebitados = CD;
    }
  
        
    public double SGFondosDolares
    {
        get { return FondoDolares; }
        set { FondoDolares = value; }
    }

    public double SGFondoPesos
    {
        get { return FondoPesos; }
        set { FondoPesos = value; }
    }
    public double SGDepBanc
    {
        get { return DepBancario; }
        set { DepBancario = value; }
    }
    public double SGCheqCobrados
    {
        get { return ChequesCobrados; }
        set { ChequesCobrados = value; }
    }
    public double SGCheqDebitados
    {
        get { return ChequesDebitados; }
        set { ChequesDebitados = value; }
    }
   
    
    public int TamCuenta {
    get { return  (5 * 16); } }
}