﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa,introduce dos valores:");
            String n1, n2;
            n1 = Console.ReadLine();
            n2 = Console.ReadLine();
            enteroLargo A = new enteroLargo(n1);
            enteroLargo B = new enteroLargo(n2);
            enteroLargo C = A + B;
            Console.WriteLine(A.getNumero());
            Console.WriteLine(B.getNumero());
            Console.WriteLine("+ _______________");
            Console.WriteLine(C.getNumero());
            Console.ReadLine();
        }
    }
}