---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version:
schema: 2.0.0
---

# Test-AzConfigurationStoreNameAvailability

## SYNOPSIS

## SYNTAX

### NameAvailabilityNameTypeExpanded (Default)
```
Test-AzConfigurationStoreNameAvailability [-Break] [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -Name <String>
 -Type <ConfigurationResourceType> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NameAvailabilitySubscriptionIdNameType
```
Test-AzConfigurationStoreNameAvailability [-Break]
 -CheckNameAvailabilityParameters <ICheckNameAvailabilityParameters> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -SubscriptionId <String> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### NameAvailabilityNameType
```
Test-AzConfigurationStoreNameAvailability [-Break]
 -CheckNameAvailabilityParameters <ICheckNameAvailabilityParameters> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### NameAvailabilitySubscriptionIdNameTypeExpanded
```
Test-AzConfigurationStoreNameAvailability [-Break] [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -Name <String>
 -Type <ConfigurationResourceType> -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Checks whether the configuration store name is available for use.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -Break
Wait for .NET debugger to attach

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -CheckNameAvailabilityParameters
Parameters used for checking whether a resource name is available.

```yaml
Type: ICheckNameAvailabilityParameters
Parameter Sets: NameAvailabilitySubscriptionIdNameType, NameAvailabilityNameType
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: Object
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelineAppend
SendAsync Pipeline Steps to be appended to the front of the pipeline

```yaml
Type: SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -HttpPipelinePrepend
SendAsync Pipeline Steps to be prepended to the front of the pipeline

```yaml
Type: SendAsyncStep[]
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Proxy
The URI for the proxy server to use

```yaml
Type: Uri
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyCredential
Credentials for a proxy server to use for the remote call

```yaml
Type: PSCredential
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProxyUseDefaultCredentials
Use the default credentials for the proxy

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Name
The name to check for availability.

```yaml
Type: String
Parameter Sets: NameAvailabilityNameTypeExpanded, NameAvailabilitySubscriptionIdNameTypeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Type
The resource type to check for name availability.

```yaml
Type: ConfigurationResourceType
Parameter Sets: NameAvailabilityNameTypeExpanded, NameAvailabilitySubscriptionIdNameTypeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Microsoft Azure subscription ID.

```yaml
Type: String
Parameter Sets: NameAvailabilitySubscriptionIdNameType, NameAvailabilitySubscriptionIdNameTypeExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable.
For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.INameAvailabilityStatus
## NOTES

## RELATED LINKS
