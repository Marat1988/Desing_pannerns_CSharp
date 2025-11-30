using Template.Abstract;

namespace Template.Models
{
    public class DigitTransmitter: Transtimitter
    {
        protected override void Simpling() => Console.WriteLine("Дискритизация записанного фрагмента");
        protected override void Digitization() => Console.WriteLine("Оцифровка");
        protected override void Modulation() => Console.WriteLine("Модуляция цифрового сигнала");
    }
}
