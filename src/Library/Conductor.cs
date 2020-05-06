
namespace Herencia_Ejercicio.Library
{
    public class Conductor : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Calificacion { get; set; }        
        public string Bio { get; set; }

        public Conductor(string nombre, string apellido, string cedula, int calificacion , string  bio)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Bio = bio;
        }

        void CalificarViaje(int calificacion, Pasajero pasajero)
        {
            pasajero.Calificacion += calificacion;

        }
        
        public virtual string ImprimeDatos()
        {
            return $" Nuevo registro de Conductor:  {this.Nombre} {this.Apellido} \n bio : {this.Bio}";

        }

    }
}