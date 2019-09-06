using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1._Encapsulacion
{
   public class vehiculo
    {
        private int id;
        private string Nombre;
        private decimal Anio;
        private string Tipo;
        private string Marca;


        public int Id
        {
            get { return id; }
            set { id = value; }
          
        }
        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        public decimal anio
        {
            get { return Anio; }
            set { Anio = value; }
        }
        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public string marca
        {
            get { return Marca; }
            set { Marca = value; }
        }
    }
}
