# Azure App Configuration Module

> see https://aka.ms/autorest

This is the AutoRest configuration and documentation file for the Azure App Configuration powershell module

---
## Requirements to build the module

Use of the beta version of `autorest.powershell` generator requires the following:

- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred. Will not function with Node < 10.x Be Wary of 11.x builds as they may introduce instability or breaking changes. ) 
> if you want an easy way to install and update Node, I recommend [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md)

- [AutoRest](https://aka.ms/autorest) v3 beta <br> `npm install -g autorest@beta ` <br>&nbsp;
- PowerShell 6.0 - If you dont have it installed, you can use the cross-platform npm package <br> `npm install -g pwsh` <br>&nbsp;
- Dotnet SDK 2 or greater - If you dont have it installed, you can use the cross-platform npm package <br> `npm install -g dotnet-sdk-2.1 ` <br>&nbsp;


## Requirements to use the module

- Modified Azure AzAccounts module (included in `Az.Accounts` folder)

## IMPORTANT - BEFORE - YOU - USE - THE - GENERATED - MODULE
- run `use-azaccount.ps1` so the right az.accounts module is loaded for tests.

# Regenerating the module from Swagger

In this directory, run AutoRest

> `autorest`


## Running the module 

Then you can compile and run the module:

> `./generated/build-module.ps1 -test `

``` text
Spawning in isolated process.
Cleaning folders...
Compiling private module code
Private Module loaded (C:\...\sample\generated\bin\TimesNewswire.private.dll).
Processing cmdlet variants
Generating unified cmdlet proxies
Done.

PS C:\...\sample\generated [ testing AppConfigurationManagement ] >
```

and you can examine the cmdlets: 

> `Get-Command -Module AppConfigurationManagement`

``` bash 
CommandType     Name                                               Version    Source
-----------     ----                                               -------    ------
Function        Get-AzConfigurationStore                           1.0        AppConfigurationManagement
Function        Get-AzConfigurationStoreKey                        1.0        AppConfigurationManagement
Function        Get-AzOperation                                    1.0        AppConfigurationManagement
Function        New-AzCheckNameAvailabilityParametersObject        1.0        AppConfigurationManagement
Function        New-AzConfigurationStore                           1.0        AppConfigurationManagement
Function        New-AzConfigurationStoreKey                        1.0        AppConfigurationManagement
Function        New-AzConfigurationStoreObject                     1.0        AppConfigurationManagement
Function        New-AzConfigurationStorePropertiesObject           1.0        AppConfigurationManagement
Function        New-AzConfigurationStorePropertiesUpdateParamet... 1.0        AppConfigurationManagement
Function        New-AzConfigurationStoreUpdateParametersObject     1.0        AppConfigurationManagement
Function        New-AzRegenerateKeyParametersObject                1.0        AppConfigurationManagement
Function        Remove-AzConfigurationStore                        1.0        AppConfigurationManagement
Function        Test-AzOperationNameAvailability                   1.0        AppConfigurationManagement
Function        Update-AzConfigurationStore                        1.0        AppConfigurationManagement

```

Run a command: 

> `Get-AzConfigurationStore`

```
Name           Type                                   Id                                                                                                                                             Location  Tag   Propertie
                                                                                                                                                                                                                     s
----           ----                                   --                                                                                                                                             --------  ---   ---------
ElkTestConfig  Microsoft.AppConfiguration/configurationStores /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/appconfigsrg/providers/Microsoft.AppConfiguration/configurationStores/elktestconfig  centralus {}    Micros...
ElkTestConfig2 Microsoft.AppConfiguration/configurationStores /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/appconfigsrg/providers/Microsoft.AppConfiguration/configurationStores/elktestconfig2 centralus {}    Micros...
testcf6        Microsoft.AppConfiguration/configurationStores /subscriptions/9e223dbe-3399-4e19-88eb-0975f02ac87f/resourceGroups/appconfigsrg/providers/Microsoft.AppConfiguration/configurationStores/testcf6        westus    {foo} Micros...

```

---


## Notes about using Authentication
AutoRest doesn't add authentication code into the generated client, given that there is so much variance on how that works.

This sample includes an [extension](./generated/custom/Module.cs) to the module that alters the HTTP payload before it's sent.


### AutoRest Configuration  Information
These are the settings for generating the cmdlets for the API with AutoRest (instead of putting them on the command line)

``` yaml
input-file: appconfiguration.json
namespace: Microsoft.Azure.AppConfiguration
powershell: true
clear-output-folder: true
output-folder: generated
azure: true

 
  
```

# PowerShell
This configuration block pulls in the powershell generator automatically. 

``` yaml
use:
- "@microsoft.azure/autorest.powershell@beta"

```
