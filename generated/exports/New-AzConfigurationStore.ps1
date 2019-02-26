<#
.Description
Creates a configuration store with the specified parameters.
#>
function New-AzConfigurationStore {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter()]
    [System.Management.Automation.SwitchParameter]
    # Run the command as a job
    ${AsJob},

    [Parameter(DontShow)]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', Mandatory, ValueFromPipeline)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore]
    # The configuration store along with all resource properties. The Configuration Store will have all information to begin utlizing it.
    ${ConfigStoreCreationParameters},

    [Parameter(Mandatory)]
    [System.String]
    # The name of the configuration store.
    ${ConfigStoreName},

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

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory)]
    [System.String]
    # The location of the resource. This cannot be changed after the resource is created.
    ${Location},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc')]
    [System.Collections.Hashtable]
    # The tags of the resource.
    ${Tag},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory)]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\New-AzConfigurationStore$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
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
