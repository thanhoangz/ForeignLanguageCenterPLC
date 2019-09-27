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
    /// Tờ điểm danh
    /// </summary>
    [Table("AttendanceSheets")]
    public class AttendanceSheet : DomainEntity<int>, ISwitchable, IDateTracking
    {

        /// <summary>
        /// Tiền công giảng dạy với giáo viên
        /// </summary>
        public decimal WageOfLecturer { get; set; }

        /// <summary>
        /// Tiền công giảng dạy với trợ giảng
        /// </summary>
        public decimal WageOfTutor { get; set; }


        /// <summary>
        /// Ngày điểm danh
        /// </summary>
        public DateTime Date { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string Note { get; set; }

        /* Foreign Key */

        [Required]
        public string LanguageClassId { get; set; }

        [Required]
        public int LecturerId { get; set; }

        [Required]
        public int TutorId { get; set; }

        [Required]
        public int UserId { get; set; }

        /*Reference Table*/

        [ForeignKey("LanguageClassId")]
        public virtual LanguageClass LanguageClass { get; set; }

        [ForeignKey("LecturerId")]
        public virtual Lecturer Lecturer { get; set; }


        [ForeignKey("TutorId")]
        public virtual Lecturer Tutor { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        /*List of References */
        public virtual ICollection<AttendanceSheetDetail> AttendanceSheetDetails { set; get; }
    }
}
