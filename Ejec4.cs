using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //4. Un programa que pida al usuario 10 números y luego calcule y muestre cuál es el mayor de todos ellos.

    float[] num = new float[10];
    float mayor = 0, menor = 0;
    int none = 0;

    Console.WriteLine("\nIngrese 10 número: \n");

    for (int i = 0; i < 10; i++)
    {
      num[i] = float.Parse(Console.ReadLine());

     if (none == 0)
     {
       mayor = num[i];
       menor = num[i];
       none = 1;
     }
     else if (num[i] > mayor)
     {
       mayor = num[i];             
     }
    }     

    Console.Write("\nEl mayor de los 10 números es el {0}", mayor);

  }
}