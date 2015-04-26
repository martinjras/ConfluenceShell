namespace ConfluenceShell
{
    public class ConfluenceConnection
    {
        public string BaseUrl { get; private set; }
        public string AuthToken { get; private set; }

        public ConfluenceConnection(string baseUrl, string authToken)
        {
            BaseUrl = baseUrl;
            AuthToken = authToken;
        }
    }
}
