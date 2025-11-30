using Strategy.Abstract;

namespace Strategy.Model
{
    public class NewSiteReader: IReader
    {
        public void Parse(string url) => Console.WriteLine("Парсинг с новостного сайта: " + url);
    }
}
