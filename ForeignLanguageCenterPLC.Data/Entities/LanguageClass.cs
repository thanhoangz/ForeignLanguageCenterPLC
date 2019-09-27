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
    /// <summary>
    /// Lớp ngôn ngữ (mặc định tiếng anh)
    /// </summary>
    [Table("LanguageClasses")]
    public class LanguageClass : DomainEntity<string>, ISwitchable, IDateTracking
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public decimal CourseFee { get; set; }

        [Required]
        public decimal MonthlyFee { get; set; }

        [Required]
        public decimal LessonFee { get; set; }

        [Required]
        public DateTime StartDay { get; set; }

        [Required]
        public DateTime EndDay { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }
    }
}
