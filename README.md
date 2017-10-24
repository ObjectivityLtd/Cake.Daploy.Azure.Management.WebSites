# Cake.Deploy.Azure.Management.WebSites ![Build status](https://ci.appveyor.com/api/projects/status/github/ObjectivityLtd/Cake.Deploy.Azure.Management.WebSites?svg=true)
Cake addin for getting publishing credentials of Azure WebApp. 

## How to add Cake.Deploy.Azure.Management.WebSites
In order to use it add the following line in your addin section:
```cake
#addin "Cake.Deploy.Azure.Management.WebSites"
```

## How to use Cake.Deploy.Azure.Authentication
ServiceClientCredentials object required by GetPublishingCredentials method can be obtained using Cake.Deploy.Azure.Authentication addin.

```cake
#addin "Cake.Deploy.Azure.Authentication"
#addin "Cake.Deploy.Azure.Management.WebSites"

var credentials = LoginAzureRM("tenantId", "username", "password");
var pubUser = GetPublishingCredentials(credentials, subscriptionId, resourceGroupName, websiteName);
```
