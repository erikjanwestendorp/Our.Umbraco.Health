namespace Our.Umbraco.Health
{
    public static class Constants
    {
        public static class uSync
        {
            public const string Group = "uSync";
            public const string FilePath = "~/config/uSync8.config";

            public static class ExportOnSave
            {
                public const string Id = "8D6CF96E-F1B9-45CA-B5B6-FFF75930DF88";
                public const string Name = "Export on save";
                public const string Description = "Check to make sure that export on save is disable";
                public const string XPath = "/uSync/BackOffice/ExportOnSave";
            }

            public static class ImportAtStartup
            {
                public const string Id = "B3457661-C46F-4687-A930-FF7CC5455243";
                public const string Name = "Import At Startup";
                public const string Description = "Check to make sure that import at startup is disabled";
                public const string XPath = "/uSync/BackOffice/ImportAtStartup";
            }



        }
    }
}
