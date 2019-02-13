function Remove-AzConfigurationStore {
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreName', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Run the command as a job')]
    [switch]
    ${AsJob},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameConfigStoreName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Remove-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameConfigStoreName' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Remove-AzConfigurationStore_ResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Remove-AzConfigurationStore_ResourceGroupNameConfigStoreName', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\Remove-AzConfigurationStore_ResourceGroupNameConfigStoreName
.ForwardHelpCategory Cmdlet

#>

}

