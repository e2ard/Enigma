using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.App;

namespace Enigma.App
{
    class EnigmaMachine
    {
        EnigmaUtilities utls;

        public EnigmaMachine()
        {
            EnigmaParams ep = InOutControl.GetEnigmaParams();
            utls = new EnigmaUtilities(ep.R1, ep.R2, ep.R3);
        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("ENIGMA MACHINE RUN");
                string input = Console.ReadLine();
                string s1 = utls.r1.GetValue(input);
                string s2 = utls.r2.GetValue(s1);
                string s3 = utls.r3.GetValue(s2);

                string r = utls.r.GetValue(s3);

                string si3 = utls.r3.GetValue(r);
                string si2 = utls.r2.GetValue(si3);
                string si1 = utls.r1.GetValue(si2);

                Console.WriteLine(si1);
                //Console.WriteLine(utls.r2.GetValue("A"));
                //Console.WriteLine(utls.r3.GetValue("A"));
                utls.Step();
            }
            
            Console.WriteLine("ENIGMA MACHINE RUN r1: " + utls.r1.CurrentStep);
            Console.WriteLine("ENIGMA MACHINE RUN r2: " + utls.r2.CurrentStep);
            Console.WriteLine("ENIGMA MACHINE RUN r3: " + utls.r3.CurrentStep);

            Console.WriteLine("ENIGMA MACHINE RUN FINISHED");
            Console.ReadLine();
        }
    }
}
