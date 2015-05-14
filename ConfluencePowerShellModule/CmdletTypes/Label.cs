using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class Label
    {
        public string Name { get; set; }
        public string Namespace { get; set; }
        public string Owner { get; set; }
        public long Id { get; set; }

        public Label(RemoteLabel label)
        {
            Id = label.id;
            Name = label.name;
            Namespace = label.@namespace;
            Owner = label.owner;
        }
    }
}