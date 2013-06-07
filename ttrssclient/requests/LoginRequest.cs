
namespace ttrssclient.requests
{
    public class LoginRequest
    {
        /// <summary>
        /// operation
        /// </summary>
        public string op { get { return "login"; } }
        public string user { get; set; }
        public string password { get; set; }
    }
}
