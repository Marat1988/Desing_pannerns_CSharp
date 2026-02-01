namespace Template.Abstract
{
    public abstract class Transtimitter
    {
        protected virtual void VoiceRecord() => Console.WriteLine("Запись фрагметна речи");
        protected virtual void Simpling() { }
        protected virtual void Digitization() { }
        protected virtual void Modulation() { }
        protected virtual void Transmission() => Console.WriteLine("Передача сигнала по радиоканалу");
        public void ProcessStart()
        {
            VoiceRecord();
            Simpling();
            Digitization();
            Modulation();
            Transmission();
        }
    }
}
