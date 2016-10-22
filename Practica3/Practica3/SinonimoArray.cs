using System;
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
