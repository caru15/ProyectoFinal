using System;

namespace ProyectoFinal
{
    public class clsNota
    {
          private int idNota;
        private String tipo;
        private float monto;
        private DateTime fecha;
        private int IdFactura;

        //CONSTRUCTOR

        public clsNota(int id, String tip, float mon, DateTime fec, int If)
        {
            this.IdNota = id;
            this.Tipo = tip;
            this.Monto = mon;
            this.Fecha = fec;
            IdFactura = If;
        }

        //PROPERTIES

        public int IdNota
        {
            set { this.idNota = value; }
            get { return this.idNota; }
        }

        public String Tipo
        {
            set { this.tipo = value; }
            get { return this.tipo; }
        }

        public float Monto
        {
            set { this.monto = value; }
            get { return this.monto; }
        }

        public DateTime Fecha
        {
            set { this.fecha = value; }
            get { return this.fecha; }
        }

        public int IdFactu
        {
            get { return IdFactura; }
            set { IdFactura = value; }
        }

        public int TamNota
        {
            get { return ((8 * 2) + (32 * 2) + (tipo.Length * 2) + (32 * 2) + (32 * 2)); }

        }
    }
    }
