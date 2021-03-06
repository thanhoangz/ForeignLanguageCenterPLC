﻿using ForeignLanguageCenterPLC.Infrastructure.Enums;
using ForeignLanguageCenterPLC.Infrastructure.Interfaces;
using ForeignLanguageCenterPLC.Infrastructure.SharedKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ForeignLanguageCenterPLC.Data.Entities
{
    /// <summary>
    /// Nhân viên
    /// </summary>
    [Table("Personnels")]
    public class Personnel: DomainEntity<string>, ISwitchable, IDateTracking
    {

        [StringLength(100)]
        public string CardId { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        public bool Sex { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        [StringLength(500)]
        public string Address { get; set; }

        [Required]

        [StringLength(100)]
        public string Nationality { get; set; }

        [Required]
        public int MarritalStatus { get; set; }

        public string ExperienceRecord { get; set; }


        [StringLength(200)]
        public string Email { get; set; }


        [StringLength(200)]
        public string Facebook { get; set; }

        [Column(TypeName = "VARCHAR(16)")]
        public string Phone { get; set; }

        [Required]
        public string Position { get; set; }

        [Required]
        public string Certificate { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public decimal BasicSalary { get; set; }

        [Required]
        public decimal Allowance { get; set; }

        [Required]
        public decimal Bonus { get; set; }

        [Required]
        public decimal InsurancePremium { get; set;}

        [Required]
        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        [Required]
        public Status Status { get; set; }

        public string Note { get; set; }

        public DateTime QuitWorkDay { get; set; }


        /* Foreign Key */

        /*Reference Table*/

        /*List of References */

        public virtual ICollection<Receipt> Receipts { set; get; }

        public virtual ICollection<Timesheet> Timesheets { set; get; }

        [InverseProperty(nameof(PaySlip.Personnel))]
        public virtual ICollection<PaySlip> PersonnelPaySlip { set; get; }

        [InverseProperty(nameof(PaySlip.SendPersonnel))]
        public virtual ICollection<PaySlip> SendPersonnelPaySlip { set; get; }
    }
}
