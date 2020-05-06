namespace Herencia_Ejercicio.Library
{
    public class Pasajero : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cedula { get; set; }
        public int Calificacion { get; set; }
         public Pasajero(string nombre, string apellido, string cedula , int calificacion )
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
        }
        
        void CalificarViaje(int calificacion, Conductor conductor)
        {
            conductor.Calificacion += calificacion;

        }
    }
}