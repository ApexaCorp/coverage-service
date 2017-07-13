using ApexaCoverage.DataContracts;
using System;
using System.IO;

namespace ApexaCoverage
{
    public class ApexaCoverage : IApexaCoverage
    {
        public Person[] GetPersons(string firstName, string lastName, string authenticationKey)
        {
            if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName));
            if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new Person[]
            {
                new Person() { Id = "123", FirstName = "Bruce", LastName = "Wayne" },
                new Person() { Id = "456", FirstName = "Alfred", LastName = "PennyWorth" },
                new Person() { Id = "789", FirstName = "Dick", LastName = "Grayson" }
            };
        }

        public Company[] GetCompanies(string companyName, string authenticationKey)
        {
            if (string.IsNullOrEmpty(companyName)) throw new ArgumentNullException(nameof(companyName));
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new Company[]
            {
                new Company() { Id = "987", CompanyName = "Wayne Enterprises" },
                new Company() { Id = "654", CompanyName = "Ace Chemicals" },
                new Company() { Id = "321", CompanyName = "Palmer Technologies" }
            };
        }

        public Coverage[] GetCoverages(string Identifier, string authenticationKey)
        {
            if (string.IsNullOrEmpty(Identifier)) throw new ArgumentNullException(nameof(Identifier));
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new Coverage[]
            {
                new Coverage() { CertificateNumber = "c-123", PolicyNumber = "6156" },
                new Coverage() { CertificateNumber = "c-456", PolicyNumber = "9421" },
                new Coverage() { CertificateNumber = "c-789", PolicyNumber = "6813" },
            };
        }

        public CoverageDetails GetCoverageDetails(string certificateNumber, string policyNumber, string authenticationKey)
        {
            if (string.IsNullOrEmpty(certificateNumber)) throw new ArgumentNullException(nameof(certificateNumber));
            if (string.IsNullOrEmpty(policyNumber)) throw new ArgumentNullException(nameof(policyNumber));
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new CoverageDetails()
            {
                CertificateNumber = "c-123",
                PolicyNumber = "6156",
                FullName = "Bruce Wayne",
                FirmName = "Wayne Enterprises",
                AdditionalInsured = "Dick Grayson, Jason Todd, Tim Drake",
                Status = "Active",
                PerClaimAmount = 10000000.00M,
                AggregateAmount = 10000000.00M,
                HasFraudAmount = true,
                FraudAmount = 1000000.00M,
                Effective = DateTime.Now.AddYears(-1),
                Renewal = DateTime.Now.AddYears(1),
                Termination = DateTime.Now.AddYears(2),
                FileName = "Coverage-C-123_6156.pdf",
                Certificate = File.ReadAllBytes(@"C:\test\test.pdf")
            };
        }
    }
}
