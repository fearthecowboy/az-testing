function Update-AzConfigurationStore {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStore')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Run the command as a job')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='Run the command as a job')]
    [switch]
    ${AsJob},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [string]
    ${ConfigStoreName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters for updating a configuration store.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, ValueFromPipeline=$true, HelpMessage='The parameters for updating a configuration store.')]
    [Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters]
    ${ConfigStoreUpdateParameters},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [string]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [switch]
    ${Enabled},

    [Parameter(ParameterSetName='ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', HelpMessage='The ARM resource tags.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', HelpMessage='The ARM resource tags.')]
    [hashtable]
    ${Tag},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [string]
    ${SubscriptionId})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Update-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTags', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Update-AzConfigurationStore_SubscriptionIdResourceGroupNameConfigStoreNamePropertiesTagsExpandedEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameConfigStoreNamePropertiesTags' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Update-AzConfigurationStore_ResourceGroupNameConfigStoreNamePropertiesTags', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'ResourceGroupNameConfigStoreNamePropertiesTagsExpanded' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Update-AzConfigurationStore_ResourceGroupNameConfigStoreNamePropertiesTagsExpanded', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Update-AzConfigurationStore_ResourceGroupNameConfigStoreNamePropertiesTags', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\Update-AzConfigurationStore_ResourceGroupNameConfigStoreNamePropertiesTags
.ForwardHelpCategory Cmdlet

#>

}

