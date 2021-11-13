namespace WebUi.Templates.V1
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        
        public const string Version = "v1";
        
        public const string Base = $"{Root}/{Version}";
        
        public static class Orders
        {
            public const string GetAll = $"{Base}/orders";
        }
    }
}