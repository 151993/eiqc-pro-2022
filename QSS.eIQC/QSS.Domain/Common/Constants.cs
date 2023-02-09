namespace QSS.eIQC.Handlers.Common
{
    internal static class Constants
    {
        static class AuditLog
        {
            static class Title
            {
                private const string AddEntity = "Add new {0} [{1}]";

                public static string AddRole(string name) => string.Format(AddEntity, Entity.Role, name);

            }
        }

        static class Entity
        {
            public const string Role = "Role";
        }
    }
}
