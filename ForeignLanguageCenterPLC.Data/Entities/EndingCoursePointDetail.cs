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
    [Table("EndingCoursePointDetails")]
    public class EndingCoursePointDetail : DomainEntity<int>, ISwitchable, IDateTracking, ISortable
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
        public int SortOrder { get; set; }
    }
}
