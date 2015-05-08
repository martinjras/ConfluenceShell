using System.IO;
using ConfluenceShell.CmdletTypes;
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

        public RemoteAttachment Stuff()
        {
            var attachment = new RemoteAttachment
            {
                comment = "Some Comment", contentType = "hmmm", created = null, creator = "admin",
                fileName = "some word doc.docx",
                pageId = 557154, title = "Hej title"
            };

            byte[] bytes = File.ReadAllBytes(@"C:\Users\saxouser\Desktop\test.docx");

            return _service.addAttachment(_authToken, attachment, bytes);
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

        public bool RemoveSpace(string spaceKey)
        {
            return _service.removeSpace(_authToken, spaceKey);
        }

        public RemotePage GetPage(long pageId)
        {
            return _service.getPage(_authToken, pageId);
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
