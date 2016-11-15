using System;
using ProyectoFinal;
using System.Windows;

namespace ProyectoFinal
{
	using System;
	using System.IO;
	public class ListaFacturas 

	{
		private FileStream fs;          // flujo subyacente
  		private BinaryWriter bw;        // flujo hacia el fichero
	    private BinaryReader br;        // flujo desde el fichero
  		private int nregs;              // número de registros
  		private int tamañoReg = 160;    // tamaño del registro en bytes
  	
        //CONSTRUCTOR
		public ListaFacturas(String fichero)
		{
    		abrirFichero(fichero);
		}

        public void abrirFichero(String path)
        {  
            if (Directory.Exists(path))
                throw new IOException(Path.GetFileName(path) + " no es un fichero");
            fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bw = new BinaryWriter(fs);
            br = new BinaryReader(fs);
        }

        public void CerrarFichero() { bw.Close(); br.Close(); fs.Close(); }

        public int Registro
        {
			get{return nregs;}
		}

		public void agregarRegistro(clsFactura obj)
        {
            if (EscribirRegistro(nregs, obj)) this.nregs++;
		}
		
		public bool EscribirRegistro(int i,clsFactura obj)
        {
            try
            {
                if (i >= 0 && i <= nregs)
                {
                    if (obj.Tamaño + 4 > tamañoReg)
                    {
                        Console.WriteLine("Tamaño de registro excedido.");
                        return false;
                    }
                    else
                    {
                        bw.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                        bw.Write(obj.IdFactura);
                        bw.Write(obj.FechaEmision.ToString());//lo mando al dato datetime a string para poder guardarlo en el fichero
                        bw.Write(obj.FechaCobro.ToString());
                        bw.Write(obj.Tipo);
                        bw.Write(obj.Modo);
                        //estos son los id`s de cliente nota y cheques los gaurdo en el fichero
                        bw.Write(obj.Cliente);
                        bw.Write(obj.Nota);
                        bw.Write(obj.Cheque);
                        return true;
                    }
                }
                else { return false; }
            }
            catch (IOException e) { CerrarFichero(); Console.WriteLine(e.Message); return false; }
        }

        public clsFactura LeerReg( int i )//lee registro mandandole la posicion
		  { if (i >= 0 && i <= nregs)
            {
                br.BaseStream.Seek(i * tamañoReg, SeekOrigin.Begin);
                int idFactura = br.ReadInt32();
                string fechaEmision = br.ReadString();
                string fechaCobro = br.ReadString();
                string tipo = br.ReadString();
                string modo = br.ReadString();
                int IdCliente = br.ReadInt32();
                int idnota = br.ReadInt32();
                int idcheque = br.ReadInt32();
                return (new clsFactura(idFactura, Convert.ToDateTime(fechaEmision), Convert.ToDateTime(fechaCobro), tipo, modo, IdCliente, idnota, idcheque));
            }
            else { return null; }
	    }

        //BUSCA POR ID DE LA FACTURA y devuelve la posicion en el fichero
        public int BuscarReg(int IDFactura)
        {
            clsFactura obj;
            int ide;
            int reg_i = 0;
            bool encontrado = false;

            if (IDFactura < 0) { return -1; }
            else
            {
                while ((reg_i < nregs) && (!encontrado))
                {
                    obj = LeerReg(reg_i);
                    ide = obj.IdFactura;
                    if (ide == IDFactura)
                    {
                        encontrado = true;
                    }
                    else { reg_i++; }
                }

                if (encontrado)
                {
                    return reg_i;
                }
                else
                {
                    return -1;
                }
            }}

        //BUSCA POR id DE CLIENTE y devuelve la posicion en el fichero de la factura
        public int BuscarClienteReg(int idcli)
        {
            clsFactura obj;
            long num;
            int reg_i = 0;
            bool encontrado = false;

            if (idcli < 0) { return -1; }
            else
            {
                while ((reg_i < nregs) && (!encontrado))
                {
                    obj = LeerReg(reg_i);
                    num = obj.Cliente;
                    if (num == idcli)
                    {
                        encontrado = true;
                    }
                    else
                    {reg_i++; }
                }
                if (encontrado)
                {
                    return reg_i;
                }
                else
                {
                    return -1;
                }
            }
        }
  		//BUSCA NOTA POR ID
  		public int BuscarNotaReg(int idnota)
		  {
    		
    		clsFactura obj;
    		int num;
    		int reg_i = 0;
    		bool encontrado = false;
    
    		if (idnota < 0 ) return -1;
    		while( (reg_i < nregs) && (!encontrado)) {
    					obj = LeerReg(reg_i);
    					num = obj.Nota;
    					if(num == idnota){
    								encontrado = true;
    					}
    					else
    						reg_i++;
    			}
    		if ( encontrado){
    					return reg_i;
    		}else{
    			return -1;}
  		}
  		//BUSCAR CHEQUE POR ID
  		public int BuscarChequeReg(int idcheque)
		  {
    		clsFactura obj;
    		int num;
    		int reg_i = 0;
    		bool encontrado = false;
    
    		if (idcheque < 0 ) return -1;
    		while( (reg_i < nregs) && (!encontrado)) {
    					obj = LeerReg(reg_i);
    					num = obj.Cheque;
    					if(num == idcheque){
    								encontrado = true;
    					}
    					else
    						reg_i++;
    			}
    		if ( encontrado){
    					return reg_i;
    		}else{
    			return -1;}
  		}	
	}
}
