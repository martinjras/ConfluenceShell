using System;
using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class Space
    {
        public SpaceKey SpaceKey { get; set; }
        public long HomePage { get; set; }
        public string Name { get; set; }
        public SpaceType Type { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }

        internal Space(RemoteSpaceSummary space)
        {
            SpaceKey = space.key;
            Name = space.name;
            Type = (SpaceType) Enum.Parse(typeof (SpaceType), space.type, true);
            Url = space.url;

            // if RemoteSpace, then extract additional information
            if (space.GetType() == typeof (RemoteSpace))
            {
                HomePage = ((RemoteSpace)space).homePage;
                Description = ((RemoteSpace)space).description;
            }            
        }

      
    }
}
