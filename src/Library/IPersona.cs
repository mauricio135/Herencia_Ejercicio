using System;

namespace Herencia_Ejercicio.Library
{
    public interface IPersona 
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string Cedula { get; set; }
        int Calificacion { get; set; }

    }
}