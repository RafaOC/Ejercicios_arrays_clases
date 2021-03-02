using System;

class MainClass 
{
  public static void Main (string[] args) 
  {
    /*5.	Un programa que prepare espacio para un máximo de 100 nombres. El usuario deberá ir 
    introduciendo un nombre cada vez, hasta que se pulse Intro sin teclear nada, momento en el que 
    dejarán de pedirse más nombres y se mostrará en pantalla la lista de los nombres que se han introducido.*/

    Console.WriteLine("Introduca los nombres que desee teniendo en cuenta que al introducir la tecla 'INTRO' terminara el programa.\n");

    string [] nombres = new string [100];
  
    for (int i = 0; i < 100; i++)
    {
      nombres [i]= Console.ReadLine();

      if (nombres [i] == "")
      {
        break;
      }

    }

    Console.WriteLine("Lista de los nombres: \n");

    for(int list=0; list<100; list++)
    {
      Console.WriteLine(nombres[list]);

      if (nombres [list] == "")
      {
        break;
      } 

    }
    
  }
}