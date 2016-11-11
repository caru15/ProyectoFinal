using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ProyectoFinal;


public class ListaCheques
{
    private FileStream fs,fst;          
    private BinaryWriter bw,bwt;        
    private BinaryReader br,brt;        
    private int nregs;              
    private int tamañoReg = 150;

    public ListaCheques(String fichero)
    {
        abrirFichero(fichero);
    }

    public int Nregs
    {
        get { return nregs; }
    }

    public void agregarRegistro(clsCheque obj)//agrega un registro al ultimo
    {
        if (EscribirRegistro(nregs, obj))
        {
            nregs++; }
    }

    public bool EscribirRegistro(int i, clsCheque obj)
    {
        if (i >= 0 && i <= nregs)
        {
            if (obj.Tamaño + 4 < tamañoReg)
            {
                bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                bw.Write(obj.IdCheque);
                bw.Write(obj.FechaEmision.ToString());
                bw.Write(obj.Monto);
                bw.Write(obj.Moneda);
                CerrarFichero();
                return true;
            }
            else { Console.WriteLine("El tamaño del Registro es muy grande"); return false; }
        }
        else
        {
            return false;
        }
    }

    public void abrirFichero(String path)
    {  
        if (Directory.Exists(path))
            throw new IOException(Path.GetFileName(path) + " no es un fichero");
        fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        bw = new BinaryWriter(fs);
        br = new BinaryReader(fs);

        // Como es casi seguro que el último registro no ocupe el
        // tamaño fijado, utilizamos Ceiling para redondear por encima.
        nregs = (int)Math.Ceiling((double)fs.Length / (double)tamañoReg);
    }

    public void CerrarFichero() { bw.Close(); br.Close(); fs.Close(); }

    public int NúmeroDeRegs() { return nregs; } //devuelve número de registros

    public clsCheque LeerReg(int i)
    {
        if (i >= 0 && i <= nregs)
        {
            br.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
            int idcheque = br.ReadInt32();
            string fechaemisioncheque = br.ReadString();
            double montoCheque = br.ReadDouble();
            string moneda = br.ReadString();

            return (new clsCheque(idcheque, Convert.ToDateTime(fechaemisioncheque), montoCheque, moneda));
        }
        else
        {
            return null;
        }
    }
    //busca el cheque por id y devuelve la posicion
    public int BuscarCheque(int idcheque)
    {
        clsCheque obj;
        int num;
        int reg_i = 0;
        bool encontrado = false;

        if (idcheque < 0) { return -1; }
        else
        {
            while ((reg_i < nregs) && (!encontrado))
            {
                obj = LeerReg(reg_i);
                num = obj.IdCheque;
                if (num == idcheque)
                { encontrado = true; }
                else
                    reg_i++;
            }
            if (encontrado) { return reg_i;}
            else
            { return -1;}
        }
    }
    //elimina cheque pasando numero de id
    public void EliminarCheque(int idche,string fichero) {

        int pos = BuscarCheque(idche);
        fst = new FileStream("Tempo.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        bwt = new BinaryWriter(fst);
        brt = new BinaryReader(fst);
        clsCheque cheque1;

    }
}

/* public void EliminarEmail(int i,string fichero){

string opcion;
int pos, j;

ClsEmail eliminado = new ClsEmail();
 	
 	if (i>=0 && i<=nEmail){
 		eliminado=LeerEmail(i);//eliminado es mi objeto Email a eliminar
Console.WriteLine("El email a eliminar es :");
 	    Console.WriteLine(eliminado.Dir_Remitente);
		Console.WriteLine(eliminado.Dir_Destinatario);
		Console.WriteLine(eliminado.Cuerpo);
		Console.WriteLine(eliminado.Fecha);
		Console.WriteLine(eliminado.Leido);
		Console.Write("DESEA ELIMINARLO S/N:");
		opcion=Console.ReadLine();
		if (opcion=="s" || opcion=="S"){
	      fst = new FileStream("F:\\temp.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
bwt = new BinaryWriter(fs);
brt = new BinaryReader(fs);
pos=j=0;
          	while(pos<=nEmail){
            if (pos!=i){//aqui leo el primero del fichero y lo pongo en el temporal
          		        br.BaseStream.Seek(pos* tamañoEmail, SeekOrigin.Begin);
 		                string dirRemitente = br.ReadString();
string dirDestinatario = br.ReadString();
string asunto = br.ReadString();
string cuerpo = br.ReadString();
string fecha = br.ReadString();
bool estado = br.ReadBoolean();
bwt.BaseStream.Seek(j* tamañoEmail, SeekOrigin.Begin);
					
					    bwt.Write(dirRemitente);
					    bwt.Write(dirDestinatario);
					    bwt.Write(asunto);
					    bwt.Write(cuerpo);
					    bwt.Write(fecha);
					    bwt.Write(estado);
					    pos++;
					    j++;
          	}else{pos++;}}
             Cerrar();
bwt.Close();
             brt.Close();
             fst.Close();
			File.Delete(fichero);
			File.Move("tmp.txt",fichero);
			fs= new FileStream(fichero, FileMode.OpenOrCreate, FileAccess.ReadWrite);
bw = new BinaryWriter(fs);
br = new BinaryReader(fs);
		}else {Console.WriteLine("No se elimino nada ");}
 	}
 	
 }
	}*/