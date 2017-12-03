using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator
{
    public class Item
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }

        public Item()
        {
            Link = "";
            Title = "";
            Content = "";
            PublishDate = DateTime.Today;
        }

    }
}