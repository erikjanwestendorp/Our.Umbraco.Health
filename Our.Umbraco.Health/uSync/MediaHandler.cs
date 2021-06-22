using System.Collections.Generic;
using Umbraco.Core.Services;
using Umbraco.Web.HealthCheck;
using Umbraco.Web.HealthCheck.Checks.Config;

namespace Our.Umbraco.Health.uSync
{
    [HealthCheck(Constants.uSync.MediaHandler.Id, Constants.uSync.MediaHandler.Name, Description = Constants.uSync.MediaHandler.Description, Group = Constants.uSync.Group)]
    public class MediaHandler : AbstractConfigCheck
    {
        public MediaHandler(ILocalizedTextService textService)
            : base(textService)
        {
        }
        public override string FilePath => Constants.uSync.FilePath;
        public override string XPath => Constants.uSync.MediaHandler.XPath;
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
