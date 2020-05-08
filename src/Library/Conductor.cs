
namespace Herencia_Ejercicio.Library
{
    public class Conductor : Persona
    {
        public string Bio { get; set; }

        public Conductor(string nombre, string apellido, string cedula, int calificacion ,string foto, string  bio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto= foto;
            this.Bio = bio;
        }
        
        public override string ImprimeDatos()
        {
            return $"Bienvenido {this.Nombre}, El nuevo Conductor de UCURide! \n Bio: : {this.Bio}";

        }

    }
}