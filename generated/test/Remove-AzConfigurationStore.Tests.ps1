. "$PSScriptRoot/HttpPipelineMocking.ps1"

Describe 'Remove-AzConfigurationStore' {
    It 'ResourceGroupNameConfigStoreName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SubscriptionIdResourceGroupNameConfigStoreName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
