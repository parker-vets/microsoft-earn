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
    
    public partial class Partner
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partner()
        {
            this.ARCHIVE_PartnerCards = new HashSet<ARCHIVE_PartnerCards>();
            this.ARCHIVE_PartnerUsers = new HashSet<ARCHIVE_PartnerUsers>();
            this.Authorizations = new HashSet<Authorization>();
            this.ClaimedDealBatches = new HashSet<ClaimedDealBatch>();
            this.DealPartnerMerchantIds = new HashSet<DealPartnerMerchantId>();
            this.PartnerDeals = new HashSet<PartnerDeal>();
            this.TransactionLinks = new HashSet<TransactionLink>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARCHIVE_PartnerCards> ARCHIVE_PartnerCards { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARCHIVE_PartnerUsers> ARCHIVE_PartnerUsers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Authorization> Authorizations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClaimedDealBatch> ClaimedDealBatches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DealPartnerMerchantId> DealPartnerMerchantIds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerDeal> PartnerDeals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionLink> TransactionLinks { get; set; }
    }
}