﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3E2.Models;

namespace Lab3E2.Models
{
    internal class hoja<T> where T : IComparable
    {
        #region varibles globales
        //id identificador del nodo a utilizar
        internal int id { get; set; }
        //padre valor id del nodo padre
        internal int Father { get; set; }
        //valores de la clase bebidas
        internal List<Bebidas> valores;
        //hijos valores id de los que conecta
        internal List<int> hijos { get; set; }
        //rango de nodo
        public int rango { get; set; }
        internal hoja(int range, int posicion, int padre)
        {
            if (rango < 0)
            {
                throw new ArgumentOutOfRangeException("rango");
            }
            if (posicion < 0)
            {
                throw new ArgumentOutOfRangeException("id");
            }
            id = posicion;
            rango = range;
            Father = padre;
        }
        #endregion

        //public void Insertar(Bebidas dato, int id)
        //{
        //    //no es raiz
        //    if (status != "raiz")
        //    {
        //        //no es padre
        //        if (hijos.Count == 0)
        //        {
        //            //no esta lleno
        //            if (valores.Count < rango)
        //            {

        //            }
        //            else
        //            //
        //            {

        //            }
        //        }
        //        //si es padre
        //        else
        //        {
        //            //recorrer hijos
        //            for (int i = 0; i < hijos.Count; i++)
        //            {
        //                //if (valores[i].CompareTo(dato))
        //                comparador(valores[i], dato);

        //            }
        //        }
        //    }
        //    //es raiz
        //    else
        //    {
        //        //no esta lleno
        //        if (valores.Count < rango)
        //        {
        //            int contador = 0;
        //            for (int i = 0; i < valores.Count; i++)
        //            {
        //                //es menor?
        //                if (comparador(dato, valores[i]) == 0)
        //                {

        //                    Insertar(dato, contador);
        //                }
        //                else
        //                {
        //                    contador += 1;
        //                    Insertar(dato, contador);
        //                }
        //            }
        //        }

        //    }
        //}

        internal int NoDatos
        {
            get
            {
                int i = 0;
                while (i < rango && hasSpace)
                {
                    i++;
                }
                return i;
            }
        }
        internal bool hasSpace
        {
            get
            {
                bool hasSpace = false;
                if ( hijos.Count < rango)
                {
                    hasSpace = true;
                }
                return hasSpace;
            }
        }
        internal bool IsLeaf
        {
            get
            {
                bool IsLeaf = true;

                return IsLeaf;
            }
        }
        internal bool Underflow
        {
            get
            {
                return (valores.Count < ((rango / 2) - 1));
            }
        }
        internal bool Overflow 
        {
            get
            {
                return (valores.Count > rango - 1);
            }
        }
        public int comparador(Bebidas bebida1, Bebidas dato)
        {
            return bebida1 == null || dato == null ? 1 :
                bebida1.nombre.CompareTo(dato.nombre);
        }
        /*if(!Isleaf)
        {
            if(dato < valores[i])
            {
                insertar(dato, llave[i]);
            }
        }*/
    }
}
