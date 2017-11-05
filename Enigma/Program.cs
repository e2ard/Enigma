using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.App;
namespace Enigma
{
    class Program
    {
        public static int CHAR_NUM = 5;
        static void Main(string[] args)
        {
            EnigmaMachine em = new EnigmaMachine();
            em.Run();
        }
    }
}
