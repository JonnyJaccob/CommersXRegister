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
    class Producto : Cliente
    {
        private string Nombrex;

        public string Nombre
        {
            get { return Nombrex; }
            set { Nombrex = value; }
        }
        private string _strMarca;

        public string Marca
        {
            get { return _strMarca; }
            set { _strMarca = value; }
        }
        private double _dblImporte;

        public double Importe
        {
            get { return _dblImporte; }
            set { _dblImporte = value; }
        }
        public DateTime FechaExpiracion = new DateTime();
        

        public int TipoMes()
        {
            int m = FechaCapturacion.Month;
            
            switch (m)
            {
                case 1:
                return 1;
                case 2:
                    return 2;
                case 3:
                    return 1;
                case 4:
                    return 3;
                case 5:
                    return 1;
                case 6:
                    return 3;
                case 7:
                    return 1;
                case 8:
                    return 3;
                case 9:
                    return 1;
                case 10:
                    return 3;
                case 11:
                    return 1;
                case 12:
                    return 3;
                default:
                return 0;
            }
        }

        public override double CalcularTotal()
        {
            double x = Acarreo + Importe;
            return (x - ((Importe * Descuento) + (IntervaloBono * Importe)));
        }
        
        public delegate int AtributoComparable(Producto x, Producto y);
        //public delegate bool CriterioOrdenamiento(Producto x, Producto y, AtributoComparable campo);
        public int CompararPorFecha(Producto x, Producto y)
        {
            if (x.FechaCapturacion > y.FechaCapturacion)
            {
                return 1;
            }
            else if (x.FechaCapturacion < y.FechaCapturacion)
            {
                return -1;
            }
            else return 0;
        }
        public int CompararPorNombreMercancia(Producto x, Producto y)
        {
            return (x.Nombre.CompareTo(y.Nombre));
        }
        public int CompararPorNombreProveedor(Producto x, Producto y)
        {
            try
            {
                return (x.NombreP.CompareTo(y.NombreP));
            } catch (NullReferenceException)
            {
                throw new Exception();
            }
        }
        public int CompararPorNombreCliente(Producto x, Producto y)
        {
            return (x.NombreC.CompareTo(y.NombreC));
        }
        public int CompararPorTotal(Producto x, Producto y)
        {
            try
            {
                if (x.Total > y.Total)
                {
                    return 1;
                }
                else if (x.Total < y.Total)
                {
                    return -1;
                }
                else return 0;
            } catch (NullReferenceException)
            {
                throw new Exception();
            }
        }
        /*public int Guardar()
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dialogo = Form1.saveDialog)
                {
                    if (dialogo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        using (Stream st = File.Open(dialogo.FileName, FileMode.OpenOrCreate))
                        {
                            var B = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                            B.Serialize(st, this);
                            return 0;
                        }

                    }
                    else
                    {
                        return 1;
                    }
                }
            }
            catch (Exception)
            {
                return 2;
            }}*/
    
        
    }
}
