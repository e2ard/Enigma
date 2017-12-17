using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class Rotor
    {
        public int CurrentStep;
        public List<string> Chars;
        public List<string> Alphabet = Program.Alphabet;
        public Rotor(int step, List<string> chars)
        {
            Debug.WriteLine("ROTOR CONSTRUCTOR " + step);
            CurrentStep = SetStep(step);
            Chars = chars;
        }
        public void Rotate(int step = 1)
        {
            CurrentStep = SetStep(CurrentStep + step);
        }

        public int SetStep(int step)
        {
            return step % (Program.CHAR_NUM + 1);
        }

        public string GetValueForward(string value)
        {
            int iValue = Alphabet.IndexOf(value);
            return Chars[(iValue) % Program.CHAR_NUM];
        }

        public void ShiftRight()
        {
            Chars.Add(Chars.ElementAt(0));
            Chars.RemoveAt(0);
            Rotate();
        }

        public string GetValueBackward(string value)
        {
            int iValue = Chars.IndexOf(value);
            Debug.WriteLine("ROTOR GETVALUE " + value + "->" + Chars[(iValue + Program.CHAR_NUM) % Program.CHAR_NUM]);
            string newVal = Alphabet[(iValue) % Program.CHAR_NUM];
            return newVal;
        }
    }
}
