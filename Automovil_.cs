// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;

public class Auto
{
     public string modelo;
     public string marca;
     public int año;
     public List<string> HistoriaDeReparaciones = new List<string>();

     public void Reparar()
     {
         Console.WriteLine("Reparando el vehículo");
     }

     public void MostrarHistoriaDeReparaciones()
     {
         foreach (var reparacion in HistoriaDeReparaciones)
         {
             Console.WriteLine(reparacion);
         }
     }
}

public class BMW : Auto
{
     public override void Reparar()
     {
         base.Reparar();

         HistoriaDeReparaciones.Add("Reparación realizada el " + DateTime.Now);
         File.AppendAllText("log.txt", "Reparación realizada el " + DateTime.Now + Environment.NewLine);
     }
}