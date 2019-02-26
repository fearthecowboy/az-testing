<#
.Description
Updates a configuration store with the specified parameters.
#>
function Update-AzConfigurationStore {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(Mandatory)]
    [System.String]
    # The name of the configuration store.
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreUpdateParameters]
    # The parameters for updating a configuration store.
    ${ConfigStoreUpdateParameters},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials},

    [Parameter(Mandatory)]
    [System.String]
    # The name of the resource group to which the container registry belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc')]
    [System.Management.Automation.SwitchParameter]
    # The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.
    ${ConfigurationStorePropertiesUpdateParametersEnabled},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc')]
    [System.Collections.Hashtable]
    # The ARM resource tags.
    ${Tag},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', Mandatory)]
    [System.String]
    # The Microsoft Azure subscription ID.
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
        if ("$parameterSet" -eq '__NoParameters' -or "$parameterSet" -eq '__AllParameterSets') {
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
}
