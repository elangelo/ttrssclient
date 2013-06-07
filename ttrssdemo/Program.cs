namespace ttrssdemo
{
    using System;
    using System.Configuration;
    using System.Net;
    using System.Web.Script.Serialization;
    using ttrssclient.dto;
    using ttrssclient.requests;
    using ttrssclient.responses;


    class Program
    {
        static WebClient webClient = new WebClient();
        static JavaScriptSerializer serializer = new JavaScriptSerializer();

        static void Main(string[] args)
        {
            /*System.Net.HttpWebRequest adds the header 'HTTP header "Expect: 100-Continue"' to every request unless you explicitly ask it not to by setting this static property to false:*/
            System.Net.ServicePointManager.Expect100Continue = false;

            var server = ConfigurationManager.AppSettings["server"];
            var username = ConfigurationManager.AppSettings["username"];
            var password = ConfigurationManager.AppSettings["password"];

            var response = webClient.UploadString(server, serializer.Serialize(GetLoginRequest(username, password)));
            var loginResponse = serializer.Deserialize<Response<LoginResponse>>(response);

            var session_id = loginResponse.content.session_id;

            Console.WriteLine("successfully logged in, session_id: " + session_id);

            var getUnreadReqeust = new GetUnreadRequest(session_id);
            var unread = ExecuteMethod<GetUnreadRequest, GetUnreadResponse>(getUnreadReqeust, server).unread;
            Console.WriteLine("unread number of articles: " + unread);

            var getCountersRequest = new GetCountersRequest(session_id, "l");
            var counters = ExecuteMethod<GetCountersRequest, Counter[]>(getCountersRequest, server);
            Console.WriteLine(counters);

            Console.WriteLine("Categories: ");
            var categories = ExecuteMethod<GetCategoriesRequest, Category[]>(new GetCategoriesRequest(session_id, true, false, false), server);
            foreach (var categroy in categories)
            {
                Console.WriteLine(categroy.title + ": " + categroy.unread);
            }
            Console.WriteLine();

            Console.WriteLine("Feeds: ");
            var feeds = ExecuteMethod<GetFeedsRequest, Feed[]>(new GetFeedsRequest(session_id, -3, true, true), server);
            foreach (var feed in feeds)
            {
                Console.WriteLine(feed.title + ": " + feed.unread);
            }
            Console.WriteLine();

            Console.WriteLine("HeadLines of Feed 34");
            var headLines = ExecuteMethod<GetHeadLinesRequest, HeadLine[]>(new GetHeadLinesRequest(session_id, 34), server);

            var logoutObject = new LogoutRequest(session_id);
            var logoutResponse = ExecuteMethod<LogoutRequest, LogoutResponse>(logoutObject, server);
            Console.WriteLine(logoutResponse.status);

            Console.ReadKey();




            Console.WriteLine("press the any key");
            Console.ReadKey();
        }

        static LoginRequest GetLoginRequest(string userName, string password)
        {
            return new LoginRequest() { user = userName, password = password };
        }

        static U ExecuteMethod<T, U>(T Request, string url)
        {
            var response = webClient.UploadString(url, serializer.Serialize(Request));
            return serializer.Deserialize<Response<U>>(response).content;
        }
    }
}
