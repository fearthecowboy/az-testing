function Get-AzConfigurationStoreKey {
[OutputType('Microsoft.Azure.AzConfig.Models.IApiKeyListResult')]
[CmdletBinding(DefaultParameterSetName='KeysResourceGroupNameConfigStoreName', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='KeysResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [string]
    ${SkipToken},

    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'KeysResourceGroupNameConfigStoreNameSkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysResourceGroupNameConfigStoreNameSkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeysSubscriptionIdResourceGroupNameConfigStoreName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysSubscriptionIdResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'KeysResourceGroupNameConfigStoreName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\Get-AzConfigurationStoreKey_KeysResourceGroupNameConfigStoreName
.ForwardHelpCategory Cmdlet

#>

}

