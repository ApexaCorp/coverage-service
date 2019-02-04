using ApexaCoverage.DataContracts;
using System;
using System.IO;

namespace ApexaCoverage
{
    public class ApexaCoverage : IApexaCoverage
    {
        public Coverage[] GetCoverages(string identifier, string authenticationKey)
        {
            if (string.IsNullOrEmpty(identifier)) throw new ArgumentNullException(nameof(identifier));
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new Coverage[]
            {
                new Coverage() { CertificateNumber = "c-123", PolicyNumber = "6156" },
                new Coverage() { CertificateNumber = "c-456", PolicyNumber = "9421" },
                new Coverage() { CertificateNumber = "c-789", PolicyNumber = "6813" },
            };
        }

        public CoverageDetails GetCoverageDetails(string certificateNumber, string firstName, string lastName, string identifier, string authenticationKey)
        {
            if (string.IsNullOrEmpty(certificateNumber)) throw new ArgumentNullException(nameof(certificateNumber));
            if (string.IsNullOrEmpty(identifier))
            {
                if (string.IsNullOrEmpty(firstName)) throw new ArgumentNullException(nameof(firstName));
                if (string.IsNullOrEmpty(lastName)) throw new ArgumentNullException(nameof(lastName));
            }
            if (string.IsNullOrEmpty(authenticationKey)) throw new ArgumentNullException(nameof(authenticationKey));

            return new CoverageDetails()
            {
                CertificateNumber = "c-123",
                PolicyNumber = "6156",
                FirstName = "Bruce",
                LastName = "Wayne",
                Identifier = "BW123",
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
