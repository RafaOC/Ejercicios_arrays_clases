using System;

class MainClass 
{
  public void Persona()
  {
    string nombre = "";
    int edad = 0;

    Console.WriteLine("Introduzca su nombre: ");
    nombre = Console.ReadLine();
    Console.WriteLine("Introduzca su edad: ");
    edad = int.Parse(Console.ReadLine());

    if (edad >= 18)
    {
      Console.WriteLine("La persona {0}, tiene {1} años y es mayor de edad.", nombre,edad);
    }
    else
    {
      Console.WriteLine("La persona {0}, tiene {1} años y es menor de edad.", nombre,edad);
    }
  }

  public static void Main (string[] args) 
  {
    //10.	Confeccionar una clase que permita carga el nombre y la edad de una persona. Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18).

    MainClass Person = new MainClass();
    Person.Persona();
  }
}