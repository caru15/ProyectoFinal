using System;

namespace Facturas_TPFinal_C
{
	using System;
	using System.IO;
	public class ListaFacturas 
	{
		private FileStream fs;          // flujo subyacente
  		private BinaryWriter bw;        // flujo hacia el fichero
	    private BinaryReader br;        // flujo desde el fichero
  		private int nregs;              // número de registros
  		private int tamañoReg = 300;    // tamaño del registro en bytes
  		private bool regsEliminados = false; // true si se
                                  // eliminaron registros
                                  
        // ESTO VA PARA QUE SEA ESTTICO
        //private static ListaPrestamos Prestamos; pero en este caso es con facturas
	
		public ListaFacturas(String fichero)
		{
    		abrirFichero(fichero);
		}
		public int Nregs{
			get{return nregs;}
		}
		public void agregarRegistro(clsFactura obj){
			if(EscribirRegistro(nregs,obj)){
				nregs++;
			}
		}
		
		public bool EscribirRegistro(int i,clsFactura obj){
			if(i >= 0 && i <= nregs){
				if(obj.Tamaño+4 < tamañoReg){
					bw.BaseStream.Seek(i*tamañoReg,SeekOrigin.Begin);
					/*
					bw.Write((obj.Prestamos).NroPrestamo);
					bw.Write(obj.NumIdentidad);
					bw.Write(obj.Nombre);
					bw.Write(obj.Apellido);
					bw.Write(obj.Telefono);
					bw.Write(obj.Celular);
					bw.Write((obj.Prestamos).Monto);
					bw.Write((obj.Prestamos).Fecha);
					bw.Write((obj.Prestamos).FechaAutorizacion);
					bw.Write((obj.Prestamos).FechaEntregaPrestamo);
					bw.Write((obj.Prestamos).Cuotacero);
					bw.Write((obj.Prestamos).Cuotauno);
					bw.Write((obj.Prestamos).Cuotados);
					bw.Write((obj.Prestamos).Cuotatres);
					bw.Write((obj.Prestamos).Cuotacuatro);
					bw.Write((obj.Prestamos).Cuotacinco);
					*/
					bw.Write(obj.IdFactura);
					bw.Write(obj.FechaEmision);
					bw.Write(obj.FechaCobro);
					bw.Write(obj.Tipo);
					bw.Write(obj.Modo);
					CerrarFichero();
					return true;
				}
			}
			return false;
		}
		
		public void abrirFichero(String path){	//Agregado
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

  		//public Persona LeerReg( int i )
  		public clsFactura LeerReg( int i )
		  {

    		if(i>=0 && i<=nregs)
    			{
    				//Situar el puntero de L/E
    				br.BaseStream.Seek(i*tamañoReg , SeekOrigin.Begin);
    				
    				int idFactura = br.ReadInt32();
    				string fechaEmision = br.ReadString();
    				string fechaCobro = br.ReadString();
    				string tipo = br.ReadString();
    				string modo = br.ReadString();
    				
		    	return (new clsFactura(idFactura,fechaEmision,fechaCobro,tipo, modo));
		    }
		    else
		    {
		    	return null;
	    	}
 		}  	

		 
  		public int BuscarReg(int IDFactura)
		  {
    		// Buscar un registro por una subcadena del nombre
    		// a partir de un registro determinado
    		clsFactura obj;
    		int nom;
    		int reg_i = 0;
    		bool encontrado = false;
    
    		if (IDFactura < 0 ) return -1;
    		while( (reg_i < nregs) && (!encontrado)) {
    					obj = LeerReg(reg_i);
    					nom = obj.IdFactura;
    					if(nom == IDFactura){
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
  		/*
  		public int BuscarPrestamoReg(int nroPrestamo)
		  {
    		// Buscar un registro por una subcadena del nombre
    		// a partir de un registro determinado
    		Persona obj;
    		int num;
    		int reg_i = 0;
    		bool encontrado = false;
    
    		if (nroPrestamo < 0 ) return -1;
    		while( (reg_i < nregs) && (!encontrado)) {
    					obj = LeerReg(reg_i);
    					num = obj.Prestamos.NroPrestamo;
    					if(num == nroPrestamo){
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
  		*/
  		/*
  		public double MontoTotal(int nroIdentidad){
  			double monto = 0;
  			Persona obj;
  			int i=0,nom;
  			while( i < nregs ){
  				obj = LeerReg(i);
  				nom = obj.NumIdentidad;
    			if(nom == nroIdentidad){
  					monto = monto + (obj.Prestamos).Monto;
    					}
  				i++;
  			}
  			return monto;
  		}
  		
  		public bool TopePrestamo(int nroIdentidad){
  			int topePrestamo = 0;
  			Persona obj;
  			int i=0,nom;
  			while( i < nregs ){
  				obj = LeerReg(i);
  				nom = obj.NumIdentidad;
    			if(nom == nroIdentidad){
  					topePrestamo = topePrestamo + 1;
    					if(topePrestamo >= obj.TopeMaximo){
  							return true;
 							}		
  					}
  				i++;
  			}
  			return false;
  		}
  		*/
  		
	}
}
