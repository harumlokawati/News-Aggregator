using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsAggregator
{
    public class RSS
    {
        public string Link;
        public string ContentSelector;
        public RSS()
        {
            Link = "";
            ContentSelector = "";
        }
        public RSS (string _Link, string _ContentSelector)
        {
            Link = _Link;
            ContentSelector = _ContentSelector;
        }
    }
}