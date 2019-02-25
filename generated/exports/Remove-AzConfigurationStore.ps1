function Remove-AzConfigurationStore {
[OutputType('System.Boolean')]
[CmdletBinding(DefaultParameterSetName='ResourceGroupNameConfigStoreName', SupportsShouldProcess=$true, ConfirmImpact='Medium')]
param(
    [Parameter(HelpMessage='Run the command as a job')]
    [System.Management.Automation.SwitchParameter]
    ${AsJob},

    [Parameter(DontShow=$true, HelpMessage='Wait for .NET debugger to attach')]
    [System.Management.Automation.SwitchParameter]
    ${Break},

    [Parameter(Mandatory=$true, HelpMessage='The name of the configuration store.')]
    [System.String]
    ${ConfigStoreName},

    [Parameter(HelpMessage='The credentials, account, tenant, and subscription used for communication with Azure.')]
    [Alias('AzureRMContext','AzureCredential')]
    [ValidateNotNull()]
    [System.Object]
    ${DefaultProfile},

    [Parameter(DontShow=$true, HelpMessage='SendAsync Pipeline Steps to be appended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    ${HttpPipelineAppend},

    [Parameter(DontShow=$true, HelpMessage='SendAsync Pipeline Steps to be prepended to the front of the pipeline')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SendAsyncStep[]]
    ${HttpPipelinePrepend},

    [Parameter(HelpMessage='When specified, PassThru will force the cmdlet return a ''bool'' given that there isn''t a return type by default.')]
    [System.Management.Automation.SwitchParameter]
    ${PassThru},

    [Parameter(DontShow=$true, HelpMessage='The URI for the proxy server to use')]
    [System.Uri]
    ${Proxy},

    [Parameter(DontShow=$true, HelpMessage='Credentials for a proxy server to use for the remote call')]
    [ValidateNotNull()]
    [System.Management.Automation.PSCredential]
    ${ProxyCredential},

    [Parameter(DontShow=$true, HelpMessage='Use the default credentials for the proxy')]
    [System.Management.Automation.SwitchParameter]
    ${ProxyUseDefaultCredentials},

    [Parameter(Mandatory=$true, HelpMessage='The name of the resource group to which the container registry belongs.')]
    [System.String]
    ${ResourceGroupName},

    [Parameter(ParameterSetName='SubscriptionIdResourceGroupNameConfigStoreName', Mandatory=$true, HelpMessage='The Microsoft Azure subscription ID.')]
    [System.String]
    ${SubscriptionId}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PsCmdlet.ParameterSetName
        $variantSuffix = "_$parameterSet"
        if ("$parameterSet" -eq '__Generic' -or "$parameterSet" -eq '__AllParameterSets') {
            $variantSuffix = ''
        }
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand("AppConfiguration.private\Remove-AzConfigurationStore$variantSuffix", [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($myInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        throw
    }
}

end {
    try {
        $steppablePipeline.End()
    } catch {
        throw
    }
}

<#
.ForwardHelpTargetName AppConfiguration.private\Remove-AzConfigurationStore_ResourceGroupNameConfigStoreName
.ForwardHelpCategory Cmdlet
.Description
Deletes a configuration store.
#>
}
