namespace Library
{
    public class Pasajero : IPersona
    {
         public Pasajero(string nombre, string apellido, int cedula , int calificacion )
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