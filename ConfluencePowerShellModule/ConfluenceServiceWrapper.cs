using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell
{
    /// <summary>
    /// This class, serves as a wrapper for the XML-RPC endpoint available in Confluence.
    /// More details on the individual operations can be on this url: 
    /// https://developer.atlassian.com/confdev/confluence-rest-api/confluence-xml-rpc-and-soap-apis/remote-confluence-methods
    /// </summary>
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

        public RemoteSpace AddSpaceWithDefaultPermissions(RemoteSpace remoteSpace)
        {
            return _service.addSpaceWithDefaultPermissions(_authToken, remoteSpace);
        }


        public RemoteAttachment AddAttachment(RemoteAttachment attachment, long pageId, byte[] fileBytes)
        {
            return _service.addAttachment(_authToken, pageId, attachment, fileBytes);
        }

        public bool AddLabelByName(string labelName, long objectId)
        {
            return _service.addLabelByName(_authToken, labelName, objectId);
        }

        public RemoteSpace AddSpace(RemoteSpace remoteSpace)
        {
            return _service.addSpace(_authToken, remoteSpace);
        }

        public bool AddPermissionToSpace(string permission, string entityName, string spaceKey)
        {
            return _service.addPermissionToSpace(_authToken, permission, entityName, spaceKey);
        }

        public bool AddPermissionsToSpace(string[] permissions, string entityName, string spaceKey)
        {
            return _service.addPermissionsToSpace(_authToken, permissions, entityName, spaceKey);
        }

        public bool AddAnonymousPermissionsToSpace(string[] permissions, string spaceKey)
        {
            return _service.addAnonymousPermissionsToSpace(_authToken, permissions, spaceKey);
        }

        public RemoteSpacePermissionSet[] GetSpacePermissionSets(string spaceKey)
        {
            return _service.getSpacePermissionSets(_authToken, spaceKey);
        }

        public string[] GetSpaceLevelPermissions()
        {
            return _service.getSpaceLevelPermissions(_authToken);
        }

        public RemoteUser GetUser(string userName)
        {
            return _service.getUser(_authToken, userName);
        }

        public string[] GetUsers(bool viewAll)
        {
            return _service.getActiveUsers(_authToken, viewAll);
        }

        public string[] GetGroups()
        {
            return _service.getGroups(_authToken);
        }

        public bool RemoveSpace(string spaceKey)
        {
            return _service.removeSpace(_authToken, spaceKey);
        }

        public RemotePage GetPage(long pageId)
        {
            return _service.getPage(_authToken, pageId);
        }

        public RemoteLabel[] GetLabels(long objectId)
        {
            return _service.getLabelsById(_authToken, objectId);
        }

        public RemoteSearchResult[] GetLabelContentById(long labelId)
        {
            return _service.getLabelContentById(_authToken, labelId);
        }

        public string Login(string username, string password)
        {
            return _service.login(username, password);
        }

        public string GetSpaceStatus(string spaceKey)
        {
            return _service.getSpaceStatus(_authToken, spaceKey);
        }

        public bool SetSpaceStatus(string spaceKey, string status)
        {
            return _service.setSpaceStatus(_authToken, spaceKey, status);
        }
    }
}
