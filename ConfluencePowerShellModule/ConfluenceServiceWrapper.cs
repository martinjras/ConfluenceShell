using ConfluencePowerShellModule.ConfluenceService;

namespace ConfluencePowerShellModule
{
    public class ConfluenceServiceWrapper
    {
        private static ConfluenceSoapServiceService GetService()
        {
            return new ConfluenceSoapServiceService();
        }

        public RemoteSpaceSummary[] GetSpaces(string authToken)
        {
            return GetService().getSpaces(authToken);
        }

        public RemoteSpace GetSpace(string authToken, string spaceKey)
        {
            return GetService().getSpace(authToken, spaceKey);
        }
    }
}
