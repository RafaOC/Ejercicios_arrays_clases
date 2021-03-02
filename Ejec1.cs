using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //1.	Un programa que pida al usuario 4 números, los memorice (utilizando un array), calcule su media aritmética y después muestre en pantalla la media y los datos tecleados.
    
    double [] num = new double [4];
    double suma = 0;
    double media;

    for(int c=0; c<4; c++)
    {
      Console.WriteLine("Introduce el valor en la posicion {0}: ", c);
      num [c] = double.Parse(Console.ReadLine()); 
      suma += num [c];
    }

    media = suma / 4;

    Console.Write("\nUsted acaba de introducir los siguientes numeros: ");

    for(int c=0; c<4; c++)
    {

    Console.Write("({0}), ", num[c]); 

    }
    Console.Write("Y la media aritmetica es: {0}", media);
   }
}