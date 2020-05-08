namespace Herencia_Ejercicio.Library
{
    public class Pasajero : Persona
    {

        public Pasajero (string nombre, string apellido, string cedula, int calificacion, string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto = foto;
        }

        public override string ImprimeDatos ()
        {
            return $" Bienvenido {this.Nombre}! nuevo Usuario de UCURide ";

        }

    }
}