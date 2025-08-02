using TheScrapeLibrary;

namespace ScrapeClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginners/creating-and-adding-references-to-assemblies");
            Console.WriteLine(value);
        }
    }
}
