namespace ttrssclient.requests
{
    using System.Linq;

    public class GetCountersRequest
    {
        private string[] output_modes = new string[] { "f"/*feeds*/, "l" /*labels*/, "c" /*categories*/, "t" /*tags*/ };

        public GetCountersRequest(string session_id, string output_mode)
        {
            this.sid = session_id;
            if (output_modes.Contains(output_mode))
            {
                this.output_mode = output_mode;
            }
        }

        public string op { get { return "getCounters"; } }

        public string output_mode
        {
            get;
            private set;
        }

        public string sid { get; private set; }
    }
}
