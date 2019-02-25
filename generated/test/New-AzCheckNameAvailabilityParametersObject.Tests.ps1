. "$PSScriptRoot/HttpPipelineMocking.ps1"

Describe 'New-AzCheckNameAvailabilityParametersObject' {
    It '__Generic' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
