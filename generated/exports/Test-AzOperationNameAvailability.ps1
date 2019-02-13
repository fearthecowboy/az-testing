function Test-AzOperationNameAvailability {
[OutputType('Microsoft.Azure.AzConfig.Models.INameAvailabilityStatus')]
[CmdletBinding(DefaultParameterSetName='NameAvailabilityNameType', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='NameAvailabilityNameType', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Parameters used for checking whether a resource name is available.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='Parameters used for checking whether a resource name is available.')]
    [Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters]
    ${CheckNameAvailabilityParameters},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='NameAvailabilityNameType', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', Mandatory=$true, HelpMessage='The name to check for availability.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The name to check for availability.')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='NameAvailabilityNameTypeExpanded', Mandatory=$true, HelpMessage='The resource type to check for name availability.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The resource type to check for name availability.')]
    [ArgumentCompleter([Microsoft.Azure.AzConfig.Support.ConfigurationResourceType])]
    [Microsoft.Azure.AzConfig.Support.ConfigurationResourceType]
    ${Type},

    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameType', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='NameAvailabilitySubscriptionIdNameTypeExpanded', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'NameAvailabilityNameTypeExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilityNameTypeExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'NameAvailabilityNameType' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilityNameType', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'NameAvailabilitySubscriptionIdNameTypeExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilitySubscriptionIdNameTypeExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'NameAvailabilitySubscriptionIdNameType' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilitySubscriptionIdNameType', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  default {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilityNameType', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

}
}

process
{
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end
{
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}
<#

.ForwardHelpTargetName AzconfigManagement.private\Test-AzOperationNameAvailability_NameAvailabilityNameType
.ForwardHelpCategory Cmdlet

#>

}

