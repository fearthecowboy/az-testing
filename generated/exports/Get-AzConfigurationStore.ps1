<#
.Description
Lists the configuration stores for a given subscription.
#>
function Get-AzConfigurationStore {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult', 'Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='__NoParameters')]
param(
    [Parameter(DontShow)]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

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

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory)]
    [System.String]
    # The name of the configuration store.
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory)]
    [System.String]
    # The name of the resource group to which the container registry belongs.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory)]
    [Parameter(ParameterSetName='SkipToken', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory)]
    [System.String]
    # A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.
    ${SkipToken},

    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory)]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionId', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory)]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory)]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\Get-AzConfigurationStore$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
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
