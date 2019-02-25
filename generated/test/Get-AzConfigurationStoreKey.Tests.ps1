. "$PSScriptRoot/HttpPipelineMocking.ps1"

Describe 'Get-AzConfigurationStoreKey' {
    It 'KeysResourceGroupNameConfigStoreName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'KeysResourceGroupNameConfigStoreNameSkipToken' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'KeysSubscriptionIdResourceGroupNameConfigStoreName' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'KeysSubscriptionIdResourceGroupNameConfigStoreNameSkipToken' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
