using System;
using System.Collections;
using TwitterUCU;

namespace Herencia_Ejercicio.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!
*/          
            IPersona pasajero1 = new Pasajero("Levi","de los Santos","42169107",0);
            IPersona conductor1 = new Conductor("Scooby","Do","42169107",0,"Muchos viajes con buenas referencias");
            ConductorPool conductorPool1 = new ConductorPool("Scooby","Do","42169107",0,"Muchos viajes con buenas referencias");
            conductorPool1.Capacidad = 5;
           // Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)

          //  Registro rideShare = new Registro<pasajero1>;
            
           // rideShare.Add(conductor1);
           // Se publica en Twitter un nuevo conductor!


            string consumerKey = "g7rkPB5uI2xOqELAhlNrorSU4";
            string consumerKeySecret = "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc";
            string accessTokenSecret = "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe";
            string accessToken = "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E";
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter(conductorPool1.ImprimeDatos(), @"scooby.jfif"));
            var twitterDirectMessage = new TwitterMessage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitterDirectMessage.SendMessage("Hola!", "380889967"));

            /*
                        rideShare.Add(conductorPool1)
                        Se publica en Twitter un nuevo conductor!

                        rideShare.Add(pasajero1)
                        Se publica en Twitter nuevo registro de pasajero!

                        rideShare.Add(pasajero2)
                        Se publica en Twitter nuevo registro de pasajero!

                        rideShare.Add(pasajero3)
                        Se publica en Twitter nuevo registro de pasajero!

                        */
        }
    }
}
