namespace Cake.Daploy.Azure.Management.WebSites
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Azure.Management.WebSites.Models;
    using Microsoft.Rest;

    [CakeAliasCategory("Sample")]
    public static class AddinAliases
    {
        [CakeMethodAlias]
        public static User GetPublishingCredentials(this ICakeContext ctx, ServiceClientCredentials credentials, string subscriptionId, string resourceGroupName, string websiteName)
        {
            WebSiteManagementClient client = new WebSiteManagementClient(credentials)
            {
                SubscriptionId = subscriptionId
            };

            var retUser = client.WebApps.ListPublishingCredentials(resourceGroupName, websiteName);

            return retUser;
        }
    }
}
