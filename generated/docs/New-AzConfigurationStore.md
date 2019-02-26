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
New-AzConfigurationStore [-AsJob] -ConfigStoreName <String> [-DefaultProfile <Object>]
 -ResourceGroupName <String> -Location <String> [-Tag <Hashtable>] [-WhatIf] [-Confirm] [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc
```
New-AzConfigurationStore [-AsJob] -ConfigStoreCreationParameters <IConfigurationStore>
 -ConfigStoreName <String> [-DefaultProfile <Object>] -ResourceGroupName <String> -SubscriptionId <String>
 [-WhatIf] [-Confirm] [<CommonParameters>]
```

### ResourceGroupNameConfigStoreNameLocationTagsProperties
```
New-AzConfigurationStore [-AsJob] -ConfigStoreCreationParameters <IConfigurationStore>
 -ConfigStoreName <String> [-DefaultProfile <Object>] -ResourceGroupName <String> [-WhatIf] [-Confirm]
 [<CommonParameters>]
```

### SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc
```
New-AzConfigurationStore [-AsJob] -ConfigStoreName <String> [-DefaultProfile <Object>]
 -ResourceGroupName <String> -Location <String> [-Tag <Hashtable>] -SubscriptionId <String> [-WhatIf]
 [-Confirm] [<CommonParameters>]
```

## DESCRIPTION
Creates a configuration store with the specified parameters.

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
The Microsoft Azure subscription ID.

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
