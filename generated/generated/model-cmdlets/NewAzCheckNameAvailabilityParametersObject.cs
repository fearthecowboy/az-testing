namespace Microsoft.Azure.AzConfig.ModelCmdlets
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="CheckNameAvailabilityParameters" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AzCheckNameAvailabilityParametersObject")]
    [System.Management.Automation.OutputType(typeof(Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters))]
    public class NewAzCheckNameAvailabilityParametersObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="CheckNameAvailabilityParameters" /></summary>
        private Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters _checkNameAvailabilityParameters = new Microsoft.Azure.AzConfig.Models.CheckNameAvailabilityParameters();
        /// <summary>The name to check for availability.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The name to check for availability.")]
        public string Name
        {
            set
            {
                _checkNameAvailabilityParameters.Name = value;
            }
        }
        /// <summary>The resource type to check for name availability.</summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The resource type to check for name availability.")]
        [System.Management.Automation.ArgumentCompleter(typeof(Microsoft.Azure.AzConfig.Support.ConfigurationResourceType))]
        public Microsoft.Azure.AzConfig.Support.ConfigurationResourceType Type
        {
            set
            {
                _checkNameAvailabilityParameters.Type = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_checkNameAvailabilityParameters);
        }
    }
}