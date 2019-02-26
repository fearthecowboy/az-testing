---
external help file: AppConfiguration-help.xml
Module Name: AppConfiguration
online version:
schema: 2.0.0
---

# New-AzConfigurationStoreKey

## SYNOPSIS

## SYNTAX

### KeyResourceGroupNameConfigStoreNameIdExpanded (Default)
```
New-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <Object>] -ResourceGroupName <String>
 [-Id <String>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeySubscriptionIdResourceGroupNameConfigStoreNameId
```
New-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <Object>]
 -RegenerateKeyParameters <IRegenerateKeyParameters> -ResourceGroupName <String> -SubscriptionId <String>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### KeyResourceGroupNameConfigStoreNameId
```
New-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <Object>]
 -RegenerateKeyParameters <IRegenerateKeyParameters> -ResourceGroupName <String> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
```
New-AzConfigurationStoreKey -ConfigStoreName <String> [-DefaultProfile <Object>] -ResourceGroupName <String>
 [-Id <String>] -SubscriptionId <String> [-WhatIf] [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Regenerates an access key for the specified configuration store.

## EXAMPLES

### Example 1
```powershell
PS C:\> {{ Add example code here }}
```

{{ Add example description here }}

## PARAMETERS

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

### -RegenerateKeyParameters
The parameters used to regenerate an API key.

```yaml
Type: IRegenerateKeyParameters
Parameter Sets: KeySubscriptionIdResourceGroupNameConfigStoreNameId, KeyResourceGroupNameConfigStoreNameId
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
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

### -Id
The id of the key to regenerate.

```yaml
Type: String
Parameter Sets: KeyResourceGroupNameConfigStoreNameIdExpanded, KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
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
Parameter Sets: KeySubscriptionIdResourceGroupNameConfigStoreNameId, KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded
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

### Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey
## NOTES

## RELATED LINKS
