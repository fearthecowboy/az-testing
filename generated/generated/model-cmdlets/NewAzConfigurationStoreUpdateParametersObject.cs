namespace Microsoft.Azure.AzConfig.ModelCmdlets
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ConfigurationStoreUpdateParameters" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AzConfigurationStoreUpdateParametersObject")]
    [System.Management.Automation.OutputType(typeof(Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters))]
    public class NewAzConfigurationStoreUpdateParametersObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ConfigurationStoreUpdateParameters" /></summary>
        private Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters _configurationStoreUpdateParameters = new Microsoft.Azure.AzConfig.Models.ConfigurationStoreUpdateParameters();
        /// <summary>
        /// The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.")]
        public System.Management.Automation.SwitchParameter Enabled
        {
            set
            {
                _configurationStoreUpdateParameters.Properties = _configurationStoreUpdateParameters.Properties ?? new Microsoft.Azure.AzConfig.Models.ConfigurationStorePropertiesUpdateParameters();
                _configurationStoreUpdateParameters.Properties.Enabled = value.ToBool();
            }
        }
        /// <summary>The ARM resource tags.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The ARM resource tags.")]
        public System.Collections.Hashtable Tag
        {
            set
            {
                _configurationStoreUpdateParameters.Tag = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_configurationStoreUpdateParameters);
        }
    }
}