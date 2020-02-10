using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3E2.Models
{
    public class hoja<Bebidas> where Bebidas :IComparable
    {
        #region varibles globales
        //raiz
        string status { get; set; }
        //padre
        int padre { get; set; }
        //valores de la clase bebidas
        List<Bebidas> valores;
        //hijos
        List<int> hijos;
        //id
        int id { get; set; }
        //rango de nodo
        int rango;

        #endregion
        //constructor de la clase hoja
        public hoja() 
        {
            valores = new List<Bebidas>();
            hijos = new List<int>();
        }

        public void Insertar(Bebidas dato) 
        {
            //es raiz
            if (status != "raiz")
            {
                //no es padre
                if (hijos.Count == 0)
                {
                    //
                }
                //si es padre
                else
                {
                    //recorrer hijos
                    for (int i = 0; i < hijos.Count; i++)
                    {
                        if (valores[i].CompareTo(dato))
                        {

                        }
                    }
                }
            }
            //no es raiz
            else
            {

            }
        }

    }
}
