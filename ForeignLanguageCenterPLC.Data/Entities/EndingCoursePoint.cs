using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    /// <summary>
    /// Điểm kết thúc khóa học
    /// </summary>
    [Table("EndingCoursePoints")]
    public class EndingCoursePoint : DomainEntity<int>, ISwitchable, IDateTracking
    {

        public decimal ListeningPoint { get; set; }

        public decimal SayingPoint { get; set; }

        public decimal WritingPoint { get; set; }

        public decimal ReadingPoint { get; set; }

        public decimal TotalPoint { get; set; }

        public decimal AveragePoint { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }
    }
}
