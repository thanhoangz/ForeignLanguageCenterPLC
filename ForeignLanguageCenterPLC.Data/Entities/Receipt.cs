﻿using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
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
        [StringLength(100)]
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

        /* Foreign Key */

        [Required]
        public int ReceiptTypeId { get; set; }

        /// <summary>
        /// Nhân viên tạo phiếu, chi trả
        /// </summary>
        [Required]
        public string PersonnelId { get; set; }


        [Required]
        public int UserId { get; set; }

        /*Reference Table*/

        [ForeignKey("PersonnelId")]
        public virtual Personnel Personnel { get; set; }


        [ForeignKey("UserId")]
        public virtual User User { get; set; }


        [ForeignKey("ReceiptTypeId")]
        public virtual ReceiptType ReceiptType { get; set; }
        /*List of References */

        public virtual ICollection<ReceiptDetail> ReceiptDetails { set; get; }
    }
}
