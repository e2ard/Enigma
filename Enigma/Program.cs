using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.App;
namespace Enigma
{
    class Program
    {
        public static string IN_FILE_NAME = "C://Users//Edvard//Documents//Visual Studio 2015//Projects//Enigma//Enigma//AppFiles//ToEncrypt.txt";
        public static string OUT_FILE_NAME = "C://Users//Edvard//Documents//Visual Studio 2015//Projects//Enigma//Enigma//AppFiles//EncryptedText.txt";
        public static string CONFIG_FILE = "C://Users//Edvard//Documents//Visual Studio 2015//Projects//Enigma//Enigma//AppFiles//Config.txt";
        public static List<string>  Alphabet = new List<string>{ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };
        public static int CHAR_NUM = Alphabet.Count;

        static void Main(string[] args)
        {
            EnigmaMachine em = new EnigmaMachine();
            em.Run();
            Bombe b = new Bombe();
            b.Run();
        }
    }
}
