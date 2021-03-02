using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
/*2.	Un programa que pida al usuario 5 números reales (pista: necesitarás un array de "float") 
       y luego los muestre en el orden contrario al que se introdujeron.*/

   float [] real = new float[5];
    
    for(int i=0;i<real.Length; i++)
    {
     Console.WriteLine("introduzca un numero ");
     real [i] = Convert.ToInt32(Console.ReadLine());
    }

   Console.Write("\n");
 
   Console.WriteLine("Numeros inverso: ");

   Console.Write("\n");

     int r= 4;

     while (r >= 0)
     {
       //Console.WriteLine("("+real[r]+")\n");
       Console.WriteLine("({0})\n", real[r]);
       r--;
     }
  }
}