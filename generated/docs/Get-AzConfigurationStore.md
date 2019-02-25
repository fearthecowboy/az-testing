---
external help file: AppConfiguration.private.dll-help.xml
Module Name: AppConfiguration
online version:
schema: 2.0.0
---

# Get-AzConfigurationStore

## SYNOPSIS
## SYNTAX

### SubscriptionIdResourceGroupNameConfigStoreNameEtc
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ConfigStoreName <String> -ResourceGroupName <String> -SubscriptionId <String>
 [<CommonParameters>]
```

### ResourceGroupNameConfigStoreNameEtc
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ConfigStoreName <String> -ResourceGroupName <String> [<CommonParameters>]
```

### ResourceGroupSubscriptionIdResourceGroupNameSkipToken
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -SkipToken <String> -SubscriptionId <String>
 [<CommonParameters>]
```

### ResourceGroupSubscriptionIdResourceGroupName
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -SubscriptionId <String> [<CommonParameters>]
```

### ResourceGroupResourceGroupNameSkipToken
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> -SkipToken <String> [<CommonParameters>]
```

### ResourceGroupResourceGroupName
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -ResourceGroupName <String> [<CommonParameters>]
```

### SubscriptionIdSkipToken
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -SkipToken <String> -SubscriptionId <String> [<CommonParameters>]
```

### SkipToken
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -SkipToken <String> [<CommonParameters>]
```

### SubscriptionId
```
Get-AzConfigurationStore [-Break] [-DefaultProfile <Object>] [-HttpPipelineAppend <SendAsyncStep[]>]
 [-HttpPipelinePrepend <SendAsyncStep[]>] [-Proxy <Uri>] [-ProxyCredential <PSCredential>]
 [-ProxyUseDefaultCredentials] -SubscriptionId <String> [<CommonParameters>]
```

## DESCRIPTION
Lists the configuration stores for a given subscription.

Lists the access key for the specified configuration store.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

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

### -ConfigStoreName
```yaml
Type: String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNameEtc, ResourceGroupNameConfigStoreNameEtc
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
```yaml
Type: String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNameEtc, ResourceGroupNameConfigStoreNameEtc, ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupSubscriptionIdResourceGroupName, ResourceGroupResourceGroupNameSkipToken, ResourceGroupResourceGroupName
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SkipToken
```yaml
Type: String
Parameter Sets: ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupResourceGroupNameSkipToken, SubscriptionIdSkipToken, SkipToken
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
```yaml
Type: String
Parameter Sets: SubscriptionIdResourceGroupNameConfigStoreNameEtc, ResourceGroupSubscriptionIdResourceGroupNameSkipToken, ResourceGroupSubscriptionIdResourceGroupName, SubscriptionIdSkipToken, SubscriptionId
Aliases:

Required: True
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

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult
### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore
### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKeyListResult
## NOTES

## RELATED LINKS
