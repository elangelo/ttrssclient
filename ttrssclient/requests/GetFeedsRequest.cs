namespace ttrssclient.requests
{
    public class GetFeedsRequest
    {
        public string op { get { return "getFeeds"; } }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session_id"></param>
        /// <param name="cat_id">0 - Uncategorized/1 - Special (e.g. Starred, Published, Archived, etc.)/2 - Labels/3 - All feeds, excluding virtual feeds (e.g. Labels and such)/4 - All feeds, including virtual feeds</param>
        /// <param name="unread_only"></param>
        /// <param name="include_nested"></param>
        public GetFeedsRequest(string session_id, int cat_id, bool unread_only, bool include_nested)
        {
            this.sid = session_id;
            this.cat_id = cat_id;
            this.unread_only = unread_only;
            this.include_nested = include_nested;
        }

        public string sid { get; private set; }
        public int cat_id { get; private set; }
        public bool unread_only { get; private set; }
        public bool include_nested { get; private set; }
    }

}
