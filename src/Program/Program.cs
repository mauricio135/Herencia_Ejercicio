using System;
using System.Collections.Generic;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    class Program
    {
        static void Main (string[] args)
        {
            Persona pasajeroSerio = new Pasajero ("Sylvester", "Stallone", "42169107", 0, @"Sylvester.jpg");
            Persona pasajeroSonriente = new Pasajero ("Sylvester", "Stallone", "42169107", 0, @"SylvesterFeliz.jpg");
            Persona conductor = new Conductor ("Scooby", "Do", "42169107", 0, @"bill2.jpg", "Muchos viajes con muy buenas referencias");
            Persona conductorPool1 = new ConductorPool ("Jack", "Nicholson", "42169107", 0, @"Jack.jpg", "Maneja con mucha cautela",3 );
            Persona pasajeroFalso = new Pasajero ("Yate", "Rodriguez", "42169107", 0, @"yacht.jpg");

            Registro<Persona> registro = new Registro<Persona> ();

            registro.Add (pasajeroSerio);
            registro.Add (pasajeroSonriente);
            registro.Add (conductor);
            registro.Add (conductorPool1);
            registro.Add (pasajeroFalso);
        }
    }
}