function Get-AzConfigurationStoreKey {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKeyListResult')]
[CmdletBinding(DefaultParameterSetName='KeysResourceGroupNameConfigStoreName', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(DontShow=$true, HelpMessage='Wait for .NET debugger to attach')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

    [Parameter(Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [System.String]
    ${ConfigStoreName},

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

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [System.String]
    ${SkipToken},

    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\Get-AzConfigurationStoreKey$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
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
.ForwardHelpTargetName AppConfiguration.private\Get-AzConfigurationStoreKey_KeysResourceGroupNameConfigStoreName
.ForwardHelpCategory Cmdlet
.Description
Lists the access key for the specified configuration store.
#>
}
