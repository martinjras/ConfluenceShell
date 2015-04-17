using ConfluencePowerShellModule.ConfluenceService;

namespace ConfluencePowerShellModule
{
    public class ConfluenceServiceWrapper
    {
        private readonly string _authToken;
        private readonly ConfluenceSoapServiceService _service;

        public ConfluenceServiceWrapper(string serviceUrl, string authToken)
        {
            _authToken = authToken;
            
            _service = new ConfluenceSoapServiceService
            {
                Url = serviceUrl
            };
        }

        public ConfluenceServiceWrapper(string serviceUrl) : this(serviceUrl, null) { }

        public RemoteSpaceSummary[] GetSpaces()
        {
            return _service.getSpaces(_authToken);
        }

        public RemoteSpace GetSpace(string spaceKey)
        {
            return _service.getSpace(_authToken, spaceKey);
        }

        public string Login(string username, string password)
        {
            return _service.login(username, password);
        }
    }
}
