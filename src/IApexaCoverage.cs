using ApexaCoverage.DataContracts;
using System;
using System.ServiceModel;

namespace ApexaCoverage
{
    /// <summary>
    /// Coverage provider web service contract.
    /// </summary>
    [ServiceContract]
    public interface IApexaCoverage
    {
        /// <summary>
        /// Retrieve all coverages associated with the advisor/organization identifier.
        /// This method allows us to retrieve all coverages for an advisor/organization so we could minimize the
        /// steps required to request multiple coverages from the provider for a better user experience.
        /// </summary>
        /// <param name="personIdentifier">The person (advisor/organization) identifier.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>List of coverages or an empty list if no coverages are associated with person identifier.</returns>
        [OperationContract]
        Coverage[] GetCoverages(string identifier, string authenticationKey);

        /// <summary>
        /// Retrieve details associated with specific coverage.
        /// </summary>
        /// <param name="certificateNumber">The coverage certificate number.</param>
        /// <param name="firstName">The first name of the policy holder.</param>
        /// <param name="lastName">The last name of the policy holder.</param>
        /// <param name="Identifier">The UserId of the policy holder.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>Coverage details.</returns>
        [OperationContract]
        CoverageDetails GetCoverageDetails(string certificateNumber, string firstName, string lastName, string identifier, string authenticationKey);
    }
}
