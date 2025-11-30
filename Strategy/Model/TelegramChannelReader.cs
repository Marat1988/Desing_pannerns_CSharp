using Strategy.Abstract;

namespace Strategy.Model
{
    public class TelegramChannelReader: IReader
    {
        public void Parse(string url) => Console.WriteLine("Парсинг канала мессенджера Telegram: " + url);
    }
}
