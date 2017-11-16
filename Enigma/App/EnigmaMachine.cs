using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.App;
using System.Diagnostics;
using System.IO;

namespace Enigma.App
{
    class EnigmaMachine
    {
        EnigmaUtilities utls;
        InOutControl io;
        
        public EnigmaMachine()
        {
            EnigmaParams ep = InOutControl.GetEnigmaParams();
            utls = new EnigmaUtilities(ep.R1, ep.R2, ep.R3);
            io = new InOutControl();
        }

        public string GetTextToEncrypt()
        {
            return io.ReadLine();
        }
        public void Run()
        {
            string encryptedChar;
            string lineToEncrypt;

            while ((lineToEncrypt = GetTextToEncrypt()) != null)
            {
                for (int i = 0; i < lineToEncrypt.Length; i++)
                {
                    Debug.WriteLine("ENIGMA MACHINE RUN");
                    string toEncrypt = lineToEncrypt[i].ToString();
                    encryptedChar = Encrypt(toEncrypt);
                    if (encryptedChar.Equals(toEncrypt))
                        break;
                    io.WriteToFile(encryptedChar);
                    Console.Write(encryptedChar);
                }
            }

            Debug.WriteLine("ENIGMA MACHINE RUN FINISHED r1: {0} r2: {1} r3: {2}", utls.r1.CurrentStep, utls.r2.CurrentStep, utls.r3.CurrentStep);
            Console.ReadLine();
        }

        private string Encrypt(string input)
        {
            string s1 = utls.r1.GetValueForward(input);
            string s2 = utls.r2.GetValueForward(s1);
            string s3 = utls.r3.GetValueForward(s2);

            string r = utls.r.GetValueForward(s3);
            
            string si3 = utls.r3.GetValueBackward(r);
            string si2 = utls.r2.GetValueBackward(si3);
            string si1 = utls.r1.GetValueBackward(si2);
            utls.Step();

            return si1;
        }
    }
}
