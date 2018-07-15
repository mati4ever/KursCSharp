using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace Assemblies
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt = new SpeechSynthesizer();

            synt.Speak("Hello Matthew");

            Console.ReadKey();

        }
    }
}
