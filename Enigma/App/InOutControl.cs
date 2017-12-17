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
        StreamReader InFile;
        StreamWriter OutFile;
        StreamReader ConfigFile;
        public InOutControl()
        {
            InFile = new StreamReader(Program.IN_FILE_NAME);
            //OutFile = new StreamWriter(OUT_FILE_NAME);
        }

        public EnigmaParams GetEnigmaParams()
        {
            ConfigFile = new StreamReader(Program.CONFIG_FILE);
            string paramLine = ConfigFile.ReadLine();
            string [] param = paramLine.Split(' ');
            return new EnigmaParams(Convert.ToInt32(param[0]), Convert.ToInt32(param[1]), Convert.ToInt32(param[2]));
        }

        public string GetEncrypted()
        {
            StreamReader fileRead = new StreamReader(Program.OUT_FILE_NAME);
            return fileRead.ReadLine();
        }

        public string GetDecrypted()
        {
            StreamReader fileRead = new StreamReader(Program.IN_FILE_NAME);
            return fileRead.ReadLine();
        }

        public string ReadLine()
        {
            return InFile.ReadLine();
        }
        public void WriteToFile(string line)
        {
            File.AppendAllText(Program.OUT_FILE_NAME, line);
            //using (OutFile)
            //{
            //    OutFile.ap.WriteLine(line);
            //}
        }
    }
}
