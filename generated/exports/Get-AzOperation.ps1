function Get-AzOperation {
[OutputType('Microsoft.Azure.AzConfig.Models.IOperationDefinitionListResult')]
[CmdletBinding(DefaultParameterSetName='Etc')]
param(
    [Parameter(ParameterSetName='Etc', HelpMessage='Wait for .NET debugger to attach')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='Wait for .NET debugger to attach')]
    [switch]
    ${Break},

    [Parameter(ParameterSetName='Etc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(ParameterSetName='Etc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(ParameterSetName='Etc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.AzConfig.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(ParameterSetName='Etc', HelpMessage='The URI for the proxy server to use')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='The URI for the proxy server to use')]
    [uri]
    ${Proxy},

    [Parameter(ParameterSetName='Etc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [pscredential]
    ${ProxyCredential},

    [Parameter(ParameterSetName='Etc', HelpMessage='Use the default credentials for the proxy')]
    [Parameter(ParameterSetName='SkipTokenEtc', HelpMessage='Use the default credentials for the proxy')]
    [switch]
    ${ProxyUseDefaultCredentials},

    [Parameter(ParameterSetName='SkipTokenEtc', Mandatory=$true, HelpMessage='A skip token is used to continue retrieving items after an operation returns a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skipToken parameter that specifies a starting point to use for subsequent calls.')]
    [string]
    ${SkipToken})

begin
{
  switch ($PsCmdlet.ParameterSetName) { 

  'Etc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzOperation_Etc', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }

}

  'SkipTokenEtc' {

    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzOperation_SkipTokenEtc', [System.Management.Automation.CommandTypes]::Cmdlet)
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\Get-AzOperation_Etc', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\Get-AzOperation_Etc
.ForwardHelpCategory Cmdlet

#>

}

