﻿using ForeignLanguageCenterPLC.Infrastructure.Enums;
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

      

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }
    }
}
