using System;
using System.Collections.Generic;
using System.Text;
using Template.Abstract;

namespace Template.Models
{
    public class AnalogTransmitter: Transtimitter
    {
        protected override void Modulation() => Console.WriteLine("Модуляция аналогвого сигнала");
    }
}
