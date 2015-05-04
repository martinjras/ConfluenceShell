using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class User
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Username { get; set; }
        public string Url { get; set; }

        public User(RemoteUser user)
        {
            Email = user.email;
            FullName = user.fullname;
            Username = user.name;
            Url = user.url;
        }
    }
}