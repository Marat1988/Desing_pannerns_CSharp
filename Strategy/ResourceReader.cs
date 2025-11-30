using Strategy.Abstract;

namespace Strategy
{
    public class ResourceReader
    {
        private IReader reader;
        public ResourceReader(IReader reader)
        {
            this.reader = reader;
        }
        public void SetStrategy(IReader reader) => this.reader = reader;

        public void Read(string url) => reader.Parse(url);
    }
}
