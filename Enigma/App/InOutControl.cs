using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class InOutControl
    {
        private string IN_FILE_NAME = "C://Users//Edvard//Documents//Visual Studio 2015//Projects//Enigma//Enigma//AppFiles//ToEncrypt.txt";
        private string OUT_FILE_NAME = "C://Users//Edvard//Documents//Visual Studio 2015//Projects//Enigma//Enigma//AppFiles//EncryptedText.txt";
        StreamReader sr;
        StreamWriter outputFile;
        public InOutControl()
        {
            sr = new StreamReader(IN_FILE_NAME);
            //outputFile = new StreamWriter(OUT_FILE_NAME);
        }

        public static EnigmaParams GetEnigmaParams(string fileName = "")
        {
            return new EnigmaParams(0,0,0);
        }

        public string ReadLine()
        {
            return sr.ReadLine();
        }
        public void WriteToFile(string line)
        {
            File.AppendAllText(OUT_FILE_NAME, line);
            //using (outputFile)
            //{
            //    outputFile.ap.WriteLine(line);
            //}
        }
    }
}
