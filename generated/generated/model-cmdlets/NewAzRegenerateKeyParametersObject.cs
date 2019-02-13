namespace Microsoft.Azure.AzConfig.ModelCmdlets
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="RegenerateKeyParameters" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AzRegenerateKeyParametersObject")]
    [System.Management.Automation.OutputType(typeof(Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters))]
    public class NewAzRegenerateKeyParametersObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="RegenerateKeyParameters" /></summary>
        private Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters _regenerateKeyParameters = new Microsoft.Azure.AzConfig.Models.RegenerateKeyParameters();
        /// <summary>The id of the key to regenerate.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The id of the key to regenerate.")]
        public string Id
        {
            set
            {
                _regenerateKeyParameters.Id = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_regenerateKeyParameters);
        }
    }
}