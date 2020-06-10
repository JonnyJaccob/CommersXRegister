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
    abstract class Proveedor
    {
        private string _strNombreP;

        public string NombreP
        {
            get { return _strNombreP; }
            set { _strNombreP = value; }
        }
        private string _strDireccion;

        public string DireccionP
        {
            get { return _strDireccion; }
            set { _strDireccion = value; }
        }
        private string _strEncargado;

        public string EncargadoP
        {
            get { return _strEncargado; }
            set { _strEncargado = value; }
        }
        private double _dblIntervalo;

        public double IntervaloBono
        {
            get { return _dblIntervalo; }
            set { _dblIntervalo = value; }
        }
        private double _dblDescuento;

        public double Descuento
        {
            get { return _dblDescuento; }
            set { _dblDescuento = value; }
        }
        public virtual double CalcularDescuento()
        {
            return 0;
        }
        public virtual double CalcularBonoPreferencial()
        {
            return 0;
        }
    }
}
