using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class EnigmaUtilities
    {
        public Rotor r1, r2, r3, r;

        public EnigmaUtilities(int ir1, int ir2, int ir3)
        {
            InitiateMachine(ir1, ir2, ir3);
        }
        public void InitiateMachine(int ir1, int ir2, int ir3)
        {
            r1 = new Rotor(ir1);
            r2 = new Rotor(ir2);
            r3 = new Rotor(ir3);
            r = new Rotor(2);
        }

        public void Step()
        {
            Console.WriteLine("ENIGMA MACHINE STEP");
            r1.Rotate();
            if (r1.CurrentStep == Program.CHAR_NUM - 1)
                r2.Rotate();
            if (r2.CurrentStep == Program.CHAR_NUM - 1)
                r3.Rotate();
        }
    }
}
