using Template.Abstract;
using Template.Models;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transtimitter analogTransmitter = new AnalogTransmitter();
            analogTransmitter.ProcessStart();
            Console.WriteLine();
            Transtimitter digitTransmitter = new DigitTransmitter();
            digitTransmitter.ProcessStart();
        }
    }
}
