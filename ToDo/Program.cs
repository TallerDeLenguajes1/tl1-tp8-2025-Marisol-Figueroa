// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
   List<Tarea> tareasPendientes= new List<Tarea>();
   List<Tarea> tareasRealizdas= new List<Tarea>();


 static void Main(string[] args)
 {

   while (true)
   {
     Console.WriteLine("Menu principal");
     Console.WriteLine("1.Mover tarea pendiente a tareas realizdas");
     Console.WriteLine("2.Buscar tarea pendiente por descripcion");
     Console.WriteLine("3.Mostrar todas las tareas");
     Console.WriteLine("4.SALIR");
     Console.WriteLine("Ingrese la opcion");
      string? opcion = Console.ReadLine();

    switch(opcion)
    {
        case "1":
        MoverTareaPendieteAReaizdas();
        break;
        case "2":
        BuscarTareaPendietePorDescripcion();
        break;
        case "3":
        MostrarTodasLasTareas();
        break;
        case "4":
        return;
        default:
        Console.WriteLine("Opcion Invalida");
        break;

    }
   }
 }
 static void MoverTareaPendieteAReaizdas()
  {
    
  }

   static void BuscarTareaPendietePorDescripcion()
  {
  }

   static void MostrarTodasLasTareas()
  {
    
  }
}


