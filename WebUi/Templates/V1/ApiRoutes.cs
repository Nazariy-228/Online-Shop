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
        
        public static class Account
        {
            public const string Accounts = $"{Base}/account";
        }
        
        public static class Contact
        {
            public const string Contacts = $"{Base}/contact";
        }
        
        public static class Incident
        {
            public const string Incidents = $"{Base}/incident";
        }
        
        public static class Case
        {
            public const string Cases = $"{Base}/case";
        }
    }
}