using System.Collections.Generic;
using Umbraco.Core.Services;
using Umbraco.Web.HealthCheck;
using Umbraco.Web.HealthCheck.Checks.Config;

namespace Our.Umbraco.Health.uSync
{
    [HealthCheck(Constants.uSync.ImportAtStartup.Id, Constants.uSync.ImportAtStartup.Name, Description = Constants.uSync.ImportAtStartup.Description, Group = Constants.uSync.Group)]
    public class ImportAtStartupCheck : AbstractConfigCheck
    {
        public ImportAtStartupCheck(ILocalizedTextService textService) 
            : base(textService)
        {
        }

        public override string FilePath => Constants.uSync.FilePath;
        public override string XPath => Constants.uSync.ImportAtStartup.XPath;
        public override ValueComparisonType ValueComparisonType => ValueComparisonType.ShouldEqual;
        public override IEnumerable<AcceptableConfiguration> Values => new List<AcceptableConfiguration>
        {
            new AcceptableConfiguration
            {
                IsRecommended = true,
                Value = "False"
            }
        };
    }
}
