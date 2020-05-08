using System;
using System.Collections.Generic;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    class Program
    {
        static void Main (string[] args)
        {
            Persona pasajeroReal = new Pasajero ("Sylvester", "Stallone", "42169107", 0, @"Sylvester.jpg");
            Persona pasajeroFalso = new Pasajero ("Yate", "Rodriguez", "42169107", 0, @"yacht.jpg");
            Persona conductorFeliz = new Conductor ("Sylvester", "Stallone", "42169107", 0, @"SylvesterFeliz.jpg", "Muchos viajes con muy buenas referencias");
            Persona conductorSerio = new Conductor ("Silvester", "Stallone", "42169107", 0, @"Sylvester.jpg", "Muchos viajes con muy buenas referencias");
            Persona conductorPool1 = new ConductorPool ("Jack", "Nicholson", "42169107", 0, @"Jack.jpg", "Maneja con mucha cautela",3 );
            

            Registro<Persona> registro = new Registro<Persona> ();

            registro.Add (pasajeroReal);
            registro.Add (pasajeroFalso);
            registro.Add (conductorFeliz);
            registro.Add (conductorSerio);
            registro.Add (conductorPool1);
            
        }
    }
}