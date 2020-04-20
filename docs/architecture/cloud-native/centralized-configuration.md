---
title: Centralized configuration
description: Centralizing configuration for cloud-native applications using Azure App Configuration and AzureKey Vault.
ms.date: 04/19/2020
---

# Centralized configuration

[!INCLUDE [book-preview](../../../includes/book-preview.md)]

Unlike a monolithic app in which everything runs within a single instance, a cloud-native application consists of independent services distributed across virtual machines, containers, and geographic regions. Managing configuration settings for dozens of interdependent services can be challenging. Duplicate copies of configuration settings across different locations is error prone and difficult to manage. A critical requirement for distributed cloud-native applications is centralized configuration.

As discussed in [Chapter 1](introduction.md), the Twelve-Factor App recommendations require strict separation between code and configuration. Configuration must be stored externally from the application and read-in as needed. Storing configuration values as constants or literal values in code is a violation. The same configuration values are often be used by many services in the same application. Additionally, we must support the same values across multiple environments, such as dev, testing, and production. The best practice is store them in a centralized configuration store.

The Azure cloud presents several great options.

## Azure App Configuration

App Configuration is a fully managed Azure service that stores non-secret configuration settings in a secure, centralized location. Stored values can be shared among multiple services and applications.

The service is simple to use and provides several benefits:

- Flexible key/value representations and mappings
- Tagging with Azure labels
- Dedicated UI for management
- Encryption of sensitive information at rest and in transit
- Querying and batch retrieval

Azure App Configuration maintains changes made to key-value settings for seven days. The point-in-time snapshot feature enables you to reconstruct the history of a setting and even rollback for a failed deployment.

App Configuration automatically caches each setting to avoid excessive calls to the configuration store. The refresh operation waits until the cached value of a setting expires to update that setting, even when its value changes in the configuration store. The default cache expiration time is 30 seconds. You can override the expiration time.

App Configuration encrypts all configuration values in transit and at rest. Key names and labels are used as indexes for retrieving configuration data and aren't encrypted.

Although App Configuration provides hardened security, Azure Key Vault is still the best place for storing application secrets. Key Vault provides hardware-level encryption, granular access policies, and management operations such as certificate rotation. You can create App Configuration values that reference secrets stored in a Key Vault.

## Azure Key Vault

Key Vault is a managed service for securely storing and accessing secrets. A secret is anything that you want to tightly control access to, such as API keys, passwords, or certificates. A vault is a logical group of secrets.

Key Vault greatly reduces the chances that secrets may be accidentally leaked. When using Key Vault, application developers no longer need to store security information in their application. Not having to store security information in applications eliminates the need to make this information part of the code. For example, an application may need to connect to a database. Instead of storing the connection string in the app's code, you can store it securely in Key Vault.

Your applications can securely access the information they need by using URIs. These URIs allow the applications to retrieve specific versions of a secret. There's no need to write custom code to protect any of the secret information stored in Key Vault.

Access to Key Vault requires proper caller authentication and authorization. Typically, each cloud-native microservice uses a ClientId/ClientSecret combination. It's important to keep these credentials outside source control. A best practice is to set them in  the application's environment. Direct access to Key Vault from AKS can be achieved using [Key Vault FlexVolume](https://github.com/Azure/kubernetes-keyvault-flexvol).

## Configuration in eShop

The eShopOnContainers application includes local application settings files with each microservice. These files are checked into source control, but don't include production secrets such as connection strings or API keys. In production, individual settings may be overwritten with per-service environment variables. Injecting secrets in environment variables is a common practice for hosted applications, but doesn't provide a central configuration store. To support centralized management of configuration settings, each microservice includes a setting to toggle between its use of local settings or Azure Key Vault settings.

>[!div class="step-by-step"]
>[Previous](deploy-eshoponcontainers-azure.md)
>[Next](scale-applications.md)
