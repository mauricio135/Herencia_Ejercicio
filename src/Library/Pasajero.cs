namespace Herencia_Ejercicio.Library
{
    public class Pasajero : Persona
    {
    /*
        Se Crea Clase que hereda de Persona y no requiere ningun dato adicional.
    */

        public Pasajero (string nombre, string apellido, string cedula, int calificacion, string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto = foto;
        }

// Sobrecargamos el metdoo de Persona
        public override string ImprimeDatos ()
        {
            return $" Bienvenido {this.Nombre}! nuevo Usuario de UCURide ";

        }

    }
}