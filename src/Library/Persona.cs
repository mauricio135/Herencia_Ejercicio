using System;

namespace Herencia_Ejercicio.Library
{
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