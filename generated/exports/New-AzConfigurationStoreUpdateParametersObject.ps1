function New-AzConfigurationStoreUpdateParametersObject {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters')]
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [switch]
    ${Enabled},

    [Parameter(ParameterSetName='default', HelpMessage='The ARM resource tags.')]
    [hashtable]
    ${Tag})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreUpdateParametersObject', [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters }
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzConfigurationStoreUpdateParametersObject
.ForwardHelpCategory Cmdlet

#>

}

