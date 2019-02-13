function New-AzConfigurationStorePropertiesUpdateParametersObject {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters')]
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', HelpMessage='The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.')]
    [switch]
    ${Enabled})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStorePropertiesUpdateParametersObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzConfigurationStorePropertiesUpdateParametersObject
.ForwardHelpCategory Cmdlet

#>

}

