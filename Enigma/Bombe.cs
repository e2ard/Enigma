using Enigma.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma
{
    public class Bombe
    {
        public void Run()
        {
            InOutControl io = new InOutControl();
            string encrypted = io.GetEncrypted();
            string decrypted = io.GetDecrypted();

            CheckCrib(encrypted, decrypted);
        }

        public void CheckCrib(string stringToCheck, string crib)
        {
            if(stringToCheck.Length != crib.Length)
            {
                Console.Write("Lenghts are not equal");
                return;
            }

            bool cribFound = false;
            for (int r1 = 0; r1 <= Program.CHAR_NUM /*&& !cribFound*/; r1++)
            {
                for (int r2 = 0; r2 <= Program.CHAR_NUM/* && !cribFound*/; r2++)
                {
                    for (int r3 = 0; r3 <= Program.CHAR_NUM /*&& !cribFound*/; r3++)
                    {
                        cribFound = StartEnigmaAt(r1, r2, r3, stringToCheck, crib);
                        if(cribFound)
                            Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }

        public bool StartEnigmaAt(int r1, int r2, int r3, string stringToCheck, string crib)
        {
            EnigmaMachine em = new EnigmaMachine();
            em.SetRotorValues(r1, r2, r3);
            bool cribFound = false;
            for (int i = 0; i < stringToCheck.Length; i++)
            {
                string stringChar = stringToCheck.ElementAt(i).ToString();
                string cribChar = crib.ElementAt(i).ToString();
                string encryptedChar = em.Encrypt(stringChar);

                if (!encryptedChar.Equals(cribChar))
                {
                    //Console.WriteLine("Skip, wrong params");
                    break;
                }
                cribFound = stringToCheck.Length == i + 1;
            }

            if (cribFound)
            {
                Console.WriteLine("Found " + r1 + " " + r2 + " " + r3);
                return true;
            }

            //Console.WriteLine("Not found ");
            return false;
        }
    }
}
