using System;
using System.Runtime.Serialization;

namespace ApexaCoverage.DataContracts
{
    /// <summary>
    /// Coverage details data contract.
    /// </summary>
    [DataContract]
    public class CoverageDetails : Coverage
    {
        /// <summary>
        /// Advisor full name.
        /// This field should be empty if it is a corporate coverage.
        /// </summary>
        [DataMember]
        public string FullName { get; set; } = string.Empty;

        /// <summary>
        /// The legal name of the organization if corporate coverage.
        /// If the personal coverage has an organization associated with it then populate with organization name.
        /// </summary>
        [DataMember]
        public string FirmName { get; set; } = string.Empty;

        /// <summary>
        /// Comma seperated string of names associated with coverage.
        /// </summary>
        [DataMember]
        public string AdditionalInsured { get; set; }

        /// <summary>
        /// The coverage status.
        /// The following are the valid status fields:
        ///   Active
        ///   Expired
        ///   Inactive
        ///   Terminated
        /// </summary>
        [DataMember]
        public string Status { get; set; }

        /// <summary>
        /// The coverage per claim dollar amount.
        /// </summary>
        [DataMember]
        public decimal PerClaimAmount { get; set; }

        /// <summary>
        /// The coverage aggregate dollar amount.
        /// </summary>
        [DataMember]
        public decimal AggregateAmount { get; set; }

        /// <summary>
        /// This field indicates whether policy contains fraud coverage.
        /// Not all provinces require fraud coverage so this field controls
        /// whether FraudAmount value should be populated.
        /// </summary>
        [DataMember]
        public bool HasFraudAmount { get; set; }

        /// <summary>
        /// The coverage fraud dollar amount.
        /// This field should be null if HasFraudAmount is false.
        /// </summary>
        [DataMember]
        public decimal? FraudAmount { get; set; }

        /// <summary>
        /// The coverage effective date.
        /// </summary>
        [DataMember]
        public DateTime Effective { get; set; }

        /// <summary>
        /// The coverage renewal date.
        /// It was unclear whether providers would be able to provide
        /// the termination date or the renewal date.
        /// </summary>
        [DataMember]
        public DateTime? Renewal { get; set; }

        /// <summary>
        /// The coverage termination date.
        /// It was unclear whether providers would be able to provide
        /// the termination date or the renewal date.
        /// </summary>
        [DataMember]
        public DateTime? Termination { get; set; }

        /// <summary>
        /// The coverage certificate file name.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// The coverage certificate.
        /// </summary>
        [DataMember]
        public byte[] Certificate { get; set; }
    }
}