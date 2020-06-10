using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPoo
{
    class Sorteador
    {
        public delegate bool CriterioOrdenamiento(Producto x, Producto y, Producto.AtributoComparable campo);
        public bool Ascendente(Producto x, Producto y, Producto.AtributoComparable campo)
        {
            if (campo(x, y) > 0)
            {
                return true;
            }
            else return false;
        }
        public bool Descendente(Producto x, Producto y, Producto.AtributoComparable campo)
        {
            if (campo(x, y) < 0)
            {
                return true;
            }
            else return false;
        }
        public void Ordenar(Producto[] arreglo, CriterioOrdenamiento orden, Producto.AtributoComparable campo)
        {
            
            for (int p = 0; p < arreglo.Length - 1; p++)
            {
                for (int e = p + 1; e < arreglo.Length; e = e + 1)
                {
                    if(orden(arreglo[p],arreglo[e],campo))
                    {   
                        Producto Temporal;
                        Temporal = arreglo[p];
                        arreglo[p] = arreglo[e];
                        arreglo[e] = Temporal;
                       
                    }
                }
            }
        }
        
    }           
}
