namespace ttrssclient.requests
{
    public class GetCategoriesRequest
    {
        public GetCategoriesRequest(string session_id, bool unread_only, bool enable_nested, bool include_empty)
        {
            this.sid = session_id;
            this.unread_only = unread_only;
            this.enable_nested = enable_nested;
            this.include_empty = include_empty;
        }

        public string op { get { return "getCategories"; } }
        public string sid { get; private set; }
        public bool unread_only { get; private set; }
        public bool enable_nested { get; private set; }
        public bool include_empty { get; private set; }
    }
}
