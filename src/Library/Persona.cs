using System;

namespace Herencia_Ejercicio.Library
{
    /*
        Se Crea Clase abstracta Persona, la utilizamos como punto de partida para luego implementar Pasajero y
        Conductor (Ambos comparten que son Personas)
        
    */
    public abstract class Persona 
    {
        protected string Nombre { get; set; }
        protected string Apellido { get; set; }
        protected string Cedula { get; set; }
       protected int Calificacion { get; set; }
        public string Foto { get; set; }
         public abstract string ImprimeDatos();

    }
}