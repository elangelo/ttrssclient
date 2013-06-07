
namespace ttrssclient.requests
{
    public class GetUnreadRequest
    {
        public GetUnreadRequest(string sid)
        {
            this.sid = sid;
        }

        public string sid { get; private set; }

        public string op
        {
            get { return "getUnread"; }
        }
    }
}
