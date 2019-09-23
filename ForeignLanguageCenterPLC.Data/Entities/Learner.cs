using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    [Table("Learners")]
    public class Learner : DomainEntity<string>, ISwitchable, IDateTracking
    {
        
        public string CardId { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        public string Email { get; set; }

        public string Facebook { get; set; }

        [Column(TypeName ="VARCHAR(16)")]
        public string Phone { get; set; }

        [Required]
        public string ParentFullName { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(16)")]
        public string ParentPhone { get; set; }

        public string Image { get; set; }

        [Required]
        public Status Status { get; set; }

        public string Note { get; set; }

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

    }
}
