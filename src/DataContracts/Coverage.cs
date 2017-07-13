using System.Runtime.Serialization;

namespace ApexaCoverage.DataContracts
{
    /// <summary>
    /// Coverage base class data contract.
    /// The certificate and policy number were both included since it was unclear if all
    /// providers would be able to provide both and/or whether either field individually would
    /// be a unique identifier for the coverage.
    /// </summary>
    [DataContract]
    public class Coverage
    {
        /// <summary>
        /// Coverage certificate number.
        /// </summary>
        [DataMember]
        public string CertificateNumber { get; set; } = string.Empty;

        /// <summary>
        /// Coverage policy number.
        /// </summary>
        [DataMember]
        public string PolicyNumber { get; set; } = string.Empty;
    }
}
