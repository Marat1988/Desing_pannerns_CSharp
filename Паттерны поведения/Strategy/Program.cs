using Strategy.Model;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourceReader resourceReader = new ResourceReader(new NewSiteReader());

            string url = "http://news.com";
            resourceReader.Read(url);

            url = "https://facebook.com";
            resourceReader.SetStrategy(new SocialNetworkReader());
            resourceReader.Read(url);

            url = "@news_channel_telegram";
            resourceReader.SetStrategy(new TelegramChannelReader());
            resourceReader.Read(url);
        }
    }
}
