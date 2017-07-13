using System.Runtime.Serialization;

namespace ApexaCoverage.DataContracts
{
    /// <summary>
    /// Entity base class data contract.
    /// </summary>
    [DataContract]
    public class Entity
    {
        /// <summary>
        /// Unique identifier for advisor/organization.
        /// </summary>
        [DataMember]
        public string Id { get; set; }
    }
}