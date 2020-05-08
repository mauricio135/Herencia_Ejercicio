using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using CognitiveCoreUCU;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    public class Registro<T> where T : Persona
    {
        string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
        string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
        string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
        string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
        string cognitiveKey = "620e818a46524ceb92628cde08068242";

        private IList registros = new ArrayList ();

        public void Add (T item)

        {
            registros.Add (item);

            CognitiveFace cog = new CognitiveFace (cognitiveKey, true, Color.GreenYellow);
            cog.Recognize (item.Foto);

            if (item.GetType ().Equals (typeof (Pasajero)) && (cog.FaceFound) )

            {
                var twitter = new TwitterImage (consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
                Console.WriteLine (twitter.PublishToTwitter (item.ImprimeDatos (), item.Foto));
                Console.WriteLine ("Encuentra Cara de Persona con Sonrirsa y se manda a Twitter");

            }
            else if (item.GetType ().Equals (typeof (Conductor)) || (item.GetType ().Equals (typeof (ConductorPool))) &&
                (cog.FaceFound && cog.SmileFound))
            {
                var twitter = new TwitterImage (consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
                Console.WriteLine (twitter.PublishToTwitter (item.ImprimeDatos (), item.Foto));
                Console.WriteLine ("Se encuentra cara de Conductor y se publica en Twitter");

            }
            else
            {
                Console.WriteLine ("No Se publica en Twitter nuevo registro por no cumplir las condiciones!");
            }

        }

    }
}