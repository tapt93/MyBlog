namespace MyBlog.MediatR
{
    public static class Response
    {
        public static Response<T> OK<T>(T data) => new(data, "", true);
        public static Response<T> Fail<T>(string message, T data = default) => new(data, message, false);
    }
    public class Response<T>
    {
        public Response(T data, string message, bool error)
        {
            Data = data;
            Message = message;
            Error = error;
        }
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Error { get; set; }
    }
}
