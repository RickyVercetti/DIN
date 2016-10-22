﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class SinonimoArray
    {

        private String[][] arraySinonimos;

        public SinonimoArray()
        {
            arraySinonimos = new String[0][];
        }
        

        public void add(params String[] nuevoSinonimos)
        {

            foreach(String nuevoSinonimo in nuevoSinonimos)
            {

                foreach(String[] palabra in arraySinonimos)
                {

                    if(Array.IndexOf(palabra, nuevoSinonimo) < 0)
                    {
                        Array.Resize(ref arraySinonimos, arraySinonimos.Length + 1);

                    }
                    else
                    {
                        Console.WriteLine("La palabra " + palabra + " ya está introducida.");
                    }
                }
            }

        }
        public void search(String texto)
        {

        }
    }
}

/*Añadir
 Comprobamos que pasamos como minimo dos parametros
    Hacemos un foreach por cada uno de los parametros pasados
        Hacemos otro foreach por cada uno de los arrays que contiende arrays
            Comprobamos si la palabra está en el array
                Si está, tenemos que añadir todas las demas palabras(mirando que no estén)
                Si no está, creamos una posicion mas en el array y la añadimos todas
  
    Buscar

    Comprobamos que se pase un parametro
        Hacemos un foreach para recorrer el array
            Con el metodo indexOf buscamos si está dentro de esa posicion del array
                Si está, Mostramos todas las que hayan salvo esa palabra
                Si no está, la añadimos en una posicion nueva del array, ella sola

    */


