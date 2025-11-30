using Strategy.Abstract;

namespace Strategy.Model
{
    public class SocialNetworkReader: IReader
    {
        public void Parse(string url) => Console.WriteLine("Парсинг летны новостей социальной сети: " + url);
    }
}
