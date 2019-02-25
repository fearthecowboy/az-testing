namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The parameters used to regenerate an API key.</summary>
    public partial class RegenerateKeyParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IRegenerateKeyParameters
    {
        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the key to regenerate.</summary>
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
        /// <summary>Creates an new <see cref="RegenerateKeyParameters" /> instance.</summary>
        public RegenerateKeyParameters()
        {
        }
    }
    /// The parameters used to regenerate an API key.
    public partial interface IRegenerateKeyParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string Id { get; set; }
    }
}