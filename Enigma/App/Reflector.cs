using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class Reflector : Rotor
    {
        public Reflector(int step, List<string> chars) : base(step, chars)
        {

        }

        public string GetValueForward(string value)
        {
            int iValue = Alphabet.IndexOf(value);
            //Debug.WriteLine("ROTOR GETVALUE " + value + "->"+ Chars[(CurrentStep + iValue) % Program.CHAR_NUM]);
            return Chars[(iValue) % Program.CHAR_NUM];
        }
    }
}
