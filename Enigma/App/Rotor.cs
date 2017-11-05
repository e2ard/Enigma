using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.App
{
    class Rotor
    {
        public int CurrentStep;
        string[] Chars = { "A", "B", "C", "D", "E" };
        public Rotor(int step)
        {
            Console.WriteLine("ROTOR CONSTRUCTOR " + step);
            CurrentStep = step;
        }
        public void Rotate(int step = 1)
        {
            CurrentStep = (CurrentStep + step) % Program.CHAR_NUM;
            Console.WriteLine("ROTOR ROTATE" + CurrentStep);
        }

        public void SetStep(int step)
        {
            CurrentStep = step;
        }

        public string GetValue(string value)
        {
            int iValue = value[0] - 65;
            Console.WriteLine("ROTOR GETVALUE" + CurrentStep  + "\n");
            //Console.Write(value + "to int " + Convert.ToInt32(iValue));
            return Chars[(CurrentStep + iValue) % Program.CHAR_NUM];
        }
    }
}
