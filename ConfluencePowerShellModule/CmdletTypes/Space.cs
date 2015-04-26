using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class Space
    {
        public SpaceKey SpaceKey { get; set; }
        public long HomePage { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        internal Space(RemoteSpaceSummary space)
        {
            SpaceKey = space.key;
            Name = space.name;
            Type = space.type;
            Url = space.url;

            // if RemoteSpace, then extract additional information
            if (space.GetType() == typeof (RemoteSpace))
            {
                HomePage = ((RemoteSpace)space).homePage;
            }            
        }

      
    }
}
