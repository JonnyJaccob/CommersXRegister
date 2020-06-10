using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProyectoPoo
{   
    [Serializable]
    abstract class Cliente:Proveedor
    {
        private string _strNombreC;

        public string NombreC
        {
            get { return _strNombreC; }
            set { _strNombreC = value; }
        }
        private string _strDireccion;

        public string DireccionC
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }
        private string _strEncargado;

        public string EncargadoC
        {
            get { return _strEncargado; }
            set { _strEncargado = value; }
        }
        public DateTime FechaCapturacion = new DateTime();
        //public int xy = FechaCapturacion.Month;
        private double _dblAcarreo;

        public double Acarreo
        {
            get { return _dblAcarreo; }
            set { _dblAcarreo = value; }
        }
        private double _dblTotal;

        public double Total
        {
            get { return _dblTotal; }
            set { _dblTotal = value; }
        }
        public virtual double CalcularAcarreo()
        {
            return 0;
        }
        public virtual double CalcularTotal()
        {
            return 0;
        }
    }
}
