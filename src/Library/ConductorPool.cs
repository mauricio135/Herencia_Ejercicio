
namespace Herencia_Ejercicio.Library
{
    public class ConductorPool : Conductor
    {
        
        public ConductorPool (string nombre, string apellido, string cedula, int calificacion , string  bio)
        : base(nombre,apellido,cedula,calificacion,bio)
        {}
         private int capacidad; 

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
         
        public  override string ImprimeDatos()
        {
            return $" Nuevo registro de Conductor Pool :  {this.Nombre} {this.Apellido} \n Acepta {this.Capacidad} personas y su Bio es la Siguiente: {this.Bio}";


        }

    }
}
