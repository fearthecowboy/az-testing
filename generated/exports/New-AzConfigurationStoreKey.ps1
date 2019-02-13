function New-AzConfigurationStoreKey {
[OutputType('Microsoft.Azure.AzConfig.Models.IApiKey')]
[CmdletBinding(DefaultParameterSetName='KeyResourceGroupNameConfigStoreNameId', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters used to regenerate an API key.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters used to regenerate an API key.')]
    [Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters]
    ${RegenerateKeyParameters},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='KeyResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The id of the key to regenerate.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', HelpMessage='The id of the key to regenerate.')]
    [string]
    ${Id},

    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameId', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'KeySubscriptionIdResourceGroupNameConfigStoreNameId' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreKey_KeySubscriptionIdResourceGroupNameConfigStoreNameId', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreKey_KeySubscriptionIdResourceGroupNameConfigStoreNameIdExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeyResourceGroupNameConfigStoreNameId' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreKey_KeyResourceGroupNameConfigStoreNameId', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeyResourceGroupNameConfigStoreNameIdExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreKey_KeyResourceGroupNameConfigStoreNameIdExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreKey_KeyResourceGroupNameConfigStoreNameId', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzConfigurationStoreKey_KeyResourceGroupNameConfigStoreNameId
.ForwardHelpCategory Cmdlet

#>

}

