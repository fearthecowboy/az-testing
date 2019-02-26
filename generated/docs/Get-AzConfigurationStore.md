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

### -ConfigStoreName
The name of the configuration store.

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
The name of the resource group to which the container registry belongs.

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
A skip token is used to continue retrieving items after an operation returns a partial result.
If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.

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
The Microsoft Azure subscription ID.

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
## NOTES

## RELATED LINKS
