using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC_Admin.Models
{
    internal class ModelUserDetails
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Status { get; set; }
        public bool? IsVerified { get; set; }
        public string? StripeCustomerId { get; set; }
        public int? PlanId { get; set; }
        public string? PlanRegisterDate { get; set; }
        public string? PlanExpireDate { get; set; }
        public string? CreatedDate { get; set; }
        public string? UpdatedDate { get; set; }
        public string? MigrateStatus { get; set; }
        public string? MigrateDate { get; set; }
        public bool? AcceptTermsAndConditions { get; set; }
        public bool? ViewPromotion { get; set; }
        public int? PaymentFailedAttempts { get; set; }
        public string? LastPaymentFailedDate { get; set; }
        public List<Dictionary<string, string?>>? ChargeRecords { get; set; }
        public int? TotalClipCount { get; set; }
        public int? TotalFavouriteCount { get; set; }
        public int? TotalEncryptedClipCount { get; set; }
        public string? SubscriptionCreatedDate { get; set; }
    }
}
