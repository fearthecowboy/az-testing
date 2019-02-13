# Use the AzAccount module from here.

if( ($env:PSModulePath.indexOf($PSScriptRoot)) -eq -1 ) {
  write-host -fore green "Modifying the PSModulePath to use the Az.Accounts from here first."
  write-host -fore green "(for this session)"
  write-host -fore green ""
  
  $env:PSModulePath="$PSScriptRoot;$env:PSModulePath"

  write-host -fore white "$env:PSModulePath=`"$env:PSModulePath`""
} else {
  write-host -fore white "The PSModulePath already has this folder in it."
}

write-host -fore green "You should be good to go!"

