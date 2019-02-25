---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version:
schema: 2.0.0
---

# New-AzConfigurationStore

## SYNOPSIS
## SYNTAX

### ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded (Default)
```
New-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -Location <String>
 [-Tag <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc
```
New-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreCreationParameters <IConfigurationStore>
 -ConfigStoreName <String> [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -SubscriptionId <String> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### ResourceGroupNameConfigStoreNameLocationTagsProperties
```
New-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreCreationParameters <IConfigurationStore>
 -ConfigStoreName <String> [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc
```
New-AzConfigurationStore [-AsJob] [-Break] -ConfigStoreName <String> [-DefaultProfile <Object>]
 [-HttpPipelineAppend <SendAsyncStep[]>] [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>]
 [-ProxyCredential <PSCredential>] [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -Location <String>
 [-Tag <Hashtable>] -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Creates a configuration store with the specified parameters.

Regenerates an access key for the specified configuration store.

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

### -ConfigStoreCreationParameters
The configuration store along with all resource properties.
The Configuration Store will have all information to begin utlizing it.

```yaml
Type: IConfigurationStore
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc, ResourceGroupNameConfigStoreNameLocationTagsProperties
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ConfigStoreName
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

### -DefaultProfile
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

### -Location
The location of the resource.
This cannot be changed after the resource is created.

```yaml
Type: String
Parameter Sets: ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded, SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Tag
The tags of the resource.

```yaml
Type: Hashtable
Parameter Sets: ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded, SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
```yaml
Type: String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc, SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
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
### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey
## NOTES

## RELATED LINKS
