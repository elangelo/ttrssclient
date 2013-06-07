
namespace ttrssclient.requests
{
   public class LogoutRequest
    {
        public LogoutRequest(string sid)
        {
            this.sid = sid;
        }

        public string op { get { return "logout"; } }
        public string sid { get; private set; }
    }
}
