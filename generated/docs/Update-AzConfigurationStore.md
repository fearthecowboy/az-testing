---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version:
schema: 2.0.0
---

# Update-AzConfigurationStore

## SYNOPSIS

## SYNTAX

### ResourceGroupNameConfigStoreNamePropertiesTagsExpanded (Default)
```
Update-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String> [-Enabled]
 [-Tag <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags
```
Update-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String>
 -ConfigStoreUpdateParameters <IConfigurationStoreUpdateParameters> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String>
 -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ResourceGroupNameConfigStoreNamePropertiesTags
```
Update-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String>
 -ConfigStoreUpdateParameters <IConfigurationStoreUpdateParameters> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc
```
Update-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String> [-Enabled]
 [-Tag <Hashtable>] -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Updates a configuration store with the specified parameters.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

### -AsJob
Run the command as a job

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

### -ConfigStoreName
The name of the configuration store.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ConfigStoreUpdateParameters
The parameters for updating a configuration store.

```yaml
Type: IConfigurationStoreUpdateParameters
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags, ResourceGroupNameConfigStoreNamePropertiesTags
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

### -ResourceGroupName
The name of the resource group to which the container registry belongs.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Enabled
The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.

```yaml
Type: SwitchParameter
Parameter Sets: ResourceGroupNameConfigStoreNamePropertiesTagsExpanded, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc
Aliases:

Required: False
Position: Named
Default value: False
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
The ARM resource tags.

```yaml
Type: Hashtable
Parameter Sets: ResourceGroupNameConfigStoreNamePropertiesTagsExpanded, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The Microsoft Azure subscription ID.

```yaml
Type: String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags, SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc
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

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore
## NOTES

## RELATED LINKS
