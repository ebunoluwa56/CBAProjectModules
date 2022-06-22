namespace CBAProjectModules.Constant
{
    public static class RoleOperations
    {

        public static List<string> GenerateOperationsForModule(string module)
        {
            return new List<string>()
        {
            $"Permissions.{module}.Create",
            $"Permissions.{module}.View",
            $"Permissions.{module}.Edit",
            $"Permissions.{module}.Delete",
        };
        }

        public static class Operations
        {
            public const string View = "Permissions.Operations.View";
            public const string Create = "Permissions.Operations.Create";
            public const string Edit = "Permissions.Operations.Edit";
            public const string Delete = "Permissions.Operations.Delete";
        }
    }
}
