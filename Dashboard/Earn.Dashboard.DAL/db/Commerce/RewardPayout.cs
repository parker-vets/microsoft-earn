//
// Copyright (c) Microsoft Corporation. All rights reserved. 
// Licensed under the MIT license. See LICENSE.txt file in the project root for full license information.
//

// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>

namespace Earn.Dashboard.DAL.db.Commerce
{
    using System;
    using System.Collections.Generic;
    
    public partial class RewardPayout
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RewardPayout()
        {
            this.Referrals = new HashSet<Referral>();
            this.TrackedRedemptionRewards = new HashSet<TrackedRedemptionReward>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid RewardId { get; set; }
        public int RewardReasonId { get; set; }
        public System.Guid PayeeId { get; set; }
        public int PayeeTypeId { get; set; }
        public int RewardPayoutStatusId { get; set; }
        public System.DateTime PayoutScheduledDateUtc { get; set; }
        public Nullable<System.DateTime> PayoutFinalizedDateUtc { get; set; }
        public string AgentId { get; set; }
        public Nullable<int> AgentTypeId { get; set; }
        public int Amount { get; set; }
        public string Explanation { get; set; }
        public string IssuedBy { get; set; }
    
        public virtual PayeeType PayeeType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Referral> Referrals { get; set; }
        public virtual Reward Reward { get; set; }
        public virtual RewardPayoutStatu RewardPayoutStatu { get; set; }
        public virtual RewardReason RewardReason { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrackedRedemptionReward> TrackedRedemptionRewards { get; set; }
    }
}