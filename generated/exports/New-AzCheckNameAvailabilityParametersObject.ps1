function New-AzCheckNameAvailabilityParametersObject {
[OutputType('Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters')]
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The name to check for availability.')]
    [string]
    ${Name},

    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The resource type to check for name availability.')]
    [ArgumentCompleter([Microsoft.Azure.AzConfig.Support.ConfigurationResourceType])]
    [Microsoft.Azure.AzConfig.Support.ConfigurationResourceType]
    ${Type})

begin
{
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer))
        {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzCheckNameAvailabilityParametersObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzCheckNameAvailabilityParametersObject
.ForwardHelpCategory Cmdlet

#>

}

