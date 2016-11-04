using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class ClsCuenta
{
    private double FondoDolares;
    private int IdCuenta;
    private double FondoPesos;
    private double DepBancario;
    private double ChequesCobrados;
    private double ChequesDebitados;
    private DateTime FechaAlta;

    public ClsCuenta()
    {    }

    public ClsCuenta(int IC,double FD,double FP, double DB, double CC, double CD,DateTime FA)
    {
        this.IdCuenta = IC;
        this.FondoDolares = FD;
        this.FondoPesos = FP;
        this.DepBancario = DB;
        this.ChequesCobrados = CC;
        this.ChequesDebitados = CD;
        this.FechaAlta = FA; 
    }
    public int SGIdCuenta
    {
        set { IdCuenta = value; }
        get { return IdCuenta; }
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
    public DateTime SGFechaAlta
    {
        get { return FechaAlta; }
        set { FechaAlta = value; }
    }
    public int TamCuenta {
    get { return 32 + (5 * 64); } }
}