using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    /// <summary>
    /// Phiếu thu (Biên lai)
    /// </summary>
    [Table("Receipts")]
    public class Receipt : DomainEntity<string>, ISwitchable, IDateTracking
    {
        [Required]
        [StringLength(250)]
        public string NameOfPaymentApplicant { get; set; }

        [Required]
        public string ForReason { get; set; }

        [Required]
        public DateTime CollectionDate { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }
    }
}
