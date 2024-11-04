using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.Json;
using System.Xml.Serialization;
using System.IO.Enumeration;
using System.Runtime.InteropServices;
namespace _321_serial_ex2_nima_zarrabi
{
    public class Program
    {
        static string path = "./data/";
        public static List<Episode> episodeList = new List<Episode>();
        public static List<Character> charList = new List<Character>();
        public static List<Actor> actList = new List<Actor>();
        public static void Main()
        {
            /// ADD INFO TO ACTLIST
            actList.Add(new Actor() { FirstName = "Freddy", LastName = "Dull", Description = "Freddy Dull est un personnage de fond qui n'est que présent pour un gag ou il tombe d'un escalier dans l'époside 4" });

            charList.Add(new Character() { FirstName = "Freddy", LastName = "Dull", Description = "Freddy Dull est un personnage de fond qui n'est que présent pour un gag ou il tombe d'un escalier dans l'époside 4" });

            episodeList.Add(new Episode() {Title = "L'attaque spacial", DurationMinute = 23, SequenceNumber = 15, Director = "Terry", Synopsis = "Gérard se promène tranquillement près de ces ruches quand soudain, une météorite attèrrit en plein sur une des ruches, ce qui crée des abeilles alien mutantes, comment Gérard et Maya vont-ils régler cette menace imminente sur l'école et leurs apiculture?", Characters = charList);

            //charList.Add(new Character("Freddy", "Dull", "Freddy Dull est un personnage de fond qui n'est que présent pour un gag ou il tombe d'un escalier dans l'époside 4", null));

            foreach (string file in (Directory.GetFiles(path)))
            {
                ReadFile(file);
            }

            foreach (Episode episode in episodeList)
            {
                string jsonString = JsonSerializer.Serialize(episode);

                Console.WriteLine();
                Console.WriteLine(jsonString);

                string fileName = episode.Title + "_" + episode.SequenceNumber + ".json";

                SaveFile(path + fileName, jsonString);
            }

        }

        public static void SaveFile(string Filename, string jsonString)
        {
            File.WriteAllText(Filename, jsonString);
        }

        public static void ReadFile(string Filename)
        {
            string jsonString = File.ReadAllText(Filename);
            episodeList.Add(JsonSerializer.Deserialize<Episode>(jsonString)!);
        }
    }
}