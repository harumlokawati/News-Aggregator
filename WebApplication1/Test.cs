using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator
{
    public class Test
    {
        public static void Main(string[] args)
        {
            IList<RSS> rss = new List<RSS>();
            rss.Add(new RSS("http://rss.detik.com/index.php/detikcom", "//div[@id='detikdetailtext']"));
            rss.Add(new RSS("http://tempo.co/rss/terkini", "//div[@class='artikel']"));
            rss.Add(new RSS("http://rss.vivanews.com/get/all", "//span[@itemprop='description']"));
            rss.Add(new RSS(" http://www.antaranews.com/rss/terkini", "//div[@id='content_news']"));
            List<Item> I = new List<Item>();
            Parser Parser = new Parser();
            foreach (RSS irss in rss)
            {
                I.AddRange(Parser.RSSParser(irss));
            }
            foreach (Item item in I)
            {
                Console.WriteLine("LINK: " + item.Link);
                Console.WriteLine("TITLE: " + item.Title);
                Console.WriteLine("DATE: " + item.PublishDate);
                Console.WriteLine("CONTENT: " + item.Content);
                Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}