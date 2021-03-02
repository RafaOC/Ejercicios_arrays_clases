using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //7.	Un programa que te pida tu nombre y lo muestre en pantalla separando cada letra de la siguiente con un espacio. Por ejemplo, si tu nombre es "Moreta", debería aparecer en pantalla "M o r e t a".

    string nombre;

    Console.WriteLine("\nIngrese su nombre\n");
    
    nombre = Console.ReadLine();

    Console.Clear();

    for (int i = 0; i < nombre.Length; i++)
    {
      Console.Write(nombre[i]+ " ");
    }

  }
}