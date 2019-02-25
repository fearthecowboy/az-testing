. "$PSScriptRoot/HttpPipelineMocking.ps1"

Describe 'New-AzConfigurationStoreObject' {
    It '__Generic' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
