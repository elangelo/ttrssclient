using System;
using System.Configuration;
using System.Net;
using System.Web.Script.Serialization;
using ttrssclient.requests;
using ttrssclient.responses;

namespace ttrssdemo
{
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

            Console.WriteLine("successfully logged in, session_id: " + loginResponse.content.session_id);
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
