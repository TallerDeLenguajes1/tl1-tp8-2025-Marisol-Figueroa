using System;
using System.Collections.Generic;
using System.Linq;

public class Tarea {
 public int TareaID { get; set; }
 public string Descripcion { get; set; }
 public int Duracion  { get; set; } // Validar que esté entre 10 y 100
 // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario


 public Tarea(int tareaID,string descripcion,int duracion)
 {
    TareaID = tareaID;
    Descripcion = descripcion;
    Duracion= duracion;
    if (duracion >= 10 && duracion <= 100)
    {
        Duracion=duracion;
    }
    else
    {
        Console.WriteLine("La duracion debe estar entre 10 y 100");
    }
 }

 public void MostrarInformacion()
 {
    Console.WriteLine($"Nombre tarea: {TareaID}");
    Console.WriteLine($"Descripcion: {Descripcion}");
    Console.WriteLine($"Duracion: {Duracion}");
 }
}
