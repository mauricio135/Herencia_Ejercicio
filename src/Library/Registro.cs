using System;
using System.Collections;
using System.Drawing;
using CognitiveCoreUCU;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    /*
        Se Crea Clase REgistro donde se agregan las Personas y los Conductores.
        Haciendo uso de ContenedoreRegistros y asi almacenar distintos tipos alli.       
        
    */
    public class Registro<Persona> : IEnumerable

    {
        #region Credenciales
        string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
        string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
        static string cognitiveKey = "620e818a46524ceb92628cde08068242";

        #endregion

        private ContenedorRegistros<Pasajero> pasajeros = new ContenedorRegistros<Pasajero> ();
        private ContenedorRegistros<Conductor> conductores = new ContenedorRegistros<Conductor> ();

        // Se aplica Creator , decidimos crear la instancia de CognitiveFace  aqui
        CognitiveFace cog = new CognitiveFace (cognitiveKey, true, Color.GreenYellow);

        //  Se utiliza Sobrecarga (Tiene dos metodos Add con diferente firma).

        public void Add (Conductor conductor)
        {
            conductores.Add (conductor);
            cog.Recognize (conductor.Foto);
            if (cog.FaceFound && cog.SmileFound)
            {
                // Se aplica Creator , decidimos crear la instancia de TwitterImage aqui
                var twitter = new TwitterImage (consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
                Console.WriteLine (twitter.PublishToTwitter (conductor.ImprimeDatos (), conductor.Foto));
                Console.WriteLine ("Se encuentra cara con Sonrisa de Conductor y se publica en Twitter");

            }
            else
            {
                Console.WriteLine ($"No cumple los requisitos para enviar Registro a Twitter");

            }
        }

        public void Add (Pasajero pasajero)
        {
            pasajeros.Add (pasajero);
            cog.Recognize (pasajero.Foto);

            if (pasajero.GetType ().Equals (typeof (Pasajero)) && (cog.FaceFound))

            {
                var twitter = new TwitterImage (consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
                Console.WriteLine (twitter.PublishToTwitter (pasajero.ImprimeDatos (), pasajero.Foto));
                Console.WriteLine ("Encuentra Cara de Persona y se manda a Twitter");

            }
            else
            {
                Console.WriteLine ($"No cumple los requisitos para enviar Registro a Twitter");

            }
        }
        public IEnumerator GetEnumerator ()
        {
            return this.pasajeros.GetEnumerator ();
        }

    }

}