# Azure-Sample-KeyVault

The idea here is to build an API app that can read a secret from Azure KeyVault using managed identity. I am using azure SDK, which makes managed identity work flow really simple. Basically you don't have to worry about the token that managed identity gets from the Azure AD and verification of that token by the Azure KeyVault. For the local development, the SDK will use azure cli to bypass managed identity. So make sure you have the Azure cli installed in your computer. However, you also need to make sure that the secret exists and azure keyvault has an access policy for your username. Finally you can deploy the app and test it on the azure app service.

# TODO
1. Explain the design bellow.
2. Explain how the data factory can read a key without AzureKeyVault
3. Explain how the managed identity works.
4. Explain the project, what it does?

<img src="Architecture.jpg" />
