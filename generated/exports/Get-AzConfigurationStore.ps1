function Get-AzConfigurationStore {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='default')]
param(
    [Parameter(ParameterSetName='default', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='default', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='default', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='default', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='default', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='default', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='default', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SkipToken', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionId', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='SkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [string]
    ${SkipToken},

    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='ResourceGroupSubscriptionIdResourceGroupNameSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionId', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdSkipToken', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ResourceGroupNameConfigStoreNameEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_ResourceGroupNameConfigStoreNameEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_SkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupResourceGroupNameSkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_ResourceGroupResourceGroupNameSkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionId' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_SubscriptionId', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupSubscriptionIdResourceGroupNameSkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_ResourceGroupSubscriptionIdResourceGroupNameSkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameConfigStoreNameEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreNameEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupResourceGroupName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_ResourceGroupResourceGroupName', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'default' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdSkipToken' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_SubscriptionIdSkipToken', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupSubscriptionIdResourceGroupName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore_ResourceGroupSubscriptionIdResourceGroupName', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzConfigurationStore', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\Get-AzConfigurationStore
.ForwardHelpCategory Cmdlet

#>

}

