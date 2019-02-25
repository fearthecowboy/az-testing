function Get-AzConfigurationStore {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreListResult')]
[CmdletBinding()]
param(
    [Parameter(DontShow=$true, HelpMessage='Wait for .NET debugger to attach')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

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

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [System.String]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [System.String]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='SkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [System.String]
    ${SkipToken},

    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionId', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
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

<#
.ForwardHelpTargetName AppConfiguration.private\Get-AzConfigurationStore___Generic
.ForwardHelpCategory Cmdlet
.Description
Lists the configuration stores for a given subscription.
#>
}
