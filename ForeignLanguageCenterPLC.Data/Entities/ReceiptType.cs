using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("ReceiptTypes")]
    public class ReceiptType : DomainEntity<int>, ISwitchable, IDateTracking
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }

        /*List of References */

        public virtual ICollection<Receipt> Receipts { set; get; }
    }
}
