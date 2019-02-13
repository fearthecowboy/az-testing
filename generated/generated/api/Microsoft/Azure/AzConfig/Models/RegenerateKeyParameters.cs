namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The parameters used to regenerate an API key.</summary>
    public partial class RegenerateKeyParameters : Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters
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
    public partial interface IRegenerateKeyParameters : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        string Id { get; set; }
    }
}