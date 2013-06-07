
namespace ttrssclient.responses
{
    public class Response<T>
    {
        public int seq { get; set; }
        public int status { get; set; }
        public T content { get; set; }
    }
}
