﻿using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("Users")]
    public class User : DomainEntity<int>, ISwitchable, IDateTracking
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }


        /* Foreign Key */
        /*Reference Table*/
        /*List of References */
        public virtual ICollection<EndingCoursePoint> EndingCoursePoints { set; get; }
        public virtual ICollection<Receipt> Receipts { set; get; }
        public virtual ICollection<Timesheet> Timesheets { set; get; }
        public virtual ICollection<AttendanceSheet> AttendanceSheets { set; get; }
    }
}
