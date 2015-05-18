using System;
using ConfluenceShell.ConfluenceService;

namespace ConfluenceShell.CmdletTypes
{
    public class SpacePermissionSet
    {
        public SpaceLevelPermission Permission { get; set; }
        public string EntityName { get; set; }
        public EntityType EntityType { get; set; }

        internal SpacePermissionSet(RemoteContentPermission permission)
        {
            Permission = (SpaceLevelPermission) Enum.Parse(typeof (SpaceLevelPermission), permission.type, true);
            EntityName = permission.groupName ?? permission.userName;
            EntityType = permission.groupName != null ? EntityType.Group : EntityType.User;
        }
    }
}