function Test-AzConfigurationStoreNameAvailability {
[OutputType('Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.INameAvailabilityStatus')]
[CmdletBinding(DefaultParameterSetName='NameAvailabilityNameTypeExpanded', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(DontShow=$true, HelpMessage='Wait for .NET debugger to attach')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

    [Parameter(ParameterSetName='NameAvailabilityNameType', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Parameters used for checking whether a resource name is available.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Parameters used for checking whether a resource name is available.')]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ICheckNameAvailabilityParameters]
    ${CheckNameAvailabilityParameters},

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

    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', Mandatory=$true, HelpMessage='The name to check for availability.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The name to check for availability.')]
    [System.String]
    ${Name},

    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', Mandatory=$true, HelpMessage='The resource type to check for name availability.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The resource type to check for name availability.')]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType])]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType]
    ${Type},

    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\Test-AzConfigurationStoreNameAvailability$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
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
.ForwardHelpTargetName AppConfiguration.private\Test-AzConfigurationStoreNameAvailability_NameAvailabilityNameTypeExpanded
.ForwardHelpCategory Cmdlet
.Description
Checks whether the configuration store name is available for use.
#>
}
