@{
# region identity
  ModuleVersion="1.0"
  Description=""
  PowerShellVersion="3.0"
# endregion

# region private data
  PrivateData = @{
    # Package Metadata for PowerShellGet
    PSData = @{
      # Tags applied to this module.These help with module discovery in online galleries.
      Tags = ''

      # A URL to the license for this module.
      LicenseUri = ''

      # A URL to the main website for this project.
      ProjectUri = ''

      # A URL to an icon representing this module.
      # IconUri = ''

      # ReleaseNotes of this module
      ReleaseNotes = ''

      # External dependent modules of this module
      # ExternalModuleDependencies = ''
    } # End of PSData hashtable
  } # End of PrivateData hashtable
# endregion

# region exports
  # don't export any actual cmdlets by default
  CmdletsToExport = ''

  # export the functions that we loaded(these are the proxy cmdlets)
  FunctionsToExport = '*-*'
# endregion

# region modules
  # Warning: This region is code-generated and will get replaced upon regeneration.

  NestedModules = @(
    "./bin/AzconfigManagement.private.dll"
    "AzconfigManagement.psm1"
  )

  RequiredModules = @(
    # @({ModuleName="Az.Accounts", ModuleVersion="2.0",Guid="00000000-0000-0000-0000-000000000000"})
  )

  FormatsToProcess = @(
    "./AzconfigManagement.format.ps1xml"
  )
# endregion

}