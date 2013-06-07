namespace ttrssclient.requests
{
    public class GetHeadLinesRequest
    {
        public string op { get { return "getHeadLines"; } }

        public GetHeadLinesRequest(string session_id, int feed_id, int limit, int skip, bool is_cat, bool show_excerpt, bool show_content, string view_mode, bool include_attachements, int since_id, bool include_nested, string order_by)
        {
            this.sid = session_id;
            this.feed_id = feed_id;
            this.limit = limit;
            this.skip = skip;
            this.is_cat = is_cat;
            this.show_excerpt = show_excerpt;
            this.show_content = show_content;
            this.view_mode = view_mode;
            this.include_attachments = include_attachments;
            this.since_id = since_id;
            this.include_nested = include_nested;
            this.order_by = order_by;
        }
        public GetHeadLinesRequest(string session_id, int feed_id)
        {
            this.sid = session_id;
            this.feed_id = feed_id;
            this.view_mode = "unread";
        }

        public string sid { get; private set; }
        public int feed_id { get; private set; }
        public int limit { get; private set; }
        public int skip { get; private set; }
        public bool is_cat { get; private set; }
        public bool show_excerpt { get; private set; }
        public bool show_content { get; private set; }
        public string view_mode { get; private set; }
        public bool include_attachments { get; private set; }
        public int since_id { get; private set; }
        public bool include_nested { get; private set; }

        /// <summary>
        /// "date_reverse" - oldest first | "feed_dates" - newest first, goes by feed date | (nothing) - default
        /// </summary>
        public string order_by { get; private set; }

        /*
        public string search { get; private set; }
        public string search_mode { get; private set; }
        public string match_on { get; private set; }
        */
    }
}
