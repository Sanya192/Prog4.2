using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog4._2.Models {
    public class InternetService : ICloneable {
        /// <summary>
        /// The bank account attached to service.
        /// </summary>
        public string BankAccount { get; set; }
        /// <summary>
        /// The start date of the service.
        /// </summary>
        public DateTime ServiceStart { get; set; }
        /// <summary>
        /// The length of the service in months.
        /// </summary>
        public int ServiceLength { get; set; }
        /// <summary>
        /// The bandwith of the service
        /// </summary>
        public BandwithType Bandwith { get; set; }

        public InternetService(string bankAccount, DateTime serviceStart, int serviceLength, BandwithType bandwith) {
            BankAccount = bankAccount;
            ServiceStart = serviceStart;
            ServiceLength = serviceLength;
            Bandwith = bandwith;
        }

        public override string ToString() {
            return $"{Bandwith}csomag, kezdete: {ServiceStart}, időtartam: {ServiceLength} hónap";
        }

        /// <summary>
        /// Cloning the Internet Service.
        /// </summary>
        /// <returns>A different object with the same data.</returns>
        public object Clone() {
            InternetService temp = new InternetService(
                BankAccount.Clone() as string,
                ServiceStart,
                ServiceLength,
                Bandwith
                );
            return temp;
        }
    }
}
