function New-AzConfigurationStore {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='Run the command as a job')]
    [switch]
    ${AsJob},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The configuration store along with all resource properties. The Configuration Store will have all information to begin utlizing it.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The configuration store along with all resource properties. The Configuration Store will have all information to begin utlizing it.')]
    [Microsoft.Azure.AzConfig.Models.IConfigurationStore]
    ${ConfigStoreCreationParameters},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsProperties', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', Mandatory=$true, HelpMessage='The location of the resource. This cannot be changed after the resource is created.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory=$true, HelpMessage='The location of the resource. This cannot be changed after the resource is created.')]
    [string]
    ${Location},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', HelpMessage='The tags of the resource.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', HelpMessage='The tags of the resource.')]
    [hashtable]
    ${Tag},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStore_ResourceGroupNameConfigStoreNameLocationTagsPropertiesExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtcEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreNameLocationTagsPropertiesEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameConfigStoreNameLocationTagsProperties' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStore_ResourceGroupNameConfigStoreNameLocationTagsProperties', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStore_ResourceGroupNameConfigStoreNameLocationTagsProperties', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzConfigurationStore_ResourceGroupNameConfigStoreNameLocationTagsProperties
.ForwardHelpCategory Cmdlet

#>

}

