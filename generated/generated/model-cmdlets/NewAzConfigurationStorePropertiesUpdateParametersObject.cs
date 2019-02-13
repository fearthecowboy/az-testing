namespace Microsoft.Azure.AzConfig.ModelCmdlets
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ConfigurationStorePropertiesUpdateParameters" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AzConfigurationStorePropertiesUpdateParametersObject")]
    [System.Management.Automation.OutputType(typeof(Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters))]
    public class NewAzConfigurationStorePropertiesUpdateParametersObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ConfigurationStorePropertiesUpdateParameters" /></summary>
        private Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters _configurationStorePropertiesUpdateParameters = new Microsoft.Azure.AzConfig.Models.ConfigurationStorePropertiesUpdateParameters();
        /// <summary>
        /// The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.")]
        public System.Management.Automation.SwitchParameter Enabled
        {
            set
            {
                _configurationStorePropertiesUpdateParameters.Enabled = value.ToBool();
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_configurationStorePropertiesUpdateParameters);
        }
    }
}