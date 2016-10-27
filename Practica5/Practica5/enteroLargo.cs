namespace Practica5
{
    internal class enteroLargo
    {
        private string numero;
        private int longitud;

        public enteroLargo(string numero)
        {
            this.numero = numero;
            longitud = numero.Length;

        }

        public string getNumero()
        {
            return numero;
        }
        public static enteroLargo operator +(enteroLargo num1, enteroLargo num2)
        {
            int n1, n2;

            //Si num2 es mayor
            if (num1.longitud < num2.longitud)
            {
                //Comprobar la diferencia entre num2 y num1
                int dif = num2.longitud - num1.longitud;
                //Ahora num1 lo hacemos del mismo tamaño
                for (int i = 0; i < dif; i++)
                {
                    num1.numero = "0" + num1.numero;
                }
                //Ahora están del mismo tamaño y tengo que sumarlos
                int sumanum = 0;
                for (int i = num2.longitud - 1; i > 1; i--)
                {
                    n1 = int.Parse(num1.numero[i].ToString());
                    n2 = int.Parse(num2.numero[i].ToString());
                    sumanum = sumanum + n1 + n2;
                }
                string suma = sumanum.ToString();
                enteroLargo C = new enteroLargo(suma);
                return C;
            }
            //Si num1 es mayor
            else
            {
                int dif = num1.longitud - num2.longitud;
                //Ahora num1 lo hacemos del mismo tamaño
                for (int i = 0; i < dif; i++)
                {
                    num2.numero = "0" + num2.numero;
                }
                //Ahora están del mismo tamaño y tengo que sumarlos
                int sumanum = 0;
                for (int i = num2.longitud - 1; i > 1; i--)
                {
                    n1 = int.Parse(num1.numero[i].ToString());
                    n2 = int.Parse(num2.numero[i].ToString());
                    sumanum = sumanum + n1 + n2;
                }
                string suma = sumanum.ToString();
                enteroLargo C = new enteroLargo(suma);
                return C;
            }
        }
    }
}