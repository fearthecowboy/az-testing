function Update-AzConfigurationStore {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(HelpMessage='Run the command as a job')]
    [System.Management.Automation.SwitchParameter]
    ${AsJob},

    [Parameter(DontShow=$true, HelpMessage='Wait for .NET debugger to attach')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

    [Parameter(Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [System.String]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters for updating a configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters for updating a configuration store.')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreUpdateParameters]
    ${ConfigStoreUpdateParameters},

    [Parameter(HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(DontShow=$true, HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(DontShow=$true, HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(DontShow=$true, HelpMessage='The URI for the proxy server to use')]
    [System.Uri]
    ${Proxy},

    [Parameter(DontShow=$true, HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [System.Management.Automation.PSCredential]
    ${ProxyCredential},

    [Parameter(DontShow=$true, HelpMessage='Use the default credentials for the proxy')]
    [System.Management.Automation.SwitchParameter]
    ${ProxyUseDefaultCredentials},

    [Parameter(Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [System.String]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [System.Management.Automation.SwitchParameter]
    ${Enabled},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The ARM resource tags.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The ARM resource tags.')]
    [System.Collections.Hashtable]
    ${Tag},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [System.String]
    ${SubscriptionId}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PsCmdlet.ParameterSetName
        $variantSuffix = "_$parameterSet"
        if ("$parameterSet" -eq '__Generic' -or "$parameterSet" -eq '__AllParameterSets') {
            $variantSuffix = ''
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\Update-AzConfigurationStore$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}

<#
.ForwardHelpTargetName AppConfiguration.private\Update-AzConfigurationStore_ResourceGroupNameConfigStoreNamePropertiesTagsExpanded
.ForwardHelpCategory Cmdlet
.Description
Updates a configuration store with the specified parameters.
#>
}
