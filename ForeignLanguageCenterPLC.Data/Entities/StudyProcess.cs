using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("StudyProcess")]
    public class StudyProcess : DomainEntity<int>, ISwitchable, IDateTracking
    {

        public DateTime OutDate { get; set; }

        public DateTime InDate { get; set; }

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
        public string LearnerId { get; set; }

        /*Reference Table*/

        [ForeignKey("LearnerId")]
        public virtual Learner Learner { get; set; }


        [ForeignKey("LanguageClassId")]
        public virtual LanguageClass LanguageClass { get; set; }

    }
}
