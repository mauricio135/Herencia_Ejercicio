using System;
using System.Collections.Generic;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    class Program
    {
        static void Main (string[] args)
        {
            //Se instancian los diferentes tipos de Personas : Pasajero , Conductor y conductorPool 
            Pasajero pasajeroReal = new Pasajero ("Sylvester", "Stallone", "42169107", 0, @"Sylvester.jpg");
            Pasajero pasajeroFalso = new Pasajero ("Yate", "Rodriguez", "42169107", 0, @"yacht.jpg");
            Conductor conductorFeliz = new Conductor ("Sylvester", "Stallone", "42169107", 0, @"SylvesterFeliz.jpg", "Muchos viajes con muy buenas referencias");
            Conductor conductorSerio = new Conductor ("Silvester", "Stallone", "42169107", 0, @"Sylvester.jpg", "Muchos viajes con muy buenas referencias");
            ConductorPool conductorPool1 = new ConductorPool ("Jack", "Nicholson", "42169107", 0, @"Jack.jpg", "Maneja con mucha cautela",3 );
            
            //Se crea instancia de registro que es donde se accionan los envios a Twitter al momento 
            //que se agregan a la lista
            Registro<Persona> registro = new Registro<Persona> ();

            //Se agregan las Personas que se crearon anteriormente  a la lilsta de Registros
            registro.Add(pasajeroReal);
            registro.Add(pasajeroFalso);
            registro.Add (conductorFeliz);
            registro.Add (conductorSerio);
            registro.Add (conductorPool1);
            
        }
    }
}