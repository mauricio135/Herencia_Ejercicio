namespace Herencia_Ejercicio.Library
{
    /*
        Se Crea Clase que hereda de Persona, la diferencia de esta clase con la supoerclase es que 
        que tiene Bio.
    */
    public class Conductor : Persona
    {
        public string Bio
        {
            get;
            set;
        }

        public Conductor (string nombre, string apellido, string cedula, int calificacion, string foto, string bio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto = foto;
            this.Bio = bio;
        }

        // Sobrecargamos el metdoo de Persona        
        public override string ImprimeDatos ()
        {
            return $"Bienvenido {this.Nombre}, El nuevo Conductor de UCURide! \n Bio: {this.Bio}";

        }

    }
}