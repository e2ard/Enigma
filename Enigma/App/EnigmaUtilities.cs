using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class EnigmaUtilities
    {
        public Rotor r1, r2, r3;
        public Reflector r;
        List<string> CharsR1 = new List<string> { "C", "A", "B", "E", "D" };
        List<string> CharsR2 = new List<string> { "B", "E", "C", "A", "D" };
        List<string> CharsR3 = new List<string> { "A", "D", "B", "E", "C" };
        List<string> CharsR = new List<string> { "D", "C", "A", "E", "B" };
        public EnigmaUtilities(int ir1, int ir2, int ir3)
        {
            InitiateMachine(ir1, ir2, ir3);
        }
        public void InitiateMachine(int ir1, int ir2, int ir3)
        {
            r1 = new Rotor(ir1, CharsR1);
            r2 = new Rotor(ir2, CharsR2);
            r3 = new Rotor(ir3, CharsR3);
            r = new Reflector(2, CharsR);
        }

        public void Step()
        {
            Debug.WriteLine("ENIGMA MACHINE STEP");
            //r1.Rotate();
            r1.ShiftRight();
            if (r1.CurrentStep == Program.CHAR_NUM - 1)
                r2.ShiftRight();
            if (r2.CurrentStep == Program.CHAR_NUM - 1)
                r3.ShiftRight();
        }
    }
}
