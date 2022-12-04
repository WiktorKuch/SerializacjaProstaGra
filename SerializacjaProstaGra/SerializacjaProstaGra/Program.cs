using System;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace SerializacjaProstaGra
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var player = new Player() { 
            
                Name = "Mario",
                Level = 1,
                HealthPoints = 100,
                Statistics = new List<Statistic>()
                { 
                    new Statistic()
                    {
                        Name = "Strength",
                        Points = 10
                    },
                    new Statistic()
                    {
                        Name = "Inteligence",
                        Points = 10
                    }

                }

            };

            player.Level++;

                                        //  Serializacja 

            var playerSerialized=JsonConvert.SerializeObject(player); //serializuje wartość do string

            File.WriteAllText(@"C:\Users\Wiktro Kucharek\append\playerSerialized.json", playerSerialized);//zapisuje z-serializowaną wartość do pliku
            

                                        // Deserializacja

            string deserializedPlayer = File.ReadAllText(@"C:\Users\Wiktro Kucharek\append\playerSerialized.json");  //deserializowana wartość z pliku przypisana do string
            Player deserPlayer = JsonConvert.DeserializeObject<Player>(deserializedPlayer); //z-deserializowana wartość na obiekt player 

            Console.WriteLine(deserPlayer.Name); // wyświetla imie gracza z pliku 

        }
    }
}