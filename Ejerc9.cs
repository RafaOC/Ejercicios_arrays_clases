using System;

namespace ejerc_9
{
    class Program
    {
        public void almacen()
        {
            int num ;

            do
            {
                Console.WriteLine("Ingresa un numero para generar su tabla de Multiplicar:");
                num = Convert.ToInt32(Console.ReadLine());

                if (num != -1)
                {
                    ProcTablaMultiplicar(num);
                }

            } while (num != -1);
        }

        public void ProcTablaMultiplicar(int x)
        {
            for (int i = 0; i <= 12; i++) 
            {
                Console.WriteLine("{0} x {1} = {2}", x, i, (x*i)); 
            }
        }

        public static void Main(String[] ar)
        {
            /*9. Crear una clase que permita ingresar valores enteros por teclado 
            y nos muestre la tabla de multiplicar de dicho valor. Finalizar el 
            programa al ingresar el -1.*/

            Program tb;
            tb = new Program();
            tb.almacen();
        }
    }
}
