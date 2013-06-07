using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrssclient
{
    class HeadLine
    {
        public int id { get; set; }
        public bool unread { get; set; }
        public bool marked { get; set; }
        public bool published { get; set; }
        public string updated { get; set; }
        public bool is_updated { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public int feed_id { get; set; }
        public string[] tags { get; set; }
        public string[] labels { get; set; }
        public string feed_title { get; set; }
        public int comments_count { get; set; }
        public string comments_link { get; set; }
        public bool always_display_attachments { get; set; }
    }
}
