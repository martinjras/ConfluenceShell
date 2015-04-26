namespace ConfluenceShell
{
    public class ConfigurationProvider
    {
        public static string GetConfluenceServiceUrl(string baseUrl)
        {
            if (baseUrl.EndsWith("/"))
            { 
                baseUrl = baseUrl.Remove(baseUrl.Length - 1);
            }

            return (baseUrl + "/plugins/servlet/soap-axis1/confluenceservice-v2");
        }
    }
}
