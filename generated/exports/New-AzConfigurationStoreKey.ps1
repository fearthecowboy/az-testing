function New-AzConfigurationStoreKey {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey')]
[CmdletBinding(DefaultParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
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

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters used to regenerate an API key.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters used to regenerate an API key.')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IRegenerateKeyParameters]
    ${RegenerateKeyParameters},

    [Parameter(Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [System.String]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The id of the key to regenerate.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The id of the key to regenerate.')]
    [System.String]
    ${Id},

    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\New-AzConfigurationStoreKey$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
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
.ForwardHelpTargetName AppConfiguration.private\New-AzConfigurationStoreKey_KeyResourceGroupNameConfigStoreNameIdExpanded
.ForwardHelpCategory Cmdlet
.Description
Regenerates an access key for the specified configuration store.
#>
}
