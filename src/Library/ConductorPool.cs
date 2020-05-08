namespace Herencia_Ejercicio.Library
{
    /*
        Se Crea Clase que hereda de Condutor, la diferencia de esta clase con la supoerclase es que 
        utiliza un valor de Capacidad
    */
    public class ConductorPool : Conductor
    {
        private int capacidad;
        public ConductorPool (string nombre, string apellido, string cedula, int calificacion, string foto, string bio, int capacidad) : base (nombre, apellido, cedula, calificacion, foto, bio)

        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto = foto;
            this.Bio = bio;
            this.Capacidad = capacidad;
        }

        public int Capacidad
        {
            get
            {
                return capacidad;
            }
            set
            {
                capacidad = value;
            }
        }

        // Sobrecargamos el metodo de Persona
        public override string ImprimeDatos ()
        {
            return $"Bienvenido {this.Nombre}, El nuevo Conductor Pool de UCURide que llevara hasta {this.Capacidad} Pasajeros!. \n Bio:  {this.Bio}";

        }

    }
}