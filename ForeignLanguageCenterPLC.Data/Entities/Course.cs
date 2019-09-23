using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("Courses")]
    public class Course: DomainEntity<int>, ISwitchable, IDateTracking
    {
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string TraingTime { get; set; }

        [Required]
        public int NumberOfSession { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [Required]
        public Status Status { get; set; }
    }
}
