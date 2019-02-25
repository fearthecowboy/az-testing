. "$PSScriptRoot/HttpPipelineMocking.ps1"

Describe 'Get-AzOperation' {
    It 'Etc' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'SkipTokenEtc' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
