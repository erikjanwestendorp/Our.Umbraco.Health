using System.Collections.Generic;
using Umbraco.Core.Services;
using Umbraco.Web.HealthCheck;
using Umbraco.Web.HealthCheck.Checks.Config;

namespace Our.Umbraco.Health.uSync
{
    [HealthCheck(Constants.uSync.ExportOnSave.Id, Constants.uSync.ExportOnSave.Name, Description = Constants.uSync.ExportOnSave.Description, Group = Constants.uSync.Group)]
    public class ExportOnSaveCheck : AbstractConfigCheck
    {
        public ExportOnSaveCheck(ILocalizedTextService textService)
            : base(textService)
        {
        }

        public override string FilePath => Constants.uSync.FilePath;
        public override string XPath => Constants.uSync.ExportOnSave.XPath;
        public override ValueComparisonType ValueComparisonType => ValueComparisonType.ShouldEqual;

        public override IEnumerable<AcceptableConfiguration> Values => new List<AcceptableConfiguration>
        {
            new AcceptableConfiguration
            {
                IsRecommended = true,
                Value = "False"
            }, new AcceptableConfiguration
            {
                IsRecommended = true,
                Value = "false"
            }
        };
    }
}
