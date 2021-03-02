using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    //8.	Crear un programa que defina un array de 5 elementos de tipo float que representen las alturas de 5 personas. Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.

    float[] altura = new float[5];
    float prom;

    for (int alt = 0; alt < 5; alt++)
    {
      Console.Write("Ingrese la altura de la persona: " + (alt + 1) + ": ");
      string line = Console.ReadLine();
      altura[alt] = float.Parse(line);
    }

    float suma;
    suma = 0;

    for (int alt = 0; alt < 5; alt++)
    {
      suma += altura[alt];
    }

    prom = suma / 5;

    Console.WriteLine("\nPromedio de las alturas ingresadas es: {0}",prom);

    int cont = 0;
    int cont1 = 0;

    for (int c = 0; c < altura.Length; c++)
    {
      if (altura[c]<prom)
      {
        cont ++;
      }
      else
      {
        cont1 ++;
      }

    } 

    Console.Write("\nHay {0} alturas menores al promedio \n", cont);

    Console.Write("\nHay {0} alturas mayores al promedio \n", cont1);

  }
}