using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using ProyectoFinal;

namespace ProyectoFinal
{

    public class ListaNotas
    {
        private FileStream fs;
        private BinaryReader br;
        private BinaryWriter bw;
        private int NroReg;
        private int tamReg = 250;


        //CONSTRUCTOR
        public ListaNotas(string fichero)
        {
            if (Directory.Exists(fichero))
                throw new IOException(Path.GetFileName(fichero) + " no es un fichero");
            fs = new FileStream(fichero, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            bw = new BinaryWriter(fs);
            br = new BinaryReader(fs);
        }
        public void CerrarFicheros() { bw.Close(); br.Close(); fs.Close(); }
        public int NroDeReg() { return NroReg; }
        public bool ModiRegistro(int pos,clsNota nota)
        {
            if (pos >= 0 && pos <= NroReg)
            {
                if (nota.TamNota + 4 > tamReg) Console.WriteLine("Tamaño del registro muy Grande");
                else
                {
                    bw.BaseStream.Seek(pos * tamReg, SeekOrigin.Begin);
                    bw.Write(nota.IdNota);
                    bw.Write(nota.Tipo);
                    bw.Write(nota.Monto);
                    bw.Write(Convert.ToString(nota.Fecha));
                    bw.Write(nota.IdFactu);
                    return true;
                }
            }
            else Console.WriteLine("Numero de Registros Fuera del Limite");
            return false;
        }
        public void AltaRegistro(clsNota nota)
        {
            if (ModiRegistro(NroReg, nota)) NroReg++;
        }
    }
}