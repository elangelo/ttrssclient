using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ttrssclient
{
    public class Category
    {
        public int id { get; set; }
        public string title { get; set; }
        public int unread { get; set; }
        public int order_id { get; set; }
    }
}
