using System.Runtime.Serialization;

namespace ApexaCoverage.DataContracts
{
    /// <summary>
    /// Insurance advisor data contract.
    /// </summary>
    [DataContract]
    public class Person : Entity
    {
        /// <summary>
        /// Advisor first name.
        /// </summary>
        [DataMember]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Advisor last name.
        /// </summary>
        [DataMember]
        public string LastName { get; set; } = string.Empty;
    }
}