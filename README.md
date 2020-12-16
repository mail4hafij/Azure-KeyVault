# Azure-KeyVault

The idea here is to build an API app that can read a secret from Azure KeyVault using Managed Identity. I am using azure SDK, which makes Managed Identity work flow really simple. Basically we don't have to worry about the token that Managed Identity gets from the Azure AD, and later verification of that token by the Azure KeyVault. For the local development though, the SDK will use azure cli to bypass Managed Identity. So make sure you have the Azure CLI installed in your computer. You also need to make sure that the secret exists and azure keyvault is given an access policy for your user account. Finally you can deploy the app and test it on the azure app service.

Provide the necessary data in *SecretController.cs*
```
private const string KeyVaultUri = "your-keyvault-uri";
private const string SecretName = "your-secret-name";
```

## TODO
1. Explain the design bellow.
2. Explain how the data factory can read a key without AzureKeyVault
3. Explain how the managed identity works.
4. Explain the project, what it does?

## Conceptual model
<img src="Architecture.jpg" />
