using System.Runtime.Serialization;

namespace ApexaCoverage.DataContracts
{
    /// <summary>
    /// Insurance organization data contract.
    /// </summary>
    [DataContract]
    public class Company : Entity
    {
        /// <summary>
        /// Legal name of organization.
        /// </summary>
        [DataMember]
        public string CompanyName { get; set; } = string.Empty;
    }
}