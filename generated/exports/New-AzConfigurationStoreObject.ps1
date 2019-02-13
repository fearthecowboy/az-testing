function New-AzConfigurationStoreObject {
[OutputType('Microsoft.Azure.AzConfig.Models.IConfigurationStore')]
[CmdletBinding()]
param(
    [Parameter(ParameterSetName='default', Mandatory=$true, HelpMessage='The location of the resource. This cannot be changed after the resource is created.')]
    [string]
    ${Location},

    [Parameter(ParameterSetName='default', HelpMessage='The tags of the resource.')]
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
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand('AzconfigManagement.private\New-AzConfigurationStoreObject', [System.Management.Automation.CommandTypes]::Cmdlet)
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

.ForwardHelpTargetName AzconfigManagement.private\New-AzConfigurationStoreObject
.ForwardHelpCategory Cmdlet

#>

}

