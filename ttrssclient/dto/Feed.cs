using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrssclient
{
    class Feed
    {
        public string feed_url { get; set; }
        public string title { get; set; }
        public string id { get; set; }
        public string unread { get; set; }
        public string has_icon { get; set; }
        public string cat_id { get; set; }
        public string last_updated { get; set; }
        public string order_id { get; set; }
    }
}
