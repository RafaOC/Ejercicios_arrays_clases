using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //3.	Un programa que almacene en un array el número de días que tiene cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que tiene ese mes.
    
    int [] dias = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    string [] mes = {"", "Enero", "Febrero", "Marzo", "Abril","Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

    int M;

    Console.WriteLine("Introduce un numero en representacion de un mes del año");
    M = int.Parse(Console.ReadLine());

    if (M>0 && M<=12)
    {
      Console.WriteLine("{0} tiene {1} dias.", mes[M] ,dias[M]);  
    }
    else
    {
      Console.WriteLine("Este mes no existe.");
    }
  }
}