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
        /// Retrieve list of advisors associated with first and last name.
        /// With the identifier we can retrieve all active coverages in the event that a new coverage
        /// is issued with the coverage expires so we don't need to prompt the user for a new
        /// certificate/policy number.
        /// </summary>
        /// <param name="firstName">The advisor first name.</param>
        /// <param name="lastName">The advisor last name.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>List of advisors or an empty list if no advisors match search criteria.</returns>
        [OperationContract]
        Person[] GetPersons(string firstName, string lastName, string AuthenticationKey);

        /// <summary>
        /// Retrieve list of organizations associated with organization name.
        /// With the identifier we can retrieve all active coverages in the event that a new coverage
        /// is issued with the coverage expires so we don't need to prompt the user for a new
        /// certificate/policy number.
        /// </summary>
        /// <param name="companyName">The organization legal name.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>List of organizations or an empty list if no organizations match search criteria.</returns>
        [OperationContract]
        Company[] GetCompanies(string companyName, string AuthenticationKey);

        /// <summary>
        /// Retrieve all coverages associated with the advisor/organization identifier.
        /// This method allows us to retrieve all coverages for an advisor/organization so we could minimize the
        /// steps required to request multiple coverages from the provider for a better user experience.
        /// </summary>
        /// <param name="personIdentifier">The person (advisor/organization) identifier.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>List of coverages or an empty list if no coverages are associated with person identifier.</returns>
        [OperationContract]
        Coverage[] GetCoverages(string Identifier, string AuthenticationKey);

        /// <summary>
        /// Retrieve details associated with specific coverage.
        /// </summary>
        /// <param name="certificateNumber">The coverage certificate number.</param>
        /// <param name="policyNumber">The coverage policy number.</param>
        /// <param name="AuthenticationKey">API Key used for authorization.</param>
        /// <returns>Coverage details.</returns>
        [OperationContract]
        CoverageDetails GetCoverageDetails(string certificateNumber, string policyNumber, string AuthenticationKey);
    }
}
