namespace Cake.Deploy.Azure.Management.WebSites
{
    using Cake.Core;
    using Cake.Core.Annotations;
    using Microsoft.Azure.Management.WebSites;
    using Microsoft.Azure.Management.WebSites.Models;
    using Microsoft.Rest;

    [CakeAliasCategory("Azure")]
    public static class AddinAliases
    {
        [CakeMethodAlias]
        [CakeAliasCategory("Azure WebApp")]
        public static User GetPublishingCredentials(this ICakeContext ctx, ServiceClientCredentials credentials, string subscriptionId, string resourceGroupName, string websiteName)
        {
            var client = new WebSiteManagementClient(credentials)
            {
                SubscriptionId = subscriptionId
            };

            var retUser = client.WebApps.ListPublishingCredentials(resourceGroupName, websiteName);

            return retUser;
        }

        [CakeMethodAlias]
        [CakeAliasCategory("Azure WebApp")]
        public static User GetPublishingCredentialsSlot(this ICakeContext ctx, ServiceClientCredentials credentials, string subscriptionId, string resourceGroupName, string websiteName, string slot)
        {
            var client = new WebSiteManagementClient(credentials)
            {
                SubscriptionId = subscriptionId
            };

            var retUser = client.WebApps.ListPublishingCredentialsSlot(resourceGroupName, websiteName, slot);

            return retUser;
        }

        [CakeMethodAlias]
        [CakeAliasCategory("Azure WebApp")]
        public static void SwapSlotSlot(this ICakeContext ctx, ServiceClientCredentials credentials, string subscriptionId, string resourceGroupName, string websiteName, string srcSlot, string destSlot, bool preserveVnet)
        {
            var client = new WebSiteManagementClient(credentials)
            {
                SubscriptionId = subscriptionId
            };

            client.WebApps.SwapSlotSlot(resourceGroupName, websiteName, new CsmSlotEntity(destSlot, preserveVnet), srcSlot);
        }
    }
}
