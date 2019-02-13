namespace Microsoft.Azure.AzConfig.ModelCmdlets
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Cmdlet to create an in-memory instance of the <see cref="ConfigurationStore" /> object.
    /// </summary>
    [System.Management.Automation.Cmdlet(System.Management.Automation.VerbsCommon.New, @"AzConfigurationStoreObject")]
    [System.Management.Automation.OutputType(typeof(Microsoft.Azure.AzConfig.Models.IConfigurationStore))]
    public class NewAzConfigurationStoreObject : System.Management.Automation.PSCmdlet
    {
        /// <summary>Backing field for <see cref="ConfigurationStore" /></summary>
        private Microsoft.Azure.AzConfig.Models.IConfigurationStore _configurationStore = new Microsoft.Azure.AzConfig.Models.ConfigurationStore();
        /// <summary>
        /// The location of the resource. This cannot be changed after the resource is created.
        /// </summary>
        [System.Management.Automation.Parameter(Mandatory = true, HelpMessage = "The location of the resource. This cannot be changed after the resource is created.")]
        public string Location
        {
            set
            {
                _configurationStore.Location = value;
            }
        }
        /// <summary>The tags of the resource.</summary>
        [System.Management.Automation.Parameter(Mandatory = false, HelpMessage = "The tags of the resource.")]
        public System.Collections.Hashtable Tag
        {
            set
            {
                _configurationStore.Tag = value;
            }
        }
        /// <summary>Performs execution of the command.</summary>

        protected override void ProcessRecord()
        {
            WriteObject(_configurationStore);
        }
    }
}