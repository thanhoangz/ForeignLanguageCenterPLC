using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    /// <summary>
    /// Điểm định kỳ
    /// </summary>
    [Table("PeriodicPoints")]
    public class PeriodicPoint : DomainEntity<int>, ISwitchable, IDateTracking
    {

        /// <summary>
        /// Ngày vào điểm
        /// </summary>
        [Required]
        public DateTime DateOnPoint { get; set; }

        /// <summary>
        /// Ngày tổ chức thi, kiểm tra
        /// </summary>
        [Required]
        public DateTime ExaminationDate { get; set; }

        [Required]
        public int Week { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }
       
    }
}
